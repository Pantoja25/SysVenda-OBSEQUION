namespace SysVenda_OBSEQUION
{
    partial class TelaProdutos
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
		private void InitializeComponent() {
			dataGridView1 = new DataGridView();
			Btn_Excluir = new Button();
			Btn_Inserir = new Button();
			Btn_Atualizar = new Button();
			Txt_Preco = new RichTextBox();
			Txt_Descricao = new RichTextBox();
			Txt_Unidade = new RichTextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			Txt_ProdutoId = new RichTextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(33, 157);
			dataGridView1.Margin = new Padding(4, 3, 4, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(886, 241);
			dataGridView1.TabIndex = 40;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Btn_Excluir
			// 
			Btn_Excluir.Location = new Point(812, 417);
			Btn_Excluir.Margin = new Padding(4, 3, 4, 3);
			Btn_Excluir.Name = "Btn_Excluir";
			Btn_Excluir.Size = new Size(106, 47);
			Btn_Excluir.TabIndex = 39;
			Btn_Excluir.Text = "Excluir";
			Btn_Excluir.UseVisualStyleBackColor = true;
			Btn_Excluir.Click += Btn_Excluir_Click;
			// 
			// Btn_Inserir
			// 
			Btn_Inserir.Location = new Point(33, 417);
			Btn_Inserir.Margin = new Padding(4, 3, 4, 3);
			Btn_Inserir.Name = "Btn_Inserir";
			Btn_Inserir.Size = new Size(106, 47);
			Btn_Inserir.TabIndex = 38;
			Btn_Inserir.Text = "Inserir";
			Btn_Inserir.UseVisualStyleBackColor = true;
			Btn_Inserir.Click += Btn_Inserir_Click;
			// 
			// Btn_Atualizar
			// 
			Btn_Atualizar.Location = new Point(146, 417);
			Btn_Atualizar.Margin = new Padding(4, 3, 4, 3);
			Btn_Atualizar.Name = "Btn_Atualizar";
			Btn_Atualizar.Size = new Size(106, 47);
			Btn_Atualizar.TabIndex = 37;
			Btn_Atualizar.Text = "Atualizar";
			Btn_Atualizar.UseVisualStyleBackColor = true;
			Btn_Atualizar.Click += Btn_Atualizar_Click;
			// 
			// Txt_Preco
			// 
			Txt_Preco.Location = new Point(340, 93);
			Txt_Preco.Margin = new Padding(4, 3, 4, 3);
			Txt_Preco.Name = "Txt_Preco";
			Txt_Preco.Size = new Size(101, 21);
			Txt_Preco.TabIndex = 34;
			Txt_Preco.Text = "";
			// 
			// Txt_Descricao
			// 
			Txt_Descricao.Location = new Point(340, 48);
			Txt_Descricao.Margin = new Padding(4, 3, 4, 3);
			Txt_Descricao.Name = "Txt_Descricao";
			Txt_Descricao.Size = new Size(298, 21);
			Txt_Descricao.TabIndex = 33;
			Txt_Descricao.Text = "";
			// 
			// Txt_Unidade
			// 
			Txt_Unidade.Location = new Point(82, 97);
			Txt_Unidade.Margin = new Padding(4, 3, 4, 3);
			Txt_Unidade.Name = "Txt_Unidade";
			Txt_Unidade.Size = new Size(146, 21);
			Txt_Unidade.TabIndex = 32;
			Txt_Unidade.Text = "";
			Txt_Unidade.TextChanged += Txt_Unidade_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(292, 97);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(37, 15);
			label4.TabIndex = 28;
			label4.Text = "Preço";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 100);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 27;
			label3.Text = "Unidade";
			label3.Click += label3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(268, 52);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 26;
			label2.Text = "Descrição";
			label2.Click += label2_Click;
			// 
			// Txt_ProdutoId
			// 
			Txt_ProdutoId.Location = new Point(82, 52);
			Txt_ProdutoId.Margin = new Padding(4, 3, 4, 3);
			Txt_ProdutoId.Name = "Txt_ProdutoId";
			Txt_ProdutoId.Size = new Size(146, 21);
			Txt_ProdutoId.TabIndex = 25;
			Txt_ProdutoId.Text = "";
			Txt_ProdutoId.TextChanged += Txt_IDCliente_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(54, 55);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 24;
			label1.Text = "ID";
			// 
			// TelaProdutos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(952, 513);
			Controls.Add(dataGridView1);
			Controls.Add(Btn_Excluir);
			Controls.Add(Btn_Inserir);
			Controls.Add(Btn_Atualizar);
			Controls.Add(Txt_Preco);
			Controls.Add(Txt_Descricao);
			Controls.Add(Txt_Unidade);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(Txt_ProdutoId);
			Controls.Add(label1);
			Margin = new Padding(2);
			Name = "TelaProdutos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cadastro de Produtos";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Inserir;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.RichTextBox Txt_Preco;
        private System.Windows.Forms.RichTextBox Txt_Descricao;
        private System.Windows.Forms.RichTextBox Txt_Unidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Txt_ProdutoId;
        private System.Windows.Forms.Label label1;
    }
}