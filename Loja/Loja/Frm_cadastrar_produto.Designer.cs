
namespace Loja
{
    partial class Frm_cadastrar_produto
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
            this.Btn_foto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_preco_venda = new System.Windows.Forms.TextBox();
            this.Txt_porcentagem = new System.Windows.Forms.TextBox();
            this.Txt_preco_custo = new System.Windows.Forms.TextBox();
            this.Txt_descricao = new System.Windows.Forms.TextBox();
            this.Txt_quantidade = new System.Windows.Forms.TextBox();
            this.Cbo_categoria = new System.Windows.Forms.ComboBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_foto = new Loja.PictureCircle();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_fechar_form, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 38);
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
            this.Btn_fechar_form.Location = new System.Drawing.Point(1078, 5);
            this.Btn_fechar_form.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_fechar_form.Name = "Btn_fechar_form";
            this.Btn_fechar_form.Size = new System.Drawing.Size(24, 28);
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
            this.label1.Location = new System.Drawing.Point(381, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produtos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_cadastrar);
            this.panel2.Controls.Add(this.Btn_foto);
            this.panel2.Controls.Add(this.Pic_foto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Txt_preco_venda);
            this.panel2.Controls.Add(this.Txt_porcentagem);
            this.panel2.Controls.Add(this.Txt_preco_custo);
            this.panel2.Controls.Add(this.Txt_descricao);
            this.panel2.Controls.Add(this.Txt_quantidade);
            this.panel2.Controls.Add(this.Cbo_categoria);
            this.panel2.Controls.Add(this.Txt_nome);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 562);
            this.panel2.TabIndex = 2;
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cadastrar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.Btn_cadastrar.Location = new System.Drawing.Point(782, 479);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(180, 51);
            this.Btn_cadastrar.TabIndex = 16;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = true;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_foto
            // 
            this.Btn_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_foto.ForeColor = System.Drawing.Color.White;
            this.Btn_foto.Location = new System.Drawing.Point(681, 125);
            this.Btn_foto.Name = "Btn_foto";
            this.Btn_foto.Size = new System.Drawing.Size(115, 31);
            this.Btn_foto.TabIndex = 15;
            this.Btn_foto.Text = "Inserir foto";
            this.Btn_foto.UseVisualStyleBackColor = true;
            this.Btn_foto.Click += new System.EventHandler(this.Btn_foto_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(687, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Porcentagem:";
            // 
            // Txt_preco_venda
            // 
            this.Txt_preco_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_preco_venda.Enabled = false;
            this.Txt_preco_venda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_preco_venda.Location = new System.Drawing.Point(834, 407);
            this.Txt_preco_venda.Name = "Txt_preco_venda";
            this.Txt_preco_venda.Size = new System.Drawing.Size(128, 31);
            this.Txt_preco_venda.TabIndex = 12;
            this.Txt_preco_venda.TextChanged += new System.EventHandler(this.Txt_preco_venda_TextChanged);
            // 
            // Txt_porcentagem
            // 
            this.Txt_porcentagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_porcentagem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_porcentagem.Location = new System.Drawing.Point(834, 331);
            this.Txt_porcentagem.Name = "Txt_porcentagem";
            this.Txt_porcentagem.Size = new System.Drawing.Size(128, 31);
            this.Txt_porcentagem.TabIndex = 11;
            this.Txt_porcentagem.TextChanged += new System.EventHandler(this.Txt_porcentagem_TextChanged);
            // 
            // Txt_preco_custo
            // 
            this.Txt_preco_custo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_preco_custo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_preco_custo.Location = new System.Drawing.Point(322, 331);
            this.Txt_preco_custo.Name = "Txt_preco_custo";
            this.Txt_preco_custo.Size = new System.Drawing.Size(133, 31);
            this.Txt_preco_custo.TabIndex = 10;
            this.Txt_preco_custo.TextChanged += new System.EventHandler(this.Txt_preco_custo_TextChanged);
            // 
            // Txt_descricao
            // 
            this.Txt_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_descricao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descricao.Location = new System.Drawing.Point(322, 228);
            this.Txt_descricao.Multiline = true;
            this.Txt_descricao.Name = "Txt_descricao";
            this.Txt_descricao.Size = new System.Drawing.Size(640, 88);
            this.Txt_descricao.TabIndex = 9;
            // 
            // Txt_quantidade
            // 
            this.Txt_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_quantidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_quantidade.Location = new System.Drawing.Point(322, 179);
            this.Txt_quantidade.Name = "Txt_quantidade";
            this.Txt_quantidade.Size = new System.Drawing.Size(327, 31);
            this.Txt_quantidade.TabIndex = 8;
            // 
            // Cbo_categoria
            // 
            this.Cbo_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbo_categoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_categoria.FormattingEnabled = true;
            this.Cbo_categoria.Location = new System.Drawing.Point(322, 131);
            this.Cbo_categoria.Name = "Cbo_categoria";
            this.Cbo_categoria.Size = new System.Drawing.Size(193, 30);
            this.Cbo_categoria.TabIndex = 7;
            this.Cbo_categoria.SelectedIndexChanged += new System.EventHandler(this.Cbo_categoria_SelectedIndexChanged);
            // 
            // Txt_nome
            // 
            this.Txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nome.Location = new System.Drawing.Point(321, 82);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(327, 31);
            this.Txt_nome.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(650, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Preço de Venda: *";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(148, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Preço de Custo: *";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(188, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selecionar Categoria: *";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome: *";
            // 
            // Pic_foto
            // 
            this.Pic_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pic_foto.BackColor = System.Drawing.Color.DimGray;
            this.Pic_foto.Location = new System.Drawing.Point(802, 62);
            this.Pic_foto.Name = "Pic_foto";
            this.Pic_foto.Size = new System.Drawing.Size(160, 160);
            this.Pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_foto.TabIndex = 14;
            this.Pic_foto.TabStop = false;
            // 
            // Frm_cadastrar_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1107, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_cadastrar_produto";
            this.Text = "Frm_cadastrar_produto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fechar_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_foto;
        private PictureCircle Pic_foto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_preco_venda;
        private System.Windows.Forms.TextBox Txt_porcentagem;
        private System.Windows.Forms.TextBox Txt_preco_custo;
        private System.Windows.Forms.TextBox Txt_descricao;
        private System.Windows.Forms.TextBox Txt_quantidade;
        private System.Windows.Forms.ComboBox Cbo_categoria;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Button Btn_cadastrar;
    }
}