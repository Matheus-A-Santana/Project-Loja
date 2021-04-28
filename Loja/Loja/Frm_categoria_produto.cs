using Loja.Business_Logic_Layer;
using Loja.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Produtos_DTO categoria = new Produtos_DTO // adicionando valores do textbox no data transfer como maiusculas
            {
                Categoria = Txt_nome.Text.ToUpper(),
                Descricao = Txt_descricao.Text.ToUpper()
            };

            if(!string.IsNullOrEmpty(Txt_nome.Text)) // condicional para campo vazio
            {
                try
                {
                    new Produtos_BLL().Categoria(categoria); //passando para o Business Logic Layer
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DialogResult dialog = MessageBox.Show("Categoria cadastrada !");

                if (dialog == DialogResult.OK)
                {
                    Txt_nome.Text = "";
                    Txt_descricao.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Campo nome da categoria está vazio !");
            }

        }
    }
}
