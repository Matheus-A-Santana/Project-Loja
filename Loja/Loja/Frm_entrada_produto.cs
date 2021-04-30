using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loja
{
    public partial class Frm_entrada_produto : Form
    {
        public Frm_entrada_produto()
        {
            InitializeComponent();
        }

        public byte[] foto;

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data_lancamento.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Frm_entrada_produto_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Btn_abrir_pesquisar_Click(object sender, EventArgs e)
        {
            Frm_pesquisar_produto_entrada_ subMenu = new Frm_pesquisar_produto_entrada_();
            subMenu.Show();
        }

        private void Txt_nome_produto_TextChanged(object sender, EventArgs e)
        {
        }

        private void Txt_qtd_compra_TextChanged(object sender, EventArgs e)
        {
            if((Txt_qtd_compra.Text != "") && (Txt_qtd_estoque.Text != ""))
            {
                int estoque_atual = Convert.ToInt32(Txt_qtd_estoque.Text);
                int qtd_compra = Convert.ToInt32(Txt_qtd_compra.Text);

                Txt_novo_estoque.Text = Convert.ToString(estoque_atual + qtd_compra);
            }
            else
            {
                Txt_novo_estoque.Text = "";
            }
            TotalNota();
        }

        private void TotalNota()
        {
            if((Txt_qtd_compra.Text != "") && Txt_custo_produto.Text != "")
            {
                int qtd_compra = Convert.ToInt32(Txt_qtd_compra.Text);
                decimal custo = Convert.ToDecimal(Txt_custo_produto.Text);

                Txt_vlr_total_nota.Text = Convert.ToString(custo * qtd_compra);
            }
            else
            {
                Txt_vlr_total_nota.Text = "";
            }
        }

        private void CalculoVenda()
        {
            if ((Txt_custo_produto.Text != "") && (Txt_Porc_venda.Text != ""))
            {
                decimal valor1 = decimal.Parse(Txt_custo_produto.Text);
                decimal valor2 = decimal.Parse(Txt_Porc_venda.Text);
                if (valor1 == 0 && valor2 == 0)
                {
                    MessageBox.Show("Número zero não é aceito !");
                }
                else
                {
                    decimal resto = (valor2 / 100) * valor1;
                    Txt_venda_produto.Text = Convert.ToString(resto + valor1);
                }
            }
            else if((Txt_custo_produto.Text == "") && (Txt_Porc_venda.Text != ""))
            {
                Txt_venda_produto.Text = "";
            }
        }

        private void Txt_custo_produto_TextChanged(object sender, EventArgs e)
        {
            TotalNota();
            CalculoVenda();
        }

        private void Txt_Porc_venda_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void Txt_venda_produto_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void clear()
        {
            Lbl_id.Text = "Id";
            Txt_nome_produto.Text = "";
            Cbo_categoria_produto.Text = "";
            Txt_descricao_produto.Text = "";
            Txt_qtd_estoque.Text = "";
            Txt_novo_estoque.Text = "";
            Txt_qtd_compra.Text = "";
            Txt_custo_produto.Text = "";
            Txt_Porc_venda.Text = "";
            Txt_venda_produto.Text = "";
            Txt_vlr_total_nota.Text = "";
            pictureCircle1.Image = null;
        }

        private void Btn_lancar_entrada_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Os Campos estão corretos ?","Confirmação" ,MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.conexao;

                SqlCommand comando = new SqlCommand("SP_LANCAR_ENTRADA", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexao;
                conexao.Open();

                try
                { 
                    //lancamento de entrada
                    comando.Parameters.Add("@quantidade", SqlDbType.Int).Value = Txt_qtd_compra.Text;
                    comando.Parameters.Add("@custo", SqlDbType.Decimal).Value = Txt_custo_produto.Text;
                    comando.Parameters.Add("@valor_total", SqlDbType.Decimal).Value = Txt_vlr_total_nota.Text;
                    comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = Lbl_id.Text;
                    comando.Parameters.Add("@data", SqlDbType.DateTime).Value = Lbl_data_lancamento.Text;

                    //Atualiando estoque
                    comando.Parameters.Add("@quantidade_total", SqlDbType.Int).Value = Txt_novo_estoque.Text;
                    comando.Parameters.Add("@venda", SqlDbType.Decimal).Value = Txt_venda_produto.Text;

                    int i = comando.ExecuteNonQuery();
                    conexao.Close();
                    if(i > 0)
                    {
                        MessageBox.Show("Lançamento Efetuado com sucesso !");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro no lançamento !");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
