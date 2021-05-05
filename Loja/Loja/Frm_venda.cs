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
    public partial class Frm_venda : Form
    {
        public Frm_venda()
        {
            InitializeComponent();
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_data_lancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
