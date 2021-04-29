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
    public partial class Frm_cadastrar_produto : Form
    {
        public Frm_cadastrar_produto()
        {
            InitializeComponent();
            CargaComboBox();
        }

        decimal valor1 = 0, valor2 = 0, resto = 0, total = 0;
        string local = "";

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int id_categoria;
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

        private void Cbo_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cbo_categoria.Text != "")
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
                        CommandText = "SELECT id FROM Categoria where nome = @nome",
                        Connection = conexao
                    };
                    conexao.Open();
                    comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cbo_categoria.Text;
                    SqlDataReader DR = comando.ExecuteReader();

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            id_categoria = Convert.ToInt32(DR["id"]);
                        }
                    }
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma categoria !");
            }
        }

        private void Txt_porcentagem_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void Btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog message = new OpenFileDialog();
            message.Filter = "Image File(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png;";
            if (message.ShowDialog() == DialogResult.OK)
            {
                local = message.FileName.ToString();
                Pic_foto.ImageLocation = local;
            }
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if((Txt_nome.Text != "") && (Txt_preco_custo.Text != "") && (Txt_preco_venda.Text != "") && (Cbo_categoria.Items != null))
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.conexao;

                SqlCommand comando = new SqlCommand("SP_CAD_PRODUTOS", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexao;
                conexao.Open();
                try
                {
                    comando.Parameters.AddWithValue("@nome", Txt_nome.Text.ToUpper());
                    comando.Parameters.AddWithValue("id_categoria", id_categoria);
                    comando.Parameters.AddWithValue("imagem", (byte[])(new ImageConverter().ConvertTo(Pic_foto.Image, typeof(byte[]))));
                    comando.Parameters.AddWithValue("@descricao", Txt_descricao.Text.ToUpper());
                    comando.Parameters.AddWithValue("@quantidade", Txt_quantidade.Text);
                    comando.Parameters.Add("@custo", SqlDbType.Decimal).Value = Txt_preco_custo.Text;
                    comando.Parameters.Add("@venda", SqlDbType.Decimal).Value = Txt_preco_venda.Text;

                    comando.ExecuteNonQuery();
                    conexao.Close();

                    DialogResult dialog = MessageBox.Show("Produto Cadastrado com Sucesso !");

                    if (dialog == DialogResult.OK)
                    {
                        Txt_nome.Text = "";
                        Txt_quantidade.Text = "";
                        Txt_descricao.Text = "";
                        Txt_preco_custo.Text = "";
                        Txt_porcentagem.Text = "";
                        Txt_preco_venda.Text = "";
                        Pic_foto.Image = null;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos Obrigatórios ! 'Nome:' 'Categoria:' 'Preço de Custo:' 'Preço de Venda:' ");
            }
        }

        private void Txt_preco_venda_TextChanged(object sender, EventArgs e)
        {
            if((Txt_preco_custo.Text == "") && (Txt_porcentagem.Text == ""))
            {
                this.Text = "";
            }
        }

        private void Txt_preco_custo_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void CalculoVenda()
        {
            if((Txt_preco_custo.Text != "") && (Txt_porcentagem.Text != ""))
            {
                valor1 = decimal.Parse(Txt_preco_custo.Text);
                valor2 = decimal.Parse(Txt_porcentagem.Text);
                if(valor1 == 0 && valor2 == 0)
                {
                    MessageBox.Show("Número zero não é aceito !");
                }
                else
                {
                    resto = (valor2 / 100) * valor1;
                    total = resto + valor1;
                }
            }
            Txt_preco_venda.Text = total.ToString();
        }
    }
}
