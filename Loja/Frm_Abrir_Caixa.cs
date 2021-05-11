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
    public partial class Frm_Abrir_Caixa : Form
    {
        public Frm_Abrir_Caixa()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Btn_fechar_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Btn_abrir_caixa_Click(object sender, EventArgs e)
        {
            if(Txt_valor_abertura.Text != "")
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Properties.Settings.Default.conexao;

                SqlCommand comando = new SqlCommand();


            }
            else
            {
                MessageBox.Show("Entre com o valor de caixa !");
            }
        }
    }
}
