using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Frm_Fechar_Caixa : Form
    {
        public Frm_Fechar_Caixa()
        {
            InitializeComponent();
        }

        private bool situacao = false;
        private double valor_abertura = 0;
        private double valor_fechamento = 0;
        private double valor_divergencia = 0;
        int tentativa = 1;

        private void Tbl_caixa_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void Btn_fechar_caixa_Click(object sender, EventArgs e)
        {
        inicio:
            if(Txt_valor_fechamento.Text != "")
            {
                valor_fechamento = Convert.ToDouble(Txt_valor_fechamento.Text);
                if (valor_abertura != valor_fechamento)
                {
                    while (tentativa < 3)
                    {
                        MessageBox.Show("Tentativa: " + tentativa.ToString());
                        tentativa++;
                        Txt_valor_fechamento.Clear();
                        if (tentativa == 3)
                            MessageBox.Show("ultima tenativa !");
                        goto inicio;
                    }
                    Salvar();
                    valor_divergencia = valor_abertura - valor_fechamento;
                    MessageBox.Show("Divergencia de: " + valor_divergencia.ToString());   
                }
                else
                {
                    Salvar();
                }
            }
        }

        private void Salvar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.conexao;

            SqlCommand comando = new SqlCommand("SP_FECHAR_CAIXA", conexao);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexao;

            try
            {
                conexao.Open();

                comando.Parameters.Add("@situacao", SqlDbType.Bit).Value = false;
                comando.Parameters.Add("@valor_fechamento", SqlDbType.Money).Value = valor_fechamento;
                comando.Parameters.Add("@valor_divergencia", SqlDbType.Money).Value = valor_divergencia;
                comando.Parameters.Add("@data_fechamento", SqlDbType.Date).Value = Lbl_data.Text;

                int i = comando.ExecuteNonQuery();
                if(i > 0)
                {
                    MessageBox.Show("Caixa Fechado com Sucesso !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_valor_fechamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != ',')
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void Frm_Fechar_Caixa_Load(object sender, EventArgs e)
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
                            valor_abertura = Convert.ToDouble(dr["abertura"]);
                        }
                        else
                        {
                            MessageBox.Show("O Caixa se encontra na situação Fechada !");
                            Btn_fechar_caixa.Enabled = false;
                            Txt_valor_fechamento.Enabled = false;
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

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
