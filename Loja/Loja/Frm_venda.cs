using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Frm_venda : Form
    {
        public Frm_venda()
        {
            InitializeComponent();
            timer1.Start();
            CargaComboBox();
            TotalCompra();
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
                    CommandText = "SELECT forma FROM forma_pagamento"
                };
                comando.Connection = conexao;
                conexao.Open();
                SqlDataReader DR = comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(DR);
                conexao.Close();
                Cbo_pagamento.DisplayMember = "forma";
                Cbo_pagamento.DataSource = DT;
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data_lancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Txt_id_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Txt_id_produto.Text != "")
            {
                if ((e.KeyChar == Convert.ToChar(Keys.Enter)) || (e.KeyChar == Convert.ToChar(Keys.Tab)))
                {
                    SqlConnection conexao = new SqlConnection
                    {
                        ConnectionString = Properties.Settings.Default.conexao
                    };

                    SqlCommand comando = new SqlCommand
                    {
                        CommandType = CommandType.Text,
                        CommandText = "select Produtos.id, Produtos.nome, Produtos.imagem, Estoque.preco_venda from Produtos inner join Estoque on Produtos.id = Estoque.id_produto where Produtos.id = @id"
                    };
                    comando.Connection = conexao;
                    conexao.Open();
                    try
                    {
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = Txt_id_produto.Text;

                        SqlDataReader dr;
                        dr = comando.ExecuteReader();

                        while (dr.Read())
                        {
                            Txt_nome_produto.Text = Convert.ToString(dr["nome"]);
                            Txt_valor_produto.Text = Convert.ToString(dr["preco_venda"]);
                            MemoryStream mstream = new MemoryStream((byte[])(dr["imagem"]));
                            Pic_imagem_produto.Image = Image.FromStream(mstream);
                            Pic_imagem_produto.Refresh();
                        }
                        conexao.Close();
                        Txt_quantidade_compra.Text = "1";
                        Txt_quantidade_compra.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Txt_quantidade_compra_TextChanged(object sender, EventArgs e)
        {
            if(Txt_quantidade_compra.Text != "")
            {
                int quantidade = Convert.ToInt32(Txt_quantidade_compra.Text);
                decimal valor = Convert.ToDecimal(Txt_valor_produto.Text);

                Lbl_total.Text = Convert.ToString(valor * quantidade);
            }
            else
            {
                Lbl_total.Text = "TOTAL:";
            }
        }

        private void Txt_quantidade_compra_Click(object sender, EventArgs e)
        {
            Txt_quantidade_compra.Text = "";
        }

        private void Btn_Adcionar_Click(object sender, EventArgs e)
        {
            if(Txt_nome_produto.Text != "")
            {
                Dgv_produtos_vendas.Rows.Add(Txt_id_produto.Text, Txt_nome_produto.Text, Txt_quantidade_compra.Text, Txt_valor_produto.Text, Lbl_total.Text);
                Txt_id_produto.Text = "";
                Txt_nome_produto.Text = "";
                Txt_quantidade_compra.Text = "";
                Txt_valor_produto.Text = "";
                Lbl_total.Text = "TOTAL:";
                Pic_imagem_produto.Image = null;
                Pic_imagem_produto.Refresh();
                Txt_id_produto.Focus();
                TotalCompra();
            }
            else
            {
                MessageBox.Show("Inválido ! Selecione um Produto !");
            }
            
        }

        private void Txt_quantidade_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Btn_Adcionar.Focus();
        }

        private void TotalCompra()
        {
            double total = 0;
            
            foreach(DataGridViewRow Row in Dgv_produtos_vendas.Rows)
            {
                total += Convert.ToDouble(Row.Cells["Column5"].Value);
            }
            Txt_total_pagar.Text = Convert.ToString(total);
        }
    }
}
