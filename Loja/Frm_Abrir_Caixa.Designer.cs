
namespace Loja
{
    partial class Frm_Abrir_Caixa
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
            this.Tbl_caixa = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_fechar_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_abrir_caixa = new System.Windows.Forms.Button();
            this.Lbl_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_valor_abertura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tbl_caixa.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbl_caixa
            // 
            this.Tbl_caixa.ColumnCount = 2;
            this.Tbl_caixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_caixa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.Tbl_caixa.Controls.Add(this.label1, 0, 0);
            this.Tbl_caixa.Controls.Add(this.Btn_fechar_form, 1, 0);
            this.Tbl_caixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tbl_caixa.Location = new System.Drawing.Point(0, 0);
            this.Tbl_caixa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Tbl_caixa.Name = "Tbl_caixa";
            this.Tbl_caixa.RowCount = 1;
            this.Tbl_caixa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tbl_caixa.Size = new System.Drawing.Size(652, 42);
            this.Tbl_caixa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abrir Caixa";
            // 
            // Btn_fechar_form
            // 
            this.Btn_fechar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_fechar_form.FlatAppearance.BorderSize = 0;
            this.Btn_fechar_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_fechar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar_form.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_fechar_form.Location = new System.Drawing.Point(611, 6);
            this.Btn_fechar_form.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_fechar_form.Name = "Btn_fechar_form";
            this.Btn_fechar_form.Size = new System.Drawing.Size(36, 30);
            this.Btn_fechar_form.TabIndex = 1;
            this.Btn_fechar_form.UseVisualStyleBackColor = true;
            this.Btn_fechar_form.Click += new System.EventHandler(this.Btn_fechar_form_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_abrir_caixa);
            this.panel1.Controls.Add(this.Lbl_data);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_valor_abertura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 288);
            this.panel1.TabIndex = 3;
            // 
            // Btn_abrir_caixa
            // 
            this.Btn_abrir_caixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_abrir_caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_abrir_caixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_abrir_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_abrir_caixa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_abrir_caixa.ForeColor = System.Drawing.Color.White;
            this.Btn_abrir_caixa.Location = new System.Drawing.Point(226, 147);
            this.Btn_abrir_caixa.Name = "Btn_abrir_caixa";
            this.Btn_abrir_caixa.Size = new System.Drawing.Size(157, 57);
            this.Btn_abrir_caixa.TabIndex = 36;
            this.Btn_abrir_caixa.Text = "Abertura";
            this.Btn_abrir_caixa.UseVisualStyleBackColor = true;
            this.Btn_abrir_caixa.Click += new System.EventHandler(this.Btn_abrir_caixa_Click);
            // 
            // Lbl_data
            // 
            this.Lbl_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_data.AutoSize = true;
            this.Lbl_data.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_data.ForeColor = System.Drawing.Color.White;
            this.Lbl_data.Location = new System.Drawing.Point(84, 22);
            this.Lbl_data.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_data.Name = "Lbl_data";
            this.Lbl_data.Size = new System.Drawing.Size(116, 23);
            this.Lbl_data.TabIndex = 10;
            this.Lbl_data.Text = "00/00/0000";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data:";
            // 
            // Txt_valor_abertura
            // 
            this.Txt_valor_abertura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_valor_abertura.Location = new System.Drawing.Point(222, 78);
            this.Txt_valor_abertura.Name = "Txt_valor_abertura";
            this.Txt_valor_abertura.Size = new System.Drawing.Size(161, 31);
            this.Txt_valor_abertura.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor para Abertura:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Abrir_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(652, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tbl_caixa);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Frm_Abrir_Caixa";
            this.Text = "Frm_Abrir_Caixa";
            this.Tbl_caixa.ResumeLayout(false);
            this.Tbl_caixa.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_caixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fechar_form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_valor_abertura;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_abrir_caixa;
    }
}