﻿namespace SysVenda_OBSEQUION {
	partial class TelaVenda {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVenda));
			DGV_ListaPedido = new DataGridView();
			Txt_IdVenda = new Label();
			Txt_Produto = new Label();
			ListaPedido = new Label();
			Txt_Cliente = new Label();
			Txt_VendaID = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			Txt_TotalGeral = new Label();
			Btn_Limpa = new Button();
			Btn_Registra = new Button();
			Txt_Estoque = new Label();
			Txt_Preco = new Label();
			Txt_Pagar = new Label();
			Txt_Pedido = new Label();
			Txt_Unidade = new Label();
			Txt_Total = new Label();
			Txt_Troco = new Label();
			ProdutoID = new TextBox();
			Txt_QTD = new Label();
			textBox4 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			Txt_label = new Label();
			Txt_ETQ = new Label();
			Btn_OK = new Button();
			label6 = new Label();
			textBox5 = new TextBox();
			((System.ComponentModel.ISupportInitialize)DGV_ListaPedido).BeginInit();
			SuspendLayout();
			// 
			// DGV_ListaPedido
			// 
			DGV_ListaPedido.AllowUserToOrderColumns = true;
			DGV_ListaPedido.BackgroundColor = SystemColors.Info;
			DGV_ListaPedido.BorderStyle = BorderStyle.Fixed3D;
			DGV_ListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_ListaPedido.Location = new Point(12, 305);
			DGV_ListaPedido.Name = "DGV_ListaPedido";
			DGV_ListaPedido.Size = new Size(520, 133);
			DGV_ListaPedido.TabIndex = 0;
			// 
			// Txt_IdVenda
			// 
			Txt_IdVenda.AutoSize = true;
			Txt_IdVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_IdVenda.Location = new Point(31, 16);
			Txt_IdVenda.Name = "Txt_IdVenda";
			Txt_IdVenda.Size = new Size(20, 17);
			Txt_IdVenda.TabIndex = 1;
			Txt_IdVenda.Text = "ID";
			// 
			// Txt_Produto
			// 
			Txt_Produto.AutoSize = true;
			Txt_Produto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Produto.Location = new Point(12, 70);
			Txt_Produto.Name = "Txt_Produto";
			Txt_Produto.Size = new Size(71, 17);
			Txt_Produto.TabIndex = 2;
			Txt_Produto.Text = "Produto ID";
			// 
			// ListaPedido
			// 
			ListaPedido.AutoSize = true;
			ListaPedido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			ListaPedido.Location = new Point(12, 287);
			ListaPedido.Name = "ListaPedido";
			ListaPedido.Size = new Size(87, 15);
			ListaPedido.TabIndex = 4;
			ListaPedido.Text = "Lista de Pedido";
			// 
			// Txt_Cliente
			// 
			Txt_Cliente.AutoSize = true;
			Txt_Cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Cliente.Location = new Point(215, 15);
			Txt_Cliente.Name = "Txt_Cliente";
			Txt_Cliente.Size = new Size(47, 17);
			Txt_Cliente.TabIndex = 3;
			Txt_Cliente.Text = "Cliente";
			// 
			// Txt_VendaID
			// 
			Txt_VendaID.BackColor = SystemColors.GradientInactiveCaption;
			Txt_VendaID.BorderStyle = BorderStyle.FixedSingle;
			Txt_VendaID.Font = new Font("Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 2);
			Txt_VendaID.ForeColor = SystemColors.InactiveCaptionText;
			Txt_VendaID.ImeMode = ImeMode.NoControl;
			Txt_VendaID.Location = new Point(89, 18);
			Txt_VendaID.Name = "Txt_VendaID";
			Txt_VendaID.Size = new Size(81, 22);
			Txt_VendaID.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.GradientInactiveCaption;
			textBox2.BorderStyle = BorderStyle.FixedSingle;
			textBox2.Location = new Point(89, 64);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(193, 23);
			textBox2.TabIndex = 6;
			textBox2.KeyPress += Txt_ID;
			// 
			// textBox3
			// 
			textBox3.BackColor = SystemColors.GradientInactiveCaption;
			textBox3.BorderStyle = BorderStyle.FixedSingle;
			textBox3.Location = new Point(479, 12);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(309, 23);
			textBox3.TabIndex = 7;
			// 
			// Txt_TotalGeral
			// 
			Txt_TotalGeral.AutoSize = true;
			Txt_TotalGeral.BackColor = SystemColors.ActiveCaption;
			Txt_TotalGeral.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_TotalGeral.ForeColor = SystemColors.ControlText;
			Txt_TotalGeral.Location = new Point(599, 287);
			Txt_TotalGeral.Name = "Txt_TotalGeral";
			Txt_TotalGeral.Size = new Size(102, 20);
			Txt_TotalGeral.TabIndex = 8;
			Txt_TotalGeral.Text = "Total Geral R$";
			Txt_TotalGeral.Click += Txt_TotalGeral_Click;
			// 
			// Btn_Limpa
			// 
			Btn_Limpa.BackColor = SystemColors.GradientInactiveCaption;
			Btn_Limpa.Location = new Point(599, 415);
			Btn_Limpa.Name = "Btn_Limpa";
			Btn_Limpa.Size = new Size(91, 23);
			Btn_Limpa.TabIndex = 10;
			Btn_Limpa.Text = "Limpa";
			Btn_Limpa.UseVisualStyleBackColor = false;
			// 
			// Btn_Registra
			// 
			Btn_Registra.BackColor = SystemColors.GradientInactiveCaption;
			Btn_Registra.Location = new Point(705, 415);
			Btn_Registra.Name = "Btn_Registra";
			Btn_Registra.Size = new Size(83, 23);
			Btn_Registra.TabIndex = 11;
			Btn_Registra.Text = "Registrar";
			Btn_Registra.UseVisualStyleBackColor = false;
			// 
			// Txt_Estoque
			// 
			Txt_Estoque.AutoSize = true;
			Txt_Estoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Estoque.Location = new Point(556, 70);
			Txt_Estoque.Name = "Txt_Estoque";
			Txt_Estoque.Size = new Size(84, 17);
			Txt_Estoque.TabIndex = 12;
			Txt_Estoque.Text = "QDT Estoque";
			// 
			// Txt_Preco
			// 
			Txt_Preco.AutoSize = true;
			Txt_Preco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Preco.Location = new Point(439, 70);
			Txt_Preco.Name = "Txt_Preco";
			Txt_Preco.Size = new Size(60, 17);
			Txt_Preco.TabIndex = 12;
			Txt_Preco.Text = "Preço R$";
			// 
			// Txt_Pagar
			// 
			Txt_Pagar.AutoSize = true;
			Txt_Pagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Pagar.Location = new Point(599, 332);
			Txt_Pagar.Name = "Txt_Pagar";
			Txt_Pagar.Size = new Size(67, 20);
			Txt_Pagar.TabIndex = 12;
			Txt_Pagar.Text = "Pagar R$";
			// 
			// Txt_Pedido
			// 
			Txt_Pedido.AutoSize = true;
			Txt_Pedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Pedido.Location = new Point(12, 139);
			Txt_Pedido.Name = "Txt_Pedido";
			Txt_Pedido.Size = new Size(49, 17);
			Txt_Pedido.TabIndex = 12;
			Txt_Pedido.Text = "Pedido";
			// 
			// Txt_Unidade
			// 
			Txt_Unidade.AutoSize = true;
			Txt_Unidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Unidade.Location = new Point(335, 70);
			Txt_Unidade.Name = "Txt_Unidade";
			Txt_Unidade.Size = new Size(57, 17);
			Txt_Unidade.TabIndex = 14;
			Txt_Unidade.Text = "Unidade";
			// 
			// Txt_Total
			// 
			Txt_Total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Total.Location = new Point(58, 191);
			Txt_Total.Name = "Txt_Total";
			Txt_Total.Size = new Size(67, 24);
			Txt_Total.TabIndex = 8;
			Txt_Total.Text = "Total R$";
			Txt_Total.Click += Txt_Total_Click;
			// 
			// Txt_Troco
			// 
			Txt_Troco.AutoSize = true;
			Txt_Troco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Troco.Location = new Point(599, 377);
			Txt_Troco.Name = "Txt_Troco";
			Txt_Troco.Size = new Size(67, 20);
			Txt_Troco.TabIndex = 8;
			Txt_Troco.Text = "Troco R$";
			// 
			// ProdutoID
			// 
			ProdutoID.BackColor = SystemColors.GradientInactiveCaption;
			ProdutoID.BorderStyle = BorderStyle.FixedSingle;
			ProdutoID.Location = new Point(89, 139);
			ProdutoID.Name = "ProdutoID";
			ProdutoID.Size = new Size(193, 23);
			ProdutoID.TabIndex = 6;
			// 
			// Txt_QTD
			// 
			Txt_QTD.AutoSize = true;
			Txt_QTD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_QTD.Location = new Point(374, 124);
			Txt_QTD.Name = "Txt_QTD";
			Txt_QTD.Size = new Size(76, 17);
			Txt_QTD.TabIndex = 8;
			Txt_QTD.Text = "Quantidade";
			// 
			// textBox4
			// 
			textBox4.BackColor = SystemColors.GradientInactiveCaption;
			textBox4.BorderStyle = BorderStyle.FixedSingle;
			textBox4.Location = new Point(451, 121);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(81, 23);
			textBox4.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(727, 287);
			label1.Name = "label1";
			label1.Size = new Size(40, 17);
			label1.TabIndex = 16;
			label1.Text = "00,00";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(727, 332);
			label2.Name = "label2";
			label2.Size = new Size(40, 17);
			label2.TabIndex = 16;
			label2.Text = "00,00";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(727, 377);
			label3.Name = "label3";
			label3.Size = new Size(40, 17);
			label3.TabIndex = 16;
			label3.Text = "00,00";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(131, 194);
			label4.Name = "label4";
			label4.Size = new Size(40, 17);
			label4.TabIndex = 16;
			label4.Text = "00,00";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(494, 72);
			label5.Name = "label5";
			label5.Size = new Size(38, 15);
			label5.TabIndex = 16;
			label5.Text = "00,00";
			// 
			// Txt_label
			// 
			Txt_label.AutoSize = true;
			Txt_label.Location = new Point(398, 72);
			Txt_label.Name = "Txt_label";
			Txt_label.Size = new Size(22, 15);
			Txt_label.TabIndex = 17;
			Txt_label.Text = "---";
			Txt_label.Click += Txt_label_Click;
			// 
			// Txt_ETQ
			// 
			Txt_ETQ.AutoSize = true;
			Txt_ETQ.Location = new Point(649, 72);
			Txt_ETQ.Name = "Txt_ETQ";
			Txt_ETQ.Size = new Size(22, 15);
			Txt_ETQ.TabIndex = 18;
			Txt_ETQ.Text = "---";
			Txt_ETQ.Click += Txt_ETQ_Click;
			// 
			// Btn_OK
			// 
			Btn_OK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Btn_OK.Location = new Point(451, 150);
			Btn_OK.Name = "Btn_OK";
			Btn_OK.Size = new Size(81, 23);
			Btn_OK.TabIndex = 19;
			Btn_OK.Text = "⟶";
			Btn_OK.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(429, 16);
			label6.Name = "label6";
			label6.Size = new Size(44, 17);
			label6.TabIndex = 3;
			label6.Text = "Nome";
			// 
			// textBox5
			// 
			textBox5.BackColor = SystemColors.GradientInactiveCaption;
			textBox5.BorderStyle = BorderStyle.FixedSingle;
			textBox5.Location = new Point(285, 14);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(81, 23);
			textBox5.TabIndex = 5;
			// 
			// TelaVenda
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 453);
			Controls.Add(Btn_OK);
			Controls.Add(Txt_ETQ);
			Controls.Add(Txt_label);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(Txt_Unidade);
			Controls.Add(Txt_Preco);
			Controls.Add(Txt_Pagar);
			Controls.Add(Txt_Pedido);
			Controls.Add(Txt_Estoque);
			Controls.Add(Btn_Registra);
			Controls.Add(Btn_Limpa);
			Controls.Add(Txt_Troco);
			Controls.Add(Txt_Total);
			Controls.Add(Txt_QTD);
			Controls.Add(Txt_TotalGeral);
			Controls.Add(textBox3);
			Controls.Add(ProdutoID);
			Controls.Add(textBox2);
			Controls.Add(textBox4);
			Controls.Add(textBox5);
			Controls.Add(Txt_VendaID);
			Controls.Add(ListaPedido);
			Controls.Add(label6);
			Controls.Add(Txt_Cliente);
			Controls.Add(Txt_Produto);
			Controls.Add(Txt_IdVenda);
			Controls.Add(DGV_ListaPedido);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			HelpButton = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "TelaVenda";
			Text = "Venda";
			((System.ComponentModel.ISupportInitialize)DGV_ListaPedido).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView DGV_ListaPedido;
		private Label Txt_IdVenda;
		private Label Txt_Produto;
		private Label ListaPedido;
		private Label Txt_Cliente;
		private TextBox Txt_VendaID;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label Txt_TotalGeral;
		private Button Btn_Limpa;
		private Button Btn_Registra;
		private Label Txt_Estoque;
		private Label Txt_Preco;
		private Label Txt_Pagar;
		private Label Txt_Pedido;
		private Label Txt_Unidade;
		private Label Txt_Total;
		private Label Txt_Troco;
		private TextBox ProdutoID;
		private Label Txt_QTD;
		private TextBox textBox4;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label Txt_label;
		private Label Txt_ETQ;
		private Button Btn_OK;
		private Label label6;
		private TextBox textBox5;
	}
}