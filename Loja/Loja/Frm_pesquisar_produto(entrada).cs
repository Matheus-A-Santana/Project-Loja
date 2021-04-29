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
    public partial class Frm_pesquisar_produto_entrada_ : Form
    {
        public Frm_pesquisar_produto_entrada_()
        {
            InitializeComponent();
            CargaComboBox();
        }
        private void CargaComboBox()
        {
            try
            {
                SqlConnection conexao = new SqlConnection
                {
                    ConnectionString = Properties.Settings.Default.conexao
                };

                SqlCommand comando = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = "SELECT nome FROM Categoria"
                };
                comando.Connection = conexao;
                conexao.Open();
                SqlDataReader DR = comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(DR);
                conexao.Close();
                Cbo_categoria.DisplayMember = "nome";
                Cbo_categoria.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcurarProduto()
        {
            if((Txt_Procurar_produto.Text.Trim() != "") || (Cbo_categoria.Text != ""))
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.conexao;

                SqlCommand comando = new SqlCommand("SP_PESQ_PRODUTO", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexao;

                try
                {
                    comando.Parameters.AddWithValue("@nome", Txt_Procurar_produto.Text);
                    comando.Parameters.AddWithValue("@categoria", Cbo_categoria.Text);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    SqlDataReader DR = comando.ExecuteReader();

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            
                        }
                    }
                   
                    conexao.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Btn_fechar_pesquisar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Procurar_produto_TextChanged(object sender, EventArgs e)
        {
            ProcurarProduto();
        }

        private void Cbo_categoria_TextChanged(object sender, EventArgs e)
        {
            ProcurarProduto();
        }
    }
}
