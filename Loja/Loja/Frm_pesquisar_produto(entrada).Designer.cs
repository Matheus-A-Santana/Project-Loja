
namespace Loja
{
    partial class Frm_pesquisar_produto_entrada_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar_pesquisar = new System.Windows.Forms.Button();
            this.Cbo_categoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Procurar_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.Btn_fechar_pesquisar);
            this.panel1.Controls.Add(this.Cbo_categoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_Procurar_produto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 53);
            this.panel1.TabIndex = 0;
            // 
            // Btn_fechar_pesquisar
            // 
            this.Btn_fechar_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar_pesquisar.FlatAppearance.BorderSize = 0;
            this.Btn_fechar_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_fechar_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar_pesquisar.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_fechar_pesquisar.Location = new System.Drawing.Point(986, 0);
            this.Btn_fechar_pesquisar.Name = "Btn_fechar_pesquisar";
            this.Btn_fechar_pesquisar.Size = new System.Drawing.Size(45, 53);
            this.Btn_fechar_pesquisar.TabIndex = 4;
            this.Btn_fechar_pesquisar.UseVisualStyleBackColor = true;
            this.Btn_fechar_pesquisar.Click += new System.EventHandler(this.Btn_fechar_pesquisar_Click);
            // 
            // Cbo_categoria
            // 
            this.Cbo_categoria.FormattingEnabled = true;
            this.Cbo_categoria.Location = new System.Drawing.Point(603, 9);
            this.Cbo_categoria.Name = "Cbo_categoria";
            this.Cbo_categoria.Size = new System.Drawing.Size(229, 30);
            this.Cbo_categoria.TabIndex = 3;
            this.Cbo_categoria.TextChanged += new System.EventHandler(this.Cbo_categoria_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // Txt_Procurar_produto
            // 
            this.Txt_Procurar_produto.Location = new System.Drawing.Point(88, 9);
            this.Txt_Procurar_produto.Name = "Txt_Procurar_produto";
            this.Txt_Procurar_produto.Size = new System.Drawing.Size(349, 31);
            this.Txt_Procurar_produto.TabIndex = 1;
            this.Txt_Procurar_produto.TextChanged += new System.EventHandler(this.Txt_Procurar_produto_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 278);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Frm_pesquisar_produto_entrada_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1031, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_pesquisar_produto_entrada_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pesquisar_produto_entrada_";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Procurar_produto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_fechar_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}