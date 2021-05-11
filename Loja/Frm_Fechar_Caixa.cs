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
    public partial class Frm_Fechar_Caixa : Form
    {
        public Frm_Fechar_Caixa()
        {
            InitializeComponent();
        }

        private bool situacao = false;
        private double valor_abertura = 0;

        private void Tbl_caixa_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Btn_fechar_caixa_Click(object sender, EventArgs e)
        {
            int tentativa = 0;
            if (valor_abertura != Convert.ToDouble(Txt_valor_fechamento.Text))
            {
                while (tentativa < 3)
                {
                    while (valor_abertura != Convert.ToDouble(Txt_valor_fechamento.Text))
                    {
                        MessageBox.Show("Tentativa:" + tentativa);
                        if (tentativa == 3)
                        {
                            salvar();
                        }
                        tentativa++;
                    }
                }
            }
            else
            {
                salvar();
            }
        }

        private void salvar()
        {
            MessageBox.Show("salvo");
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
                            MessageBox.Show(situacao.ToString() + valor_abertura.ToString()); 
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
    }
}
