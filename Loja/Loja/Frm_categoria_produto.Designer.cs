
namespace Loja
{
    partial class Frm_categoria_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_fechar_form = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Txt_descricao = new System.Windows.Forms.TextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_fechar_form, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_fechar_form
            // 
            this.Btn_fechar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_fechar_form.FlatAppearance.BorderSize = 0;
            this.Btn_fechar_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_fechar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar_form.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_fechar_form.Location = new System.Drawing.Point(983, 3);
            this.Btn_fechar_form.Name = "Btn_fechar_form";
            this.Btn_fechar_form.Size = new System.Drawing.Size(30, 37);
            this.Btn_fechar_form.TabIndex = 2;
            this.Btn_fechar_form.UseVisualStyleBackColor = true;
            this.Btn_fechar_form.Click += new System.EventHandler(this.Btn_fechar_form_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria de Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_cadastrar);
            this.panel2.Controls.Add(this.Txt_descricao);
            this.panel2.Controls.Add(this.Txt_nome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 549);
            this.panel2.TabIndex = 2;
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.Btn_cadastrar.Location = new System.Drawing.Point(519, 352);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(170, 48);
            this.Btn_cadastrar.TabIndex = 4;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = true;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Txt_descricao
            // 
            this.Txt_descricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_descricao.Location = new System.Drawing.Point(335, 171);
            this.Txt_descricao.Multiline = true;
            this.Txt_descricao.Name = "Txt_descricao";
            this.Txt_descricao.Size = new System.Drawing.Size(354, 104);
            this.Txt_descricao.TabIndex = 3;
            // 
            // Txt_nome
            // 
            this.Txt_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_nome.Location = new System.Drawing.Point(335, 111);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(354, 31);
            this.Txt_nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da Categoria:";
            // 
            // Frm_categoria_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_categoria_produto";
            this.Text = "Frm_categoria_produto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fechar_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.TextBox Txt_descricao;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}