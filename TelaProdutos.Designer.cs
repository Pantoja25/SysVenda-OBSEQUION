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
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Inserir = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Txt_Preco = new System.Windows.Forms.RichTextBox();
            this.Txt_Descricao = new System.Windows.Forms.RichTextBox();
            this.Txt_Unidade = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ProdutoId = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 209);
            this.dataGridView1.TabIndex = 40;
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Location = new System.Drawing.Point(696, 361);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(91, 41);
            this.Btn_Excluir.TabIndex = 39;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Btn_Inserir
            // 
            this.Btn_Inserir.Location = new System.Drawing.Point(28, 361);
            this.Btn_Inserir.Name = "Btn_Inserir";
            this.Btn_Inserir.Size = new System.Drawing.Size(91, 41);
            this.Btn_Inserir.TabIndex = 38;
            this.Btn_Inserir.Text = "Inserir";
            this.Btn_Inserir.UseVisualStyleBackColor = true;
            this.Btn_Inserir.Click += new System.EventHandler(this.Btn_Inserir_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(125, 361);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(91, 41);
            this.Btn_Atualizar.TabIndex = 37;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Location = new System.Drawing.Point(291, 81);
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(87, 19);
            this.Txt_Preco.TabIndex = 34;
            this.Txt_Preco.Text = "";
            // 
            // Txt_Descricao
            // 
            this.Txt_Descricao.Location = new System.Drawing.Point(291, 42);
            this.Txt_Descricao.Name = "Txt_Descricao";
            this.Txt_Descricao.Size = new System.Drawing.Size(256, 19);
            this.Txt_Descricao.TabIndex = 33;
            this.Txt_Descricao.Text = "";
            // 
            // Txt_Unidade
            // 
            this.Txt_Unidade.Location = new System.Drawing.Point(70, 84);
            this.Txt_Unidade.Name = "Txt_Unidade";
            this.Txt_Unidade.Size = new System.Drawing.Size(126, 19);
            this.Txt_Unidade.TabIndex = 32;
            this.Txt_Unidade.Text = "";
            this.Txt_Unidade.TextChanged += new System.EventHandler(this.Txt_Unidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Unidade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_ProdutoId
            // 
            this.Txt_ProdutoId.Location = new System.Drawing.Point(70, 45);
            this.Txt_ProdutoId.Name = "Txt_ProdutoId";
            this.Txt_ProdutoId.Size = new System.Drawing.Size(126, 19);
            this.Txt_ProdutoId.TabIndex = 25;
            this.Txt_ProdutoId.Text = "";
            this.Txt_ProdutoId.TextChanged += new System.EventHandler(this.Txt_IDCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // Form_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Inserir);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Txt_Descricao);
            this.Controls.Add(this.Txt_Unidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ProdutoId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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