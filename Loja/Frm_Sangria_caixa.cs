using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Frm_Sangria_caixa : Form
    {
        public Frm_Sangria_caixa()
        {
            InitializeComponent();
        }

        private bool situacao;
        private int id_caixa;

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Sangria_caixa_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection
            {
                ConnectionString = Properties.Settings.Default.conexao
            };

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Caixa WHERE id = (SELECT MAX(id) FROM Caixa)",
                Connection = conexao
            };
            conexao.Open();

            SqlDataReader dr = comando.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        situacao = Convert.ToBoolean(dr["situacao"]);
                        if (situacao == true)
                        {
                            id_caixa = Convert.ToInt32(dr["id"]);
                        }
                        else
                        {
                            MessageBox.Show("O Caixa se encontra na situação Fechada !");
                            Txt_valor_sangria.Enabled = false;
                            Txt_descricao.Enabled = false;
                            Btn_inserir.Enabled = false;
                        }
                    }
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Txt_valor_sangria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Btn_inserir_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection
            {
                ConnectionString = Properties.Settings.Default.conexao
            };

            SqlCommand comando = new SqlCommand("SP_SANGRIA", conexao);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexao;

            try
            {
                conexao.Open();
                comando.Parameters.Add("@valor", SqlDbType.Money).Value = Txt_valor_sangria.Text;
                comando.Parameters.Add("@descricao", SqlDbType.VarChar).Value = Txt_descricao.Text;
                comando.Parameters.Add("@hora", SqlDbType.Time).Value = Lbl_hora.Text;
                comando.Parameters.Add("@id_caixa", SqlDbType.Int).Value = id_caixa;

                int i = comando.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Sangria feita com sucesso !");
                    Txt_valor_sangria.Clear();
                    Txt_descricao.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
