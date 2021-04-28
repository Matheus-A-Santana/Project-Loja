
namespace Loja
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Tlp_mover = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_Sub_produtos = new System.Windows.Forms.Panel();
            this.Btn_categoria = new System.Windows.Forms.Button();
            this.Btn_entrada = new System.Windows.Forms.Button();
            this.Btn_Produtos = new System.Windows.Forms.Button();
            this.P_Sub_caixa = new System.Windows.Forms.Panel();
            this.Btn_sangria = new System.Windows.Forms.Button();
            this.Btn_fechamento = new System.Windows.Forms.Button();
            this.Btn_venda = new System.Windows.Forms.Button();
            this.Btn_caixa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.Btn_cadastrar_prod = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Max_Min = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Tlp_mover.SuspendLayout();
            this.panel1.SuspendLayout();
            this.P_Sub_produtos.SuspendLayout();
            this.P_Sub_caixa.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tlp_mover
            // 
            this.Tlp_mover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Tlp_mover.ColumnCount = 4;
            this.Tlp_mover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.Tlp_mover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Tlp_mover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Tlp_mover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Tlp_mover.Controls.Add(this.label1, 0, 0);
            this.Tlp_mover.Controls.Add(this.Btn_Exit, 3, 0);
            this.Tlp_mover.Controls.Add(this.Btn_Max_Min, 2, 0);
            this.Tlp_mover.Controls.Add(this.Btn_minimizar, 1, 0);
            this.Tlp_mover.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tlp_mover.Location = new System.Drawing.Point(0, 0);
            this.Tlp_mover.Name = "Tlp_mover";
            this.Tlp_mover.RowCount = 1;
            this.Tlp_mover.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_mover.Size = new System.Drawing.Size(1188, 28);
            this.Tlp_mover.TabIndex = 0;
            this.Tlp_mover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tlp_mover_MouseDown);
            this.Tlp_mover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tlp_mover_MouseMove);
            this.Tlp_mover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tlp_mover_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagolinha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.P_Sub_produtos);
            this.panel1.Controls.Add(this.Btn_Produtos);
            this.panel1.Controls.Add(this.P_Sub_caixa);
            this.panel1.Controls.Add(this.Btn_caixa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 651);
            this.panel1.TabIndex = 1;
            // 
            // P_Sub_produtos
            // 
            this.P_Sub_produtos.Controls.Add(this.Btn_cadastrar_prod);
            this.P_Sub_produtos.Controls.Add(this.Btn_categoria);
            this.P_Sub_produtos.Controls.Add(this.Btn_entrada);
            this.P_Sub_produtos.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Sub_produtos.Location = new System.Drawing.Point(0, 350);
            this.P_Sub_produtos.Name = "P_Sub_produtos";
            this.P_Sub_produtos.Size = new System.Drawing.Size(245, 165);
            this.P_Sub_produtos.TabIndex = 4;
            // 
            // Btn_categoria
            // 
            this.Btn_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_categoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_categoria.FlatAppearance.BorderSize = 0;
            this.Btn_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_categoria.Location = new System.Drawing.Point(0, 46);
            this.Btn_categoria.Name = "Btn_categoria";
            this.Btn_categoria.Size = new System.Drawing.Size(245, 46);
            this.Btn_categoria.TabIndex = 6;
            this.Btn_categoria.Text = "Categoria";
            this.Btn_categoria.UseVisualStyleBackColor = false;
            this.Btn_categoria.Click += new System.EventHandler(this.Btn_categoria_Click);
            // 
            // Btn_entrada
            // 
            this.Btn_entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_entrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_entrada.FlatAppearance.BorderSize = 0;
            this.Btn_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_entrada.Location = new System.Drawing.Point(0, 0);
            this.Btn_entrada.Name = "Btn_entrada";
            this.Btn_entrada.Size = new System.Drawing.Size(245, 46);
            this.Btn_entrada.TabIndex = 5;
            this.Btn_entrada.Text = "Entrada";
            this.Btn_entrada.UseVisualStyleBackColor = false;
            this.Btn_entrada.Click += new System.EventHandler(this.Btn_entrada_Click);
            // 
            // Btn_Produtos
            // 
            this.Btn_Produtos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Produtos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Produtos.FlatAppearance.BorderSize = 0;
            this.Btn_Produtos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_Produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Produtos.Location = new System.Drawing.Point(0, 304);
            this.Btn_Produtos.Name = "Btn_Produtos";
            this.Btn_Produtos.Size = new System.Drawing.Size(245, 46);
            this.Btn_Produtos.TabIndex = 3;
            this.Btn_Produtos.Text = "Produtos";
            this.Btn_Produtos.UseVisualStyleBackColor = true;
            this.Btn_Produtos.Click += new System.EventHandler(this.Btn_Produtos_Click);
            // 
            // P_Sub_caixa
            // 
            this.P_Sub_caixa.Controls.Add(this.Btn_sangria);
            this.P_Sub_caixa.Controls.Add(this.Btn_fechamento);
            this.P_Sub_caixa.Controls.Add(this.Btn_venda);
            this.P_Sub_caixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Sub_caixa.Location = new System.Drawing.Point(0, 156);
            this.P_Sub_caixa.Name = "P_Sub_caixa";
            this.P_Sub_caixa.Size = new System.Drawing.Size(245, 148);
            this.P_Sub_caixa.TabIndex = 2;
            // 
            // Btn_sangria
            // 
            this.Btn_sangria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_sangria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sangria.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_sangria.FlatAppearance.BorderSize = 0;
            this.Btn_sangria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_sangria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sangria.Location = new System.Drawing.Point(0, 92);
            this.Btn_sangria.Name = "Btn_sangria";
            this.Btn_sangria.Size = new System.Drawing.Size(245, 46);
            this.Btn_sangria.TabIndex = 4;
            this.Btn_sangria.Text = "Sangria";
            this.Btn_sangria.UseVisualStyleBackColor = false;
            this.Btn_sangria.Click += new System.EventHandler(this.Btn_sangria_Click);
            // 
            // Btn_fechamento
            // 
            this.Btn_fechamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_fechamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_fechamento.FlatAppearance.BorderSize = 0;
            this.Btn_fechamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_fechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechamento.Location = new System.Drawing.Point(0, 46);
            this.Btn_fechamento.Name = "Btn_fechamento";
            this.Btn_fechamento.Size = new System.Drawing.Size(245, 46);
            this.Btn_fechamento.TabIndex = 3;
            this.Btn_fechamento.Text = "Fechamento";
            this.Btn_fechamento.UseVisualStyleBackColor = false;
            this.Btn_fechamento.Click += new System.EventHandler(this.Btn_fechamento_Click);
            // 
            // Btn_venda
            // 
            this.Btn_venda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_venda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_venda.FlatAppearance.BorderSize = 0;
            this.Btn_venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_venda.Location = new System.Drawing.Point(0, 0);
            this.Btn_venda.Name = "Btn_venda";
            this.Btn_venda.Size = new System.Drawing.Size(245, 46);
            this.Btn_venda.TabIndex = 2;
            this.Btn_venda.Text = "Venda";
            this.Btn_venda.UseVisualStyleBackColor = false;
            this.Btn_venda.Click += new System.EventHandler(this.Btn_venda_Click);
            // 
            // Btn_caixa
            // 
            this.Btn_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_caixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_caixa.FlatAppearance.BorderSize = 0;
            this.Btn_caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_caixa.Location = new System.Drawing.Point(0, 110);
            this.Btn_caixa.Name = "Btn_caixa";
            this.Btn_caixa.Size = new System.Drawing.Size(245, 46);
            this.Btn_caixa.TabIndex = 1;
            this.Btn_caixa.Text = "Caixa";
            this.Btn_caixa.UseVisualStyleBackColor = true;
            this.Btn_caixa.Click += new System.EventHandler(this.Btn_caixa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 110);
            this.panel2.TabIndex = 0;
            // 
            // PanelForms
            // 
            this.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForms.Location = new System.Drawing.Point(245, 28);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(943, 651);
            this.PanelForms.TabIndex = 2;
            // 
            // Btn_cadastrar_prod
            // 
            this.Btn_cadastrar_prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_cadastrar_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cadastrar_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_cadastrar_prod.FlatAppearance.BorderSize = 0;
            this.Btn_cadastrar_prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_cadastrar_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cadastrar_prod.Location = new System.Drawing.Point(0, 92);
            this.Btn_cadastrar_prod.Name = "Btn_cadastrar_prod";
            this.Btn_cadastrar_prod.Size = new System.Drawing.Size(245, 46);
            this.Btn_cadastrar_prod.TabIndex = 7;
            this.Btn_cadastrar_prod.Text = "Cadastrar Produtos";
            this.Btn_cadastrar_prod.UseVisualStyleBackColor = false;
            this.Btn_cadastrar_prod.Click += new System.EventHandler(this.Btn_cadastrar_prod_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loja.Properties.Resources.Loja_Pagolinha_Logo_Branco_completo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_Exit.Location = new System.Drawing.Point(1154, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(31, 22);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Max_Min
            // 
            this.Btn_Max_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Max_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Max_Min.FlatAppearance.BorderSize = 0;
            this.Btn_Max_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Max_Min.Image = global::Loja.Properties.Resources.maximizar;
            this.Btn_Max_Min.Location = new System.Drawing.Point(1119, 3);
            this.Btn_Max_Min.Name = "Btn_Max_Min";
            this.Btn_Max_Min.Size = new System.Drawing.Size(29, 22);
            this.Btn_Max_Min.TabIndex = 2;
            this.Btn_Max_Min.UseVisualStyleBackColor = true;
            this.Btn_Max_Min.Click += new System.EventHandler(this.Btn_Max_Min_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_minimizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Image = global::Loja.Properties.Resources.botao_minimizar;
            this.Btn_minimizar.Location = new System.Drawing.Point(1084, 3);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(29, 22);
            this.Btn_minimizar.TabIndex = 3;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1188, 679);
            this.Controls.Add(this.PanelForms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tlp_mover);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagolinha";
            this.Tlp_mover.ResumeLayout(false);
            this.Tlp_mover.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.P_Sub_produtos.ResumeLayout(false);
            this.P_Sub_caixa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tlp_mover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Max_Min;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel P_Sub_produtos;
        private System.Windows.Forms.Button Btn_Produtos;
        private System.Windows.Forms.Panel P_Sub_caixa;
        private System.Windows.Forms.Button Btn_sangria;
        private System.Windows.Forms.Button Btn_fechamento;
        private System.Windows.Forms.Button Btn_venda;
        private System.Windows.Forms.Button Btn_caixa;
        private System.Windows.Forms.Button Btn_entrada;
        private System.Windows.Forms.Panel PanelForms;
        private System.Windows.Forms.Button Btn_categoria;
        private System.Windows.Forms.Button Btn_cadastrar_prod;
    }
}

