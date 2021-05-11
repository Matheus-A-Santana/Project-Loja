
namespace Loja
{
    partial class Frm_entrada_produto
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_data_lancamento = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_lancar_entrada = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Txt_novo_estoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_abrir_pesquisar = new System.Windows.Forms.Button();
            this.Txt_vlr_total_nota = new System.Windows.Forms.TextBox();
            this.Txt_venda_produto = new System.Windows.Forms.TextBox();
            this.Txt_Porc_venda = new System.Windows.Forms.TextBox();
            this.Txt_custo_produto = new System.Windows.Forms.TextBox();
            this.Txt_qtd_compra = new System.Windows.Forms.TextBox();
            this.Txt_qtd_estoque = new System.Windows.Forms.TextBox();
            this.Txt_descricao_produto = new System.Windows.Forms.TextBox();
            this.Cbo_categoria_produto = new System.Windows.Forms.ComboBox();
            this.Txt_nome_produto = new System.Windows.Forms.TextBox();
            this.pictureCircle1 = new Loja.PictureCircle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada de Produtos";
            // 
            // Btn_fechar_form
            // 
            this.Btn_fechar_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_fechar_form.FlatAppearance.BorderSize = 0;
            this.Btn_fechar_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_fechar_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar_form.Image = global::Loja.Properties.Resources.excluir_cruz;
            this.Btn_fechar_form.Location = new System.Drawing.Point(1183, 6);
            this.Btn_fechar_form.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_fechar_form.Name = "Btn_fechar_form";
            this.Btn_fechar_form.Size = new System.Drawing.Size(36, 30);
            this.Btn_fechar_form.TabIndex = 1;
            this.Btn_fechar_form.UseVisualStyleBackColor = true;
            this.Btn_fechar_form.Click += new System.EventHandler(this.Btn_fechar_form_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 1);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(290, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(258, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(225, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estoque Atual:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço de Custo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(201, 462);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preço de Venda:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(125, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantidade da Compra:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 2);
            this.panel2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(683, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Valor Total:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(558, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Porcentagem de Venda:";
            // 
            // Lbl_data_lancamento
            // 
            this.Lbl_data_lancamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_data_lancamento.AutoSize = true;
            this.Lbl_data_lancamento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_data_lancamento.ForeColor = System.Drawing.Color.White;
            this.Lbl_data_lancamento.Location = new System.Drawing.Point(814, 23);
            this.Lbl_data_lancamento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_data_lancamento.Name = "Lbl_data_lancamento";
            this.Lbl_data_lancamento.Size = new System.Drawing.Size(168, 23);
            this.Lbl_data_lancamento.TabIndex = 12;
            this.Lbl_data_lancamento.Text = "Data da Entrada:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(256, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Categoria:";
            // 
            // Btn_lancar_entrada
            // 
            this.Btn_lancar_entrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_lancar_entrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_lancar_entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(103)))), ((int)(((byte)(32)))));
            this.Btn_lancar_entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_lancar_entrada.ForeColor = System.Drawing.Color.White;
            this.Btn_lancar_entrada.Location = new System.Drawing.Point(807, 530);
            this.Btn_lancar_entrada.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_lancar_entrada.Name = "Btn_lancar_entrada";
            this.Btn_lancar_entrada.Size = new System.Drawing.Size(185, 64);
            this.Btn_lancar_entrada.TabIndex = 14;
            this.Btn_lancar_entrada.Text = "Lançar Entrada";
            this.Btn_lancar_entrada.UseVisualStyleBackColor = true;
            this.Btn_lancar_entrada.Click += new System.EventHandler(this.Btn_lancar_entrada_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Lbl_id);
            this.panel3.Controls.Add(this.Txt_novo_estoque);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Btn_abrir_pesquisar);
            this.panel3.Controls.Add(this.Txt_vlr_total_nota);
            this.panel3.Controls.Add(this.Txt_venda_produto);
            this.panel3.Controls.Add(this.Txt_Porc_venda);
            this.panel3.Controls.Add(this.Txt_custo_produto);
            this.panel3.Controls.Add(this.Txt_qtd_compra);
            this.panel3.Controls.Add(this.Txt_qtd_estoque);
            this.panel3.Controls.Add(this.Txt_descricao_produto);
            this.panel3.Controls.Add(this.Cbo_categoria_produto);
            this.panel3.Controls.Add(this.Txt_nome_produto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Lbl_data_lancamento);
            this.panel3.Controls.Add(this.Btn_lancar_entrada);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pictureCircle1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1224, 638);
            this.panel3.TabIndex = 15;
            // 
            // Lbl_id
            // 
            this.Lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id.ForeColor = System.Drawing.Color.Black;
            this.Lbl_id.Location = new System.Drawing.Point(370, 23);
            this.Lbl_id.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(33, 23);
            this.Lbl_id.TabIndex = 28;
            this.Lbl_id.Text = "Id:";
            // 
            // Txt_novo_estoque
            // 
            this.Txt_novo_estoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_novo_estoque.Enabled = false;
            this.Txt_novo_estoque.Location = new System.Drawing.Point(804, 315);
            this.Txt_novo_estoque.Name = "Txt_novo_estoque";
            this.Txt_novo_estoque.Size = new System.Drawing.Size(184, 31);
            this.Txt_novo_estoque.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(655, 317);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Novo Estoque:";
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
            this.Btn_abrir_pesquisar.Location = new System.Drawing.Point(760, 51);
            this.Btn_abrir_pesquisar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_abrir_pesquisar.Name = "Btn_abrir_pesquisar";
            this.Btn_abrir_pesquisar.Size = new System.Drawing.Size(36, 31);
            this.Btn_abrir_pesquisar.TabIndex = 25;
            this.Btn_abrir_pesquisar.UseVisualStyleBackColor = true;
            this.Btn_abrir_pesquisar.Click += new System.EventHandler(this.Btn_abrir_pesquisar_Click);
            // 
            // Txt_vlr_total_nota
            // 
            this.Txt_vlr_total_nota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_vlr_total_nota.Location = new System.Drawing.Point(804, 460);
            this.Txt_vlr_total_nota.Name = "Txt_vlr_total_nota";
            this.Txt_vlr_total_nota.Size = new System.Drawing.Size(188, 31);
            this.Txt_vlr_total_nota.TabIndex = 23;
            // 
            // Txt_venda_produto
            // 
            this.Txt_venda_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_venda_produto.Location = new System.Drawing.Point(374, 460);
            this.Txt_venda_produto.Name = "Txt_venda_produto";
            this.Txt_venda_produto.Size = new System.Drawing.Size(184, 31);
            this.Txt_venda_produto.TabIndex = 22;
            this.Txt_venda_produto.TextChanged += new System.EventHandler(this.Txt_venda_produto_TextChanged);
            // 
            // Txt_Porc_venda
            // 
            this.Txt_Porc_venda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Porc_venda.Location = new System.Drawing.Point(804, 386);
            this.Txt_Porc_venda.Name = "Txt_Porc_venda";
            this.Txt_Porc_venda.Size = new System.Drawing.Size(188, 31);
            this.Txt_Porc_venda.TabIndex = 21;
            this.Txt_Porc_venda.TextChanged += new System.EventHandler(this.Txt_Porc_venda_TextChanged);
            // 
            // Txt_custo_produto
            // 
            this.Txt_custo_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_custo_produto.Location = new System.Drawing.Point(374, 386);
            this.Txt_custo_produto.Name = "Txt_custo_produto";
            this.Txt_custo_produto.Size = new System.Drawing.Size(184, 31);
            this.Txt_custo_produto.TabIndex = 20;
            this.Txt_custo_produto.TextChanged += new System.EventHandler(this.Txt_custo_produto_TextChanged);
            // 
            // Txt_qtd_compra
            // 
            this.Txt_qtd_compra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_qtd_compra.Location = new System.Drawing.Point(374, 315);
            this.Txt_qtd_compra.Name = "Txt_qtd_compra";
            this.Txt_qtd_compra.Size = new System.Drawing.Size(184, 31);
            this.Txt_qtd_compra.TabIndex = 19;
            this.Txt_qtd_compra.TextChanged += new System.EventHandler(this.Txt_qtd_compra_TextChanged);
            // 
            // Txt_qtd_estoque
            // 
            this.Txt_qtd_estoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_qtd_estoque.Enabled = false;
            this.Txt_qtd_estoque.Location = new System.Drawing.Point(374, 243);
            this.Txt_qtd_estoque.Name = "Txt_qtd_estoque";
            this.Txt_qtd_estoque.Size = new System.Drawing.Size(73, 31);
            this.Txt_qtd_estoque.TabIndex = 18;
            // 
            // Txt_descricao_produto
            // 
            this.Txt_descricao_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_descricao_produto.Enabled = false;
            this.Txt_descricao_produto.Location = new System.Drawing.Point(374, 143);
            this.Txt_descricao_produto.Multiline = true;
            this.Txt_descricao_produto.Name = "Txt_descricao_produto";
            this.Txt_descricao_produto.Size = new System.Drawing.Size(422, 92);
            this.Txt_descricao_produto.TabIndex = 17;
            // 
            // Cbo_categoria_produto
            // 
            this.Cbo_categoria_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cbo_categoria_produto.Enabled = false;
            this.Cbo_categoria_produto.FormattingEnabled = true;
            this.Cbo_categoria_produto.Location = new System.Drawing.Point(374, 95);
            this.Cbo_categoria_produto.Name = "Cbo_categoria_produto";
            this.Cbo_categoria_produto.Size = new System.Drawing.Size(231, 30);
            this.Cbo_categoria_produto.TabIndex = 16;
            // 
            // Txt_nome_produto
            // 
            this.Txt_nome_produto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_nome_produto.Enabled = false;
            this.Txt_nome_produto.Location = new System.Drawing.Point(374, 51);
            this.Txt_nome_produto.Name = "Txt_nome_produto";
            this.Txt_nome_produto.Size = new System.Drawing.Size(378, 31);
            this.Txt_nome_produto.TabIndex = 15;
            this.Txt_nome_produto.TextChanged += new System.EventHandler(this.Txt_nome_produto_TextChanged);
            // 
            // pictureCircle1
            // 
            this.pictureCircle1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureCircle1.BackColor = System.Drawing.Color.Gray;
            this.pictureCircle1.Location = new System.Drawing.Point(807, 84);
            this.pictureCircle1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureCircle1.Name = "pictureCircle1";
            this.pictureCircle1.Size = new System.Drawing.Size(185, 173);
            this.pictureCircle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCircle1.TabIndex = 4;
            this.pictureCircle1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_entrada_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Frm_entrada_produto";
            this.Text = "Frm_entrada_produto";
            this.Load += new System.EventHandler(this.Frm_entrada_produto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCircle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_fechar_form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_data_lancamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_lancar_entrada;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txt_vlr_total_nota;
        private System.Windows.Forms.TextBox Txt_Porc_venda;
        private System.Windows.Forms.TextBox Txt_qtd_compra;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_abrir_pesquisar;
        public System.Windows.Forms.TextBox Txt_nome_produto;
        public System.Windows.Forms.ComboBox Cbo_categoria_produto;
        public System.Windows.Forms.TextBox Txt_descricao_produto;
        public System.Windows.Forms.TextBox Txt_qtd_estoque;
        public System.Windows.Forms.TextBox Txt_custo_produto;
        public System.Windows.Forms.TextBox Txt_venda_produto;
        internal PictureCircle pictureCircle1;
        private System.Windows.Forms.TextBox Txt_novo_estoque;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Lbl_id;
    }
}