using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loja
{
    public partial class Frm_categoria_produto : Form
    {
        public Frm_categoria_produto()
        {
            InitializeComponent();
        }

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Txt_nome.Text)) // condicional para campo vazio
            {
                try
                {
                    SqlConnection conexao = new SqlConnection
                    {
                        ConnectionString = Properties.Settings.Default.conexao
                    };
                    SqlCommand comando = new SqlCommand("SP_ADD_CATEGORIA", conexao)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Connection = conexao
                    };
                    comando.Parameters.Add("nome", SqlDbType.VarChar).Value = Txt_nome.Text.ToUpper();
                    comando.Parameters.Add("descricao", SqlDbType.VarChar).Value = Txt_descricao.Text.ToUpper();

                    conexao.Open();
                    comando.ExecuteNonQuery();
                    DialogResult dialog = MessageBox.Show("Categoria cadastrada !");
                    conexao.Close();

                    if (dialog == DialogResult.OK)
                    {
                        Txt_nome.Text = "";
                        Txt_descricao.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Campo nome da categoria está vazio !");
            }

        }
    }
}
