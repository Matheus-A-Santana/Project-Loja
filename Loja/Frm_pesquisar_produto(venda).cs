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
    public partial class Frm_pesquisar_produto_venda_ : Form
    {
        public Frm_venda venda;

        public Frm_pesquisar_produto_venda_()
        {
            InitializeComponent();
            CargaComboBox();
            venda = Application.OpenForms["Frm_venda"] as Frm_venda;
        }

        private void Btn_fechar_pesquisar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    CommandText = "SELECT categoria FROM Categoria"
                };
                comando.Connection = conexao;
                conexao.Open();
                SqlDataReader DR = comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(DR);
                conexao.Close();
                Cbo_categoria.DisplayMember = "categoria";
                Cbo_categoria.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcurarProduto()
        {
            if ((Txt_Procurar_produto.Text.Trim() != "") || (Cbo_categoria.Text != ""))
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
                    SqlDataAdapter DA = new SqlDataAdapter(comando);

                    DataTable Dt = new DataTable();
                    DA.Fill(Dt);

                    dataGridView1.DataSource = Dt;

                    dataGridView1.Columns[0].Width = 40;
                    dataGridView1.Columns[1].Width = 400;
                    dataGridView1.Columns[2].Width = 0;
                    dataGridView1.Columns[3].Width = 150;
                    dataGridView1.Columns[4].Width = 120;
                    dataGridView1.Columns[5].Width = 100;
                    dataGridView1.Columns[6].Width = 100;
                    dataGridView1.Columns[6].Width = 100;

                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Txt_Procurar_produto_TextChanged(object sender, EventArgs e)
        {
            ProcurarProduto();
        }

        private void Cbo_categoria_TextChanged(object sender, EventArgs e)
        {
            ProcurarProduto();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            venda.Txt_id_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            venda.Txt_id_produto.Focus();
            this.Close();
        }
    }
}
