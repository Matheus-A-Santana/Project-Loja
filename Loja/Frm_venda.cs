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
            Txt_desconto.Text = "0";
        }

        private int id_pagamento;
        private int id_venda;
        private int id_caixa;

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
                Txt_valor_pago.Text = Txt_total_pagar.Text;
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
            double total = 0, desconto = 0;
            
            foreach(DataGridViewRow Row in Dgv_produtos_vendas.Rows)
            {
                total += Convert.ToDouble(Row.Cells["Column5"].Value);
            }
            if(Txt_desconto.Text != "")
            {
                desconto = Convert.ToDouble(Txt_desconto.Text);
                Txt_total_pagar.Text = Convert.ToString(total - desconto);
            }
            else
            {
                Txt_total_pagar.Text = Convert.ToString(total);
            }
        }

        private void Troco()
        {
            double total = 0, valor_pago = 0;
            if(Txt_valor_pago.Text != "")
            {
                total = Convert.ToDouble(Txt_total_pagar.Text.Trim());
                valor_pago = Convert.ToDouble(Txt_valor_pago.Text.Trim());

                Txt_troco.Text = Convert.ToString(valor_pago - total);
            }
        }

        private void Txt_desconto_TextChanged(object sender, EventArgs e)
        {
            TotalCompra();
        }

        private void Txt_valor_pago_TextChanged(object sender, EventArgs e)
        {
            Troco();
        }

        private void Cbo_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_pagamento.Text != "")
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
                        CommandText = "SELECT id FROM forma_pagamento WHERE forma = @nome",
                        Connection = conexao
                    };
                    conexao.Open();
                    comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = Cbo_pagamento.Text;
                    SqlDataReader DR = comando.ExecuteReader();

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            id_pagamento = Convert.ToInt32(DR["id"]);
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
                MessageBox.Show("Selecione uma Forma de pagamento !");
            }
        }


        private void Btn_finalizar_venda_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection
            {
                ConnectionString = Properties.Settings.Default.conexao
            };

            SqlCommand comando_caixa = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Caixa WHERE id = (SELECT MAX(id) FROM Caixa)",
                Connection = conexao
            };
            conexao.Open();

            SqlDataReader dr = comando_caixa.ExecuteReader();
            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        situacao = Convert.ToBoolean(dr["situacao"]);
                        id_caixa = Convert.ToInt32(dr["id"]);
                    }
                    conexao.Close();
                    if (situacao == true)
                    {
                        if(id_pagamento == 1)
                        {
                            try
                            {
                                SqlCommand acrescimo_caixa = new SqlCommand("SP_ACRESCIMO_CAIXA", conexao);
                                acrescimo_caixa.CommandType = CommandType.StoredProcedure;
                                acrescimo_caixa.Connection = conexao;

                                acrescimo_caixa.Parameters.Add("@acrescimo", SqlDbType.Money).Value = Txt_total_pagar.Text;

                                conexao.Open();
                                acrescimo_caixa.ExecuteNonQuery();
                                conexao.Close();
                            }
                            catch (Exception ac)
                            {
                                MessageBox.Show(ac.Message);
                            }
                            
                        }

                        SqlCommand comando = new SqlCommand("SP_LANCAR_VENDA", conexao);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Connection = conexao;
                        conexao.Open();
                        try
                        {
                            comando.Parameters.Add("@total_venda", SqlDbType.Money).Value = Txt_total_pagar.Text;
                            comando.Parameters.Add("@data", SqlDbType.Date).Value = Lbl_data_lancamento.Text;
                            comando.Parameters.Add("@hora", SqlDbType.Time).Value = Lbl_hora.Text;
                            comando.Parameters.Add("@id_pagamento", SqlDbType.Int).Value = id_pagamento;
                            comando.Parameters.Add("@id_caixa", SqlDbType.Int).Value = id_caixa;

                            comando.ExecuteNonQuery();
                            conexao.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        SqlCommand comando2 = new SqlCommand();
                        comando.CommandText = "SELECT MAX(id) FROM venda";
                        comando.CommandType = CommandType.Text;
                        comando.Connection = conexao;
                        conexao.Open();
                        try
                        {
                            SqlDataReader DR = comando.ExecuteReader();

                            while (DR.Read())
                            {
                                id_venda = DR.GetInt32(0);
                            }
                            conexao.Close();
                            MessageBox.Show(id_venda.ToString());
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message);
                        }

                        SqlCommand comando3 = new SqlCommand("SP_LANCAR_SAIDA", conexao);
                        comando3.CommandType = CommandType.StoredProcedure;
                        comando3.Connection = conexao;
                        conexao.Open();

                        try
                        {
                            for (int i = 0; i < Dgv_produtos_vendas.Rows.Count - 1; i++)
                            {
                                comando3.Parameters.Add("@id_produto", SqlDbType.Int).Value = Dgv_produtos_vendas.Rows[i].Cells[0].Value;
                                comando3.Parameters.Add("@quantidade", SqlDbType.Int).Value = Dgv_produtos_vendas.Rows[i].Cells[2].Value;
                                comando3.Parameters.Add("@preco", SqlDbType.Money).Value = Dgv_produtos_vendas.Rows[i].Cells[3].Value;
                                comando3.Parameters.Add("@total", SqlDbType.Money).Value = Dgv_produtos_vendas.Rows[i].Cells[4].Value;
                                comando3.Parameters.Add("@desconto", SqlDbType.Money).Value = Txt_desconto.Text;
                                comando3.Parameters.Add("@id_venda", SqlDbType.Int).Value = id_venda;

                                comando3.ExecuteNonQuery();
                                comando3.Parameters.Clear();
                            }
                            conexao.Close();
                            MessageBox.Show("Venda Finalizada !");
                            Dgv_produtos_vendas.Rows.Clear();
                            Txt_total_pagar.Text = "";
                            Txt_valor_pago.Text = "";
                            Txt_desconto.Text = "";
                            Txt_troco.Text = "";
                            Cbo_pagamento.SelectedIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O Caixa encontra-se na situação de fechado !");
                        Frm_Abrir_Caixa Abertura = new Frm_Abrir_Caixa();
                        Abertura.Show();
                    }
                }
                else
                {
                    Frm_Abrir_Caixa Abertura = new Frm_Abrir_Caixa();
                    Abertura.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool situacao = false; 

        private void Frm_venda_Load(object sender, EventArgs e)
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
                    }
                    conexao.Close();
                    if (situacao == false)
                    {
                        Frm_Abrir_Caixa Abertura = new Frm_Abrir_Caixa();
                        Abertura.Show();
                    }
                }
                else
                {
                    Frm_Abrir_Caixa Abertura = new Frm_Abrir_Caixa();
                    Abertura.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
