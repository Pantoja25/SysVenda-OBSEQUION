namespace SysVenda_OBSEQUION {
	partial class Form_Cliente {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cliente));
			DGV_ListaClientes = new DataGridView();
			Btn_INSERIR = new Button();
			Btn_ATUALIZAR = new Button();
			Btn_EXCLUIR = new Button();
			Txt_NOME = new TextBox();
			Txt_RG = new TextBox();
			Txt_CPF = new TextBox();
			Txt_NASCIMENTO = new TextBox();
			Txt_CEP = new TextBox();
			Txt_ENDERECO = new TextBox();
			Txt_EMAIL = new TextBox();
			Txt_FONE = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			Btn_BUSCAR = new Button();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).BeginInit();
			SuspendLayout();
			// 
			// DGV_ListaClientes
			// 
			DGV_ListaClientes.BackgroundColor = SystemColors.Control;
			DGV_ListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DGV_ListaClientes.Location = new Point(53, 218);
			DGV_ListaClientes.MultiSelect = false;
			DGV_ListaClientes.Name = "DGV_ListaClientes";
			DGV_ListaClientes.ReadOnly = true;
			DGV_ListaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DGV_ListaClientes.Size = new Size(692, 155);
			DGV_ListaClientes.TabIndex = 0;
			// 
			// Btn_INSERIR
			// 
			Btn_INSERIR.BackColor = SystemColors.ActiveBorder;
			Btn_INSERIR.Location = new Point(53, 394);
			Btn_INSERIR.Name = "Btn_INSERIR";
			Btn_INSERIR.Size = new Size(75, 44);
			Btn_INSERIR.TabIndex = 1;
			Btn_INSERIR.Text = "INSERIR";
			Btn_INSERIR.UseVisualStyleBackColor = false;
			Btn_INSERIR.Click += Btn_INSERIR_Click;
			// 
			// Btn_ATUALIZAR
			// 
			Btn_ATUALIZAR.BackColor = SystemColors.ActiveBorder;
			Btn_ATUALIZAR.Location = new Point(145, 394);
			Btn_ATUALIZAR.Name = "Btn_ATUALIZAR";
			Btn_ATUALIZAR.Size = new Size(75, 44);
			Btn_ATUALIZAR.TabIndex = 2;
			Btn_ATUALIZAR.Text = "ATUALIZAR";
			Btn_ATUALIZAR.UseVisualStyleBackColor = false;
			Btn_ATUALIZAR.Click += Btn_ATUALIZAR_Click;
			// 
			// Btn_EXCLUIR
			// 
			Btn_EXCLUIR.BackColor = SystemColors.ActiveBorder;
			Btn_EXCLUIR.Location = new Point(670, 394);
			Btn_EXCLUIR.Name = "Btn_EXCLUIR";
			Btn_EXCLUIR.Size = new Size(75, 44);
			Btn_EXCLUIR.TabIndex = 3;
			Btn_EXCLUIR.Text = "EXCLUIR";
			Btn_EXCLUIR.UseVisualStyleBackColor = false;
			Btn_EXCLUIR.Click += Btn_EXCLUIR_Click;
			// 
			// Txt_NOME
			// 
			Txt_NOME.Location = new Point(101, 26);
			Txt_NOME.Name = "Txt_NOME";
			Txt_NOME.Size = new Size(644, 23);
			Txt_NOME.TabIndex = 4;
			// 
			// Txt_RG
			// 
			Txt_RG.Location = new Point(81, 71);
			Txt_RG.Name = "Txt_RG";
			Txt_RG.Size = new Size(139, 23);
			Txt_RG.TabIndex = 5;
			// 
			// Txt_CPF
			// 
			Txt_CPF.Location = new Point(291, 71);
			Txt_CPF.Name = "Txt_CPF";
			Txt_CPF.Size = new Size(147, 23);
			Txt_CPF.TabIndex = 6;
			// 
			// Txt_NASCIMENTO
			// 
			Txt_NASCIMENTO.Location = new Point(587, 71);
			Txt_NASCIMENTO.Name = "Txt_NASCIMENTO";
			Txt_NASCIMENTO.Size = new Size(158, 23);
			Txt_NASCIMENTO.TabIndex = 7;
			Txt_NASCIMENTO.TextChanged += textBox4_TextChanged;
			// 
			// Txt_CEP
			// 
			Txt_CEP.Location = new Point(90, 115);
			Txt_CEP.Name = "Txt_CEP";
			Txt_CEP.Size = new Size(106, 23);
			Txt_CEP.TabIndex = 8;
			Txt_CEP.Text = "8744360";
			Txt_CEP.TextChanged += Txt_CEP_TextChanged;
			// 
			// Txt_ENDERECO
			// 
			Txt_ENDERECO.Location = new Point(397, 115);
			Txt_ENDERECO.Name = "Txt_ENDERECO";
			Txt_ENDERECO.Size = new Size(348, 23);
			Txt_ENDERECO.TabIndex = 9;
			// 
			// Txt_EMAIL
			// 
			Txt_EMAIL.Location = new Point(103, 168);
			Txt_EMAIL.Name = "Txt_EMAIL";
			Txt_EMAIL.Size = new Size(401, 23);
			Txt_EMAIL.TabIndex = 10;
			// 
			// Txt_FONE
			// 
			Txt_FONE.Location = new Point(592, 168);
			Txt_FONE.Name = "Txt_FONE";
			Txt_FONE.Size = new Size(153, 23);
			Txt_FONE.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.Control;
			label1.Location = new Point(53, 29);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 12;
			label1.Text = "NOME:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(53, 74);
			label2.Name = "label2";
			label2.Size = new Size(25, 15);
			label2.TabIndex = 13;
			label2.Text = "RG:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(254, 74);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 14;
			label3.Text = "CPF:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(487, 74);
			label4.Name = "label4";
			label4.Size = new Size(84, 15);
			label4.TabIndex = 15;
			label4.Text = "NASCIMENTO:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(322, 120);
			label5.Name = "label5";
			label5.Size = new Size(69, 15);
			label5.TabIndex = 16;
			label5.Text = "ENDERECO:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(53, 171);
			label6.Name = "label6";
			label6.Size = new Size(44, 15);
			label6.TabIndex = 17;
			label6.Text = "EMAIL:";
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(546, 171);
			label7.Name = "label7";
			label7.Size = new Size(40, 15);
			label7.TabIndex = 18;
			label7.Text = "FONE:";
			// 
			// Btn_BUSCAR
			// 
			Btn_BUSCAR.BackColor = SystemColors.ActiveBorder;
			Btn_BUSCAR.Location = new Point(202, 115);
			Btn_BUSCAR.Name = "Btn_BUSCAR";
			Btn_BUSCAR.Size = new Size(89, 25);
			Btn_BUSCAR.TabIndex = 19;
			Btn_BUSCAR.Text = "BUSCAR";
			Btn_BUSCAR.UseVisualStyleBackColor = false;
			Btn_BUSCAR.Click += Btn_BUSCAR_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(53, 118);
			label8.Name = "label8";
			label8.Size = new Size(31, 15);
			label8.TabIndex = 20;
			label8.Text = "CEP:";
			// 
			// Form_Cliente
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(800, 450);
			Controls.Add(label8);
			Controls.Add(Btn_BUSCAR);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(Txt_FONE);
			Controls.Add(Txt_EMAIL);
			Controls.Add(Txt_ENDERECO);
			Controls.Add(Txt_CEP);
			Controls.Add(Txt_NASCIMENTO);
			Controls.Add(Txt_CPF);
			Controls.Add(Txt_RG);
			Controls.Add(Txt_NOME);
			Controls.Add(Btn_EXCLUIR);
			Controls.Add(Btn_ATUALIZAR);
			Controls.Add(Btn_INSERIR);
			Controls.Add(DGV_ListaClientes);
			Name = "Form_Cliente";
			Text = "Form_Cliente";
			((System.ComponentModel.ISupportInitialize)DGV_ListaClientes).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView DGV_ListaClientes;
		private Button Btn_INSERIR;
		private Button Btn_ATUALIZAR;
		private Button Btn_EXCLUIR;
		private TextBox Txt_NOME;
		private TextBox Txt_RG;
		private TextBox Txt_CPF;
		private TextBox Txt_NASCIMENTO;
		private TextBox Txt_CEP;
		private TextBox Txt_ENDERECO;
		private TextBox Txt_EMAIL;
		private TextBox Txt_FONE;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Button Btn_BUSCAR;
		private Label label8;
	}
}