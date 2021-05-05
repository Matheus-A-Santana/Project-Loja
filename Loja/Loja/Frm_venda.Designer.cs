
namespace Loja
{
    partial class Frm_venda
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_fechar_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Btn_abrir_pesquisar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Cbo_pagamento = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Lbl_data_lancamento = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.pictureCircle1 = new Loja.PictureCircle();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCircle1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_fechar_form, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1245, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas";
            // 
            // Btn_fechar_form
            // 
            this.Btn_fechar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_fechar_form.FlatAppearance.BorderSize = 0;
            this.Btn_fechar_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_fechar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar_form.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_fechar_form.Location = new System.Drawing.Point(1204, 6);
            this.Btn_fechar_form.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_fechar_form.Name = "Btn_fechar_form";
            this.Btn_fechar_form.Size = new System.Drawing.Size(36, 30);
            this.Btn_fechar_form.TabIndex = 1;
            this.Btn_fechar_form.UseVisualStyleBackColor = true;
            this.Btn_fechar_form.Click += new System.EventHandler(this.Btn_fechar_form_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lbl_hora);
            this.panel1.Controls.Add(this.Lbl_data_lancamento);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.Cbo_pagamento);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.pictureCircle1);
            this.panel1.Controls.Add(this.Btn_abrir_pesquisar);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 658);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID PRODUTO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(182, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOME:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTIDADE:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "PREÇO:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(262, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 31);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(262, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(589, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(262, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 31);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.Location = new System.Drawing.Point(521, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 31);
            this.textBox4.TabIndex = 10;
            // 
            // Btn_abrir_pesquisar
            // 
            this.Btn_abrir_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_abrir_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_abrir_pesquisar.FlatAppearance.BorderSize = 0;
            this.Btn_abrir_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_abrir_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abrir_pesquisar.ForeColor = System.Drawing.Color.White;
            this.Btn_abrir_pesquisar.Image = global::Loja.Properties.Resources.simbolo_de_interface_de_foto_de_pesquisa_com_ferramenta_de_lupa;
            this.Btn_abrir_pesquisar.Location = new System.Drawing.Point(439, 39);
            this.Btn_abrir_pesquisar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_abrir_pesquisar.Name = "Btn_abrir_pesquisar";
            this.Btn_abrir_pesquisar.Size = new System.Drawing.Size(35, 31);
            this.Btn_abrir_pesquisar.TabIndex = 26;
            this.Btn_abrir_pesquisar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(123, 227);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(980, 228);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(694, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 57);
            this.button1.TabIndex = 29;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 476);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "TOTAL À PAGAR:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(439, 476);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "DESCONTO:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(147, 546);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "TOTAL PAGO:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(712, 478);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "FORMA DE PAGAMENTO:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(560, 546);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "TROCO:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(876, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 57);
            this.button2.TabIndex = 35;
            this.button2.Text = "FINALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.Location = new System.Drawing.Point(286, 474);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 31);
            this.textBox5.TabIndex = 36;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.Location = new System.Drawing.Point(564, 474);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 31);
            this.textBox6.TabIndex = 37;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.Location = new System.Drawing.Point(286, 544);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(157, 31);
            this.textBox7.TabIndex = 38;
            // 
            // Cbo_pagamento
            // 
            this.Cbo_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cbo_pagamento.FormattingEnabled = true;
            this.Cbo_pagamento.Location = new System.Drawing.Point(946, 474);
            this.Cbo_pagamento.Name = "Cbo_pagamento";
            this.Cbo_pagamento.Size = new System.Drawing.Size(157, 30);
            this.Cbo_pagamento.TabIndex = 39;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox8.Location = new System.Drawing.Point(649, 544);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(140, 31);
            this.textBox8.TabIndex = 40;
            // 
            // Lbl_data_lancamento
            // 
            this.Lbl_data_lancamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_data_lancamento.AutoSize = true;
            this.Lbl_data_lancamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_data_lancamento.ForeColor = System.Drawing.Color.White;
            this.Lbl_data_lancamento.Location = new System.Drawing.Point(883, 15);
            this.Lbl_data_lancamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_data_lancamento.Name = "Lbl_data_lancamento";
            this.Lbl_data_lancamento.Size = new System.Drawing.Size(114, 23);
            this.Lbl_data_lancamento.TabIndex = 41;
            this.Lbl_data_lancamento.Text = "00-00-0000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.ForeColor = System.Drawing.Color.White;
            this.Lbl_hora.Location = new System.Drawing.Point(1007, 15);
            this.Lbl_hora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.Size = new System.Drawing.Size(86, 23);
            this.Lbl_hora.TabIndex = 42;
            this.Lbl_hora.Text = "00:00:00";
            // 
            // pictureCircle1
            // 
            this.pictureCircle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureCircle1.BackColor = System.Drawing.Color.Gray;
            this.pictureCircle1.Location = new System.Drawing.Point(922, 41);
            this.pictureCircle1.Name = "pictureCircle1";
            this.pictureCircle1.Size = new System.Drawing.Size(180, 180);
            this.pictureCircle1.TabIndex = 27;
            this.pictureCircle1.TabStop = false;
            // 
            // Frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1245, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_venda";
            this.Text = "Frm_venda";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCircle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fechar_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_abrir_pesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private PictureCircle pictureCircle1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox Cbo_pagamento;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_data_lancamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_hora;
    }
}