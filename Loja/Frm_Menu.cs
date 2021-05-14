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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        public int id;

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tlp_mover_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Tlp_mover_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Tlp_mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true) // se drag igual a true mover o form
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Btn_Max_Min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                Btn_Max_Min.Image = Image.FromFile("../../Resources/minimizar.png");
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Btn_Max_Min.Image = Image.FromFile("../../Resources/maximizar.png");
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CustomizeDesign()
        {
            P_Sub_caixa.Visible = false;
            P_Sub_produtos.Visible = false;
        }

        private void HideSubMenu()
        {
            if (P_Sub_caixa.Visible == true)
                P_Sub_caixa.Visible = false;
            if (P_Sub_produtos.Visible == true)
                P_Sub_produtos.Visible = false;
        }

        private void ShowSubMenu(Panel Submenu)
        {
            if(Submenu.Visible == false)
            {
                HideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void AbrirFormPanel(object FormFilho)
        {
            if (this.PanelForms.Controls.Count > 0)
                this.PanelForms.Controls.RemoveAt(0);
            Form formfilho = FormFilho as Form;
            formfilho.TopLevel = false;
            formfilho.Dock = DockStyle.Fill;
            this.PanelForms.Controls.Add(formfilho);
            this.PanelForms.Tag = formfilho;
            formfilho.Show();
        }

        private void Btn_caixa_Click(object sender, EventArgs e)
        {
            ShowSubMenu(P_Sub_caixa);
        }

        private void Btn_Produtos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(P_Sub_produtos);
        }

        private void Btn_venda_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_venda());
            HideSubMenu();
        }

        private void Btn_fechamento_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            AbrirFormPanel(new Frm_Fechar_Caixa());
        }

        private void Btn_sangria_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            AbrirFormPanel(new Frm_Sangria_caixa());
        }

        private void Btn_entrada_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            AbrirFormPanel(new Frm_entrada_produto());
        }

        private void Btn_categoria_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            AbrirFormPanel(new Frm_categoria_produto());
        }

        private void Btn_cadastrar_prod_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Frm_cadastrar_produto());
            HideSubMenu();
        }
    }
}
