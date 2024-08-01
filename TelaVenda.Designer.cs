namespace SysVenda_OBSEQUION {
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
			DGV_ListaPedido = new DataGridView();
			IdItemDaVenda = new DataGridViewTextBoxColumn();
			NomeProduto = new DataGridViewTextBoxColumn();
			PrecoUnitario = new DataGridViewTextBoxColumn();
			QuantidadeVendida = new DataGridViewTextBoxColumn();
			SubTotalDoItem = new DataGridViewTextBoxColumn();
			Txt_IdVenda = new Label();
			Txt_Produto = new Label();
			ListaPedido = new Label();
			Txt_Cliente = new Label();
			Txt_VendaID = new TextBox();
			Txt_IDProduto = new TextBox();
			Txt_NomeCliente = new TextBox();
			Txt_TotalGeral = new Label();
			Btn_Limpa = new Button();
			Btn_Registra = new Button();
			Txt_Estoque = new Label();
			Txt_Preco = new Label();
			Txt_Pagar = new Label();
			Txt_Pedido = new Label();
			Txt_Total = new Label();
			Txt_Troco = new Label();
			Txt_NomeProduto = new TextBox();
			Txt_QTD = new Label();
			Txt_QTDitem = new TextBox();
			Lbl_TotalVenda = new Label();
			Lbl_ValorTroco = new Label();
			Txt_SubTotal = new Label();
			Lbl_ValorProduto = new Label();
			Txt_ETQ = new Label();
			Btn_OK = new Button();
			label6 = new Label();
			Txt_ClienteId = new TextBox();
			LblStatusBuscaProduto = new Label();
			label7 = new Label();
			LblStatusBuscaCliente = new Label();
			TxT_ValorPago = new TextBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)DGV_ListaPedido).BeginInit();
			SuspendLayout();
			// 
			// DGV_ListaPedido
			// 
			DGV_ListaPedido.AllowUserToOrderColumns = true;
			DGV_ListaPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DGV_ListaPedido.BackgroundColor = SystemColors.Info;
			DGV_ListaPedido.BorderStyle = BorderStyle.Fixed3D;
			DGV_ListaPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_ListaPedido.Columns.AddRange(new DataGridViewColumn[] { IdItemDaVenda, NomeProduto, PrecoUnitario, QuantidadeVendida, SubTotalDoItem });
			DGV_ListaPedido.Location = new Point(12, 305);
			DGV_ListaPedido.Name = "DGV_ListaPedido";
			DGV_ListaPedido.ReadOnly = true;
			DGV_ListaPedido.Size = new Size(520, 133);
			DGV_ListaPedido.TabIndex = 0;
			// 
			// IdItemDaVenda
			// 
			IdItemDaVenda.DataPropertyName = "IdItemDaVenda";
			IdItemDaVenda.HeaderText = "Id";
			IdItemDaVenda.Name = "IdItemDaVenda";
			IdItemDaVenda.ReadOnly = true;
			// 
			// NomeProduto
			// 
			NomeProduto.DataPropertyName = "NomeProduto";
			NomeProduto.HeaderText = "Nome";
			NomeProduto.Name = "NomeProduto";
			NomeProduto.ReadOnly = true;
			// 
			// PrecoUnitario
			// 
			PrecoUnitario.DataPropertyName = "PrecoUnitario";
			PrecoUnitario.HeaderText = "Preco";
			PrecoUnitario.Name = "PrecoUnitario";
			PrecoUnitario.ReadOnly = true;
			// 
			// QuantidadeVendida
			// 
			QuantidadeVendida.DataPropertyName = "QuantidadeVendida";
			QuantidadeVendida.HeaderText = "Quantidade";
			QuantidadeVendida.Name = "QuantidadeVendida";
			QuantidadeVendida.ReadOnly = true;
			// 
			// SubTotalDoItem
			// 
			SubTotalDoItem.DataPropertyName = "SubTotalDoItem";
			SubTotalDoItem.HeaderText = "SubTotal";
			SubTotalDoItem.Name = "SubTotalDoItem";
			SubTotalDoItem.ReadOnly = true;
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
			// Txt_IDProduto
			// 
			Txt_IDProduto.BackColor = SystemColors.GradientInactiveCaption;
			Txt_IDProduto.BorderStyle = BorderStyle.FixedSingle;
			Txt_IDProduto.Location = new Point(89, 64);
			Txt_IDProduto.Name = "Txt_IDProduto";
			Txt_IDProduto.Size = new Size(193, 23);
			Txt_IDProduto.TabIndex = 6;
			// 
			// Txt_NomeCliente
			// 
			Txt_NomeCliente.BackColor = SystemColors.GradientInactiveCaption;
			Txt_NomeCliente.BorderStyle = BorderStyle.FixedSingle;
			Txt_NomeCliente.Location = new Point(479, 12);
			Txt_NomeCliente.Name = "Txt_NomeCliente";
			Txt_NomeCliente.Size = new Size(309, 23);
			Txt_NomeCliente.TabIndex = 7;
			// 
			// Txt_TotalGeral
			// 
			Txt_TotalGeral.AutoSize = true;
			Txt_TotalGeral.BackColor = SystemColors.ActiveCaption;
			Txt_TotalGeral.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_TotalGeral.ForeColor = SystemColors.ControlText;
			Txt_TotalGeral.Location = new Point(599, 287);
			Txt_TotalGeral.Name = "Txt_TotalGeral";
			Txt_TotalGeral.Size = new Size(81, 20);
			Txt_TotalGeral.TabIndex = 8;
			Txt_TotalGeral.Text = "Total Geral";
			// 
			// Btn_Limpa
			// 
			Btn_Limpa.BackColor = SystemColors.GradientInactiveCaption;
			Btn_Limpa.Location = new Point(598, 418);
			Btn_Limpa.Name = "Btn_Limpa";
			Btn_Limpa.Size = new Size(56, 23);
			Btn_Limpa.TabIndex = 10;
			Btn_Limpa.Text = "Limpa";
			Btn_Limpa.UseVisualStyleBackColor = false;
			Btn_Limpa.Click += Btn_Limpa_Click;
			// 
			// Btn_Registra
			// 
			Btn_Registra.BackColor = SystemColors.GradientInactiveCaption;
			Btn_Registra.Location = new Point(659, 418);
			Btn_Registra.Name = "Btn_Registra";
			Btn_Registra.Size = new Size(62, 23);
			Btn_Registra.TabIndex = 11;
			Btn_Registra.Text = "Registrar";
			Btn_Registra.UseVisualStyleBackColor = false;
			// 
			// Txt_Estoque
			// 
			Txt_Estoque.AutoSize = true;
			Txt_Estoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Estoque.Location = new Point(479, 70);
			Txt_Estoque.Name = "Txt_Estoque";
			Txt_Estoque.Size = new Size(84, 17);
			Txt_Estoque.TabIndex = 12;
			Txt_Estoque.Text = "QDT Estoque";
			// 
			// Txt_Preco
			// 
			Txt_Preco.AutoSize = true;
			Txt_Preco.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Preco.Location = new Point(325, 72);
			Txt_Preco.Name = "Txt_Preco";
			Txt_Preco.Size = new Size(41, 17);
			Txt_Preco.TabIndex = 12;
			Txt_Preco.Text = "Preço";
			// 
			// Txt_Pagar
			// 
			Txt_Pagar.AutoSize = true;
			Txt_Pagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Pagar.Location = new Point(599, 332);
			Txt_Pagar.Name = "Txt_Pagar";
			Txt_Pagar.Size = new Size(46, 20);
			Txt_Pagar.TabIndex = 12;
			Txt_Pagar.Text = "Pagar";
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
			// Txt_Total
			// 
			Txt_Total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Total.Location = new Point(58, 191);
			Txt_Total.Name = "Txt_Total";
			Txt_Total.Size = new Size(67, 24);
			Txt_Total.TabIndex = 8;
			Txt_Total.Text = "Total";
			// 
			// Txt_Troco
			// 
			Txt_Troco.AutoSize = true;
			Txt_Troco.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_Troco.Location = new Point(599, 377);
			Txt_Troco.Name = "Txt_Troco";
			Txt_Troco.Size = new Size(46, 20);
			Txt_Troco.TabIndex = 8;
			Txt_Troco.Text = "Troco";
			// 
			// Txt_NomeProduto
			// 
			Txt_NomeProduto.BackColor = SystemColors.GradientInactiveCaption;
			Txt_NomeProduto.BorderStyle = BorderStyle.FixedSingle;
			Txt_NomeProduto.Location = new Point(89, 139);
			Txt_NomeProduto.Name = "Txt_NomeProduto";
			Txt_NomeProduto.Size = new Size(193, 23);
			Txt_NomeProduto.TabIndex = 6;
			// 
			// Txt_QTD
			// 
			Txt_QTD.AutoSize = true;
			Txt_QTD.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Txt_QTD.Location = new Point(374, 139);
			Txt_QTD.Name = "Txt_QTD";
			Txt_QTD.Size = new Size(76, 17);
			Txt_QTD.TabIndex = 8;
			Txt_QTD.Text = "Quantidade";
			// 
			// Txt_QTDitem
			// 
			Txt_QTDitem.BackColor = SystemColors.GradientInactiveCaption;
			Txt_QTDitem.BorderStyle = BorderStyle.FixedSingle;
			Txt_QTDitem.Location = new Point(456, 139);
			Txt_QTDitem.Name = "Txt_QTDitem";
			Txt_QTDitem.Size = new Size(81, 23);
			Txt_QTDitem.TabIndex = 5;
			// 
			// Lbl_TotalVenda
			// 
			Lbl_TotalVenda.AutoSize = true;
			Lbl_TotalVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Lbl_TotalVenda.Location = new Point(727, 287);
			Lbl_TotalVenda.Name = "Lbl_TotalVenda";
			Lbl_TotalVenda.Size = new Size(40, 17);
			Lbl_TotalVenda.TabIndex = 16;
			Lbl_TotalVenda.Text = "00,00";
			// 
			// Lbl_ValorTroco
			// 
			Lbl_ValorTroco.AutoSize = true;
			Lbl_ValorTroco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Lbl_ValorTroco.Location = new Point(727, 377);
			Lbl_ValorTroco.Name = "Lbl_ValorTroco";
			Lbl_ValorTroco.Size = new Size(40, 17);
			Lbl_ValorTroco.TabIndex = 16;
			Lbl_ValorTroco.Text = "00,00";
			// 
			// Txt_SubTotal
			// 
			Txt_SubTotal.AutoSize = true;
			Txt_SubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Txt_SubTotal.Location = new Point(131, 194);
			Txt_SubTotal.Name = "Txt_SubTotal";
			Txt_SubTotal.Size = new Size(40, 17);
			Txt_SubTotal.TabIndex = 16;
			Txt_SubTotal.Text = "00,00";
			// 
			// Lbl_ValorProduto
			// 
			Lbl_ValorProduto.AutoSize = true;
			Lbl_ValorProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Lbl_ValorProduto.Location = new Point(380, 74);
			Lbl_ValorProduto.Name = "Lbl_ValorProduto";
			Lbl_ValorProduto.Size = new Size(38, 15);
			Lbl_ValorProduto.TabIndex = 16;
			Lbl_ValorProduto.Text = "00,00";
			// 
			// Txt_ETQ
			// 
			Txt_ETQ.AutoSize = true;
			Txt_ETQ.Location = new Point(572, 72);
			Txt_ETQ.Name = "Txt_ETQ";
			Txt_ETQ.Size = new Size(22, 15);
			Txt_ETQ.TabIndex = 18;
			Txt_ETQ.Text = "---";
			// 
			// Btn_OK
			// 
			Btn_OK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Btn_OK.Location = new Point(456, 165);
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
			// Txt_ClienteId
			// 
			Txt_ClienteId.BackColor = SystemColors.GradientInactiveCaption;
			Txt_ClienteId.BorderStyle = BorderStyle.FixedSingle;
			Txt_ClienteId.Location = new Point(285, 14);
			Txt_ClienteId.Name = "Txt_ClienteId";
			Txt_ClienteId.Size = new Size(81, 23);
			Txt_ClienteId.TabIndex = 5;
			// 
			// LblStatusBuscaProduto
			// 
			LblStatusBuscaProduto.AutoSize = true;
			LblStatusBuscaProduto.Location = new Point(188, 90);
			LblStatusBuscaProduto.Name = "LblStatusBuscaProduto";
			LblStatusBuscaProduto.Size = new Size(22, 15);
			LblStatusBuscaProduto.TabIndex = 20;
			LblStatusBuscaProduto.Text = "---";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(188, 165);
			label7.Name = "label7";
			label7.Size = new Size(22, 15);
			label7.TabIndex = 21;
			label7.Text = "---";
			// 
			// LblStatusBuscaCliente
			// 
			LblStatusBuscaCliente.AutoSize = true;
			LblStatusBuscaCliente.Location = new Point(285, 40);
			LblStatusBuscaCliente.Name = "LblStatusBuscaCliente";
			LblStatusBuscaCliente.Size = new Size(22, 15);
			LblStatusBuscaCliente.TabIndex = 17;
			LblStatusBuscaCliente.Text = "---";
			// 
			// TxT_ValorPago
			// 
			TxT_ValorPago.BackColor = SystemColors.GradientInactiveCaption;
			TxT_ValorPago.BorderStyle = BorderStyle.FixedSingle;
			TxT_ValorPago.Font = new Font("Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 2);
			TxT_ValorPago.ForeColor = SystemColors.InactiveCaptionText;
			TxT_ValorPago.ImeMode = ImeMode.NoControl;
			TxT_ValorPago.Location = new Point(705, 330);
			TxT_ValorPago.Name = "TxT_ValorPago";
			TxT_ValorPago.Size = new Size(81, 22);
			TxT_ValorPago.TabIndex = 5;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.GradientInactiveCaption;
			button1.Location = new Point(727, 418);
			button1.Name = "button1";
			button1.Size = new Size(62, 23);
			button1.TabIndex = 12;
			button1.Text = "Imprimir";
			button1.UseVisualStyleBackColor = false;
			button1.Click += Btn_Limpa_Click;
			// 
			// TelaVenda
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 453);
			Controls.Add(label7);
			Controls.Add(LblStatusBuscaProduto);
			Controls.Add(Btn_OK);
			Controls.Add(Txt_ETQ);
			Controls.Add(LblStatusBuscaCliente);
			Controls.Add(Lbl_ValorTroco);
			Controls.Add(Lbl_ValorProduto);
			Controls.Add(Txt_SubTotal);
			Controls.Add(Lbl_TotalVenda);
			Controls.Add(Txt_Preco);
			Controls.Add(Txt_Pagar);
			Controls.Add(Txt_Pedido);
			Controls.Add(Txt_Estoque);
			Controls.Add(Btn_Registra);
			Controls.Add(button1);
			Controls.Add(Btn_Limpa);
			Controls.Add(Txt_Troco);
			Controls.Add(Txt_Total);
			Controls.Add(Txt_QTD);
			Controls.Add(Txt_TotalGeral);
			Controls.Add(Txt_NomeCliente);
			Controls.Add(Txt_NomeProduto);
			Controls.Add(Txt_IDProduto);
			Controls.Add(Txt_QTDitem);
			Controls.Add(Txt_ClienteId);
			Controls.Add(TxT_ValorPago);
			Controls.Add(Txt_VendaID);
			Controls.Add(ListaPedido);
			Controls.Add(label6);
			Controls.Add(Txt_Cliente);
			Controls.Add(Txt_Produto);
			Controls.Add(Txt_IdVenda);
			Controls.Add(DGV_ListaPedido);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			HelpButton = true;
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
		private TextBox Txt_IDProduto;
		private TextBox Txt_NomeCliente;
		private Label Txt_TotalGeral;
		private Button Btn_Limpa;
		private Button Btn_Registra;
		private Label Txt_Estoque;
		private Label Txt_Preco;
		private Label Txt_Pagar;
		private Label Txt_Pedido;
		private Label Txt_Total;
		private Label Txt_Troco;
		private TextBox Txt_NomeProduto;
		private Label Txt_QTD;
		private TextBox Txt_QTDitem;
		private Label Lbl_TotalVenda;
		private Label Lbl_ValorTroco;
		private Label Txt_SubTotal;
		private Label Lbl_ValorProduto;
		private Label Txt_ETQ;
		private Button Btn_OK;
		private Label label6;
		private TextBox Txt_ClienteId;
		private Label LblStatusBuscaProduto;
		private Label label7;
		private Label LblStatusBuscaCliente;
		private DataGridViewTextBoxColumn IdItemDaVenda;
		private DataGridViewTextBoxColumn NomeProduto;
		private DataGridViewTextBoxColumn PrecoUnitario;
		private DataGridViewTextBoxColumn QuantidadeVendida;
		private DataGridViewTextBoxColumn SubTotalDoItem;
		private TextBox TxT_ValorPago;
		private Button button1;
	}
}