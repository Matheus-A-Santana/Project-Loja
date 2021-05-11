
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_fechar_form = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.Lbl_data_lancamento = new System.Windows.Forms.Label();
            this.Txt_troco = new System.Windows.Forms.TextBox();
            this.Cbo_pagamento = new System.Windows.Forms.ComboBox();
            this.Txt_valor_pago = new System.Windows.Forms.TextBox();
            this.Txt_desconto = new System.Windows.Forms.TextBox();
            this.Txt_total_pagar = new System.Windows.Forms.TextBox();
            this.Btn_finalizar_venda = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Adcionar = new System.Windows.Forms.Button();
            this.Btn_abrir_pesquisar = new System.Windows.Forms.Button();
            this.Txt_valor_produto = new System.Windows.Forms.TextBox();
            this.Txt_quantidade_compra = new System.Windows.Forms.TextBox();
            this.Txt_nome_produto = new System.Windows.Forms.TextBox();
            this.Txt_id_produto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Dgv_produtos_vendas = new System.Windows.Forms.DataGridView();
            this.Pic_imagem_produto = new Loja.PictureCircle();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_produtos_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem_produto)).BeginInit();
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
            this.panel1.Controls.Add(this.Dgv_produtos_vendas);
            this.panel1.Controls.Add(this.Lbl_total);
            this.panel1.Controls.Add(this.Lbl_hora);
            this.panel1.Controls.Add(this.Lbl_data_lancamento);
            this.panel1.Controls.Add(this.Txt_troco);
            this.panel1.Controls.Add(this.Cbo_pagamento);
            this.panel1.Controls.Add(this.Txt_valor_pago);
            this.panel1.Controls.Add(this.Txt_desconto);
            this.panel1.Controls.Add(this.Txt_total_pagar);
            this.panel1.Controls.Add(this.Btn_finalizar_venda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Btn_Adcionar);
            this.panel1.Controls.Add(this.Pic_imagem_produto);
            this.panel1.Controls.Add(this.Btn_abrir_pesquisar);
            this.panel1.Controls.Add(this.Txt_valor_produto);
            this.panel1.Controls.Add(this.Txt_quantidade_compra);
            this.panel1.Controls.Add(this.Txt_nome_produto);
            this.panel1.Controls.Add(this.Txt_id_produto);
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
            // Lbl_total
            // 
            this.Lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.ForeColor = System.Drawing.Color.White;
            this.Lbl_total.Location = new System.Drawing.Point(645, 152);
            this.Lbl_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(69, 23);
            this.Lbl_total.TabIndex = 43;
            this.Lbl_total.Text = "TOTAL:";
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
            // Txt_troco
            // 
            this.Txt_troco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_troco.Location = new System.Drawing.Point(649, 544);
            this.Txt_troco.Name = "Txt_troco";
            this.Txt_troco.Size = new System.Drawing.Size(140, 31);
            this.Txt_troco.TabIndex = 40;
            // 
            // Cbo_pagamento
            // 
            this.Cbo_pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cbo_pagamento.FormattingEnabled = true;
            this.Cbo_pagamento.Location = new System.Drawing.Point(946, 474);
            this.Cbo_pagamento.Name = "Cbo_pagamento";
            this.Cbo_pagamento.Size = new System.Drawing.Size(157, 30);
            this.Cbo_pagamento.TabIndex = 39;
            this.Cbo_pagamento.SelectedIndexChanged += new System.EventHandler(this.Cbo_pagamento_SelectedIndexChanged);
            // 
            // Txt_valor_pago
            // 
            this.Txt_valor_pago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_valor_pago.Location = new System.Drawing.Point(286, 544);
            this.Txt_valor_pago.Name = "Txt_valor_pago";
            this.Txt_valor_pago.Size = new System.Drawing.Size(157, 31);
            this.Txt_valor_pago.TabIndex = 38;
            this.Txt_valor_pago.TextChanged += new System.EventHandler(this.Txt_valor_pago_TextChanged);
            // 
            // Txt_desconto
            // 
            this.Txt_desconto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_desconto.Location = new System.Drawing.Point(564, 474);
            this.Txt_desconto.Name = "Txt_desconto";
            this.Txt_desconto.Size = new System.Drawing.Size(140, 31);
            this.Txt_desconto.TabIndex = 37;
            this.Txt_desconto.TextChanged += new System.EventHandler(this.Txt_desconto_TextChanged);
            // 
            // Txt_total_pagar
            // 
            this.Txt_total_pagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_total_pagar.Location = new System.Drawing.Point(286, 474);
            this.Txt_total_pagar.Name = "Txt_total_pagar";
            this.Txt_total_pagar.Size = new System.Drawing.Size(145, 31);
            this.Txt_total_pagar.TabIndex = 36;
            // 
            // Btn_finalizar_venda
            // 
            this.Btn_finalizar_venda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_finalizar_venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_finalizar_venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_finalizar_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_finalizar_venda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_finalizar_venda.ForeColor = System.Drawing.Color.White;
            this.Btn_finalizar_venda.Location = new System.Drawing.Point(876, 530);
            this.Btn_finalizar_venda.Name = "Btn_finalizar_venda";
            this.Btn_finalizar_venda.Size = new System.Drawing.Size(157, 57);
            this.Btn_finalizar_venda.TabIndex = 35;
            this.Btn_finalizar_venda.Text = "FINALIZAR";
            this.Btn_finalizar_venda.UseVisualStyleBackColor = true;
            this.Btn_finalizar_venda.Click += new System.EventHandler(this.Btn_finalizar_venda_Click);
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
            // Btn_Adcionar
            // 
            this.Btn_Adcionar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Adcionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Adcionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_Adcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Adcionar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Adcionar.ForeColor = System.Drawing.Color.White;
            this.Btn_Adcionar.Location = new System.Drawing.Point(759, 135);
            this.Btn_Adcionar.Name = "Btn_Adcionar";
            this.Btn_Adcionar.Size = new System.Drawing.Size(157, 57);
            this.Btn_Adcionar.TabIndex = 29;
            this.Btn_Adcionar.Text = "ADICIONAR";
            this.Btn_Adcionar.UseVisualStyleBackColor = true;
            this.Btn_Adcionar.Click += new System.EventHandler(this.Btn_Adcionar_Click);
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
            // Txt_valor_produto
            // 
            this.Txt_valor_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_valor_produto.Enabled = false;
            this.Txt_valor_produto.Location = new System.Drawing.Point(473, 149);
            this.Txt_valor_produto.Name = "Txt_valor_produto";
            this.Txt_valor_produto.Size = new System.Drawing.Size(129, 31);
            this.Txt_valor_produto.TabIndex = 10;
            // 
            // Txt_quantidade_compra
            // 
            this.Txt_quantidade_compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_quantidade_compra.Location = new System.Drawing.Point(262, 149);
            this.Txt_quantidade_compra.Name = "Txt_quantidade_compra";
            this.Txt_quantidade_compra.Size = new System.Drawing.Size(117, 31);
            this.Txt_quantidade_compra.TabIndex = 9;
            this.Txt_quantidade_compra.Click += new System.EventHandler(this.Txt_quantidade_compra_Click);
            this.Txt_quantidade_compra.TextChanged += new System.EventHandler(this.Txt_quantidade_compra_TextChanged);
            this.Txt_quantidade_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_quantidade_compra_KeyPress);
            // 
            // Txt_nome_produto
            // 
            this.Txt_nome_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_nome_produto.Enabled = false;
            this.Txt_nome_produto.Location = new System.Drawing.Point(262, 90);
            this.Txt_nome_produto.Name = "Txt_nome_produto";
            this.Txt_nome_produto.Size = new System.Drawing.Size(589, 31);
            this.Txt_nome_produto.TabIndex = 8;
            // 
            // Txt_id_produto
            // 
            this.Txt_id_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_id_produto.Location = new System.Drawing.Point(262, 39);
            this.Txt_id_produto.Name = "Txt_id_produto";
            this.Txt_id_produto.Size = new System.Drawing.Size(169, 31);
            this.Txt_id_produto.TabIndex = 7;
            this.Txt_id_produto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_id_produto_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(387, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "PREÇO:";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Dgv_produtos_vendas
            // 
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            this.Dgv_produtos_vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.Dgv_produtos_vendas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dgv_produtos_vendas.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgv_produtos_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_produtos_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv_produtos_vendas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dgv_produtos_vendas.Location = new System.Drawing.Point(123, 227);
            this.Dgv_produtos_vendas.Name = "Dgv_produtos_vendas";
            this.Dgv_produtos_vendas.Size = new System.Drawing.Size(980, 238);
            this.Dgv_produtos_vendas.TabIndex = 44;
            // 
            // Pic_imagem_produto
            // 
            this.Pic_imagem_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pic_imagem_produto.BackColor = System.Drawing.Color.Gray;
            this.Pic_imagem_produto.Enabled = false;
            this.Pic_imagem_produto.Location = new System.Drawing.Point(922, 41);
            this.Pic_imagem_produto.Name = "Pic_imagem_produto";
            this.Pic_imagem_produto.Size = new System.Drawing.Size(180, 180);
            this.Pic_imagem_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_imagem_produto.TabIndex = 27;
            this.Pic_imagem_produto.TabStop = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle38;
            this.Column1.HeaderText = "ID_PRODUTOS";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle39;
            this.Column2.HeaderText = "PRODUTO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 430;
            // 
            // Column3
            // 
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle40;
            this.Column3.HeaderText = "QUANTIDADE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle41;
            this.Column4.HeaderText = "PREÇO";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle42;
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
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
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_produtos_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem_produto)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_valor_produto;
        private System.Windows.Forms.TextBox Txt_quantidade_compra;
        private System.Windows.Forms.TextBox Txt_nome_produto;
        private System.Windows.Forms.TextBox Txt_id_produto;
        private System.Windows.Forms.Button Btn_abrir_pesquisar;
        private System.Windows.Forms.Button Btn_Adcionar;
        private PictureCircle Pic_imagem_produto;
        private System.Windows.Forms.TextBox Txt_troco;
        private System.Windows.Forms.ComboBox Cbo_pagamento;
        private System.Windows.Forms.TextBox Txt_valor_pago;
        private System.Windows.Forms.TextBox Txt_desconto;
        private System.Windows.Forms.TextBox Txt_total_pagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_data_lancamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Button Btn_finalizar_venda;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.DataGridView Dgv_produtos_vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}