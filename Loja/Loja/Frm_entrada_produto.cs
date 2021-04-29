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
    public partial class Frm_entrada_produto : Form
    {
        public Frm_entrada_produto()
        {
            InitializeComponent();
        }

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data_lancamento.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
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
    }
}
