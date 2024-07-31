using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVenda_OBSEQUION.entidades;

namespace SysVenda_OBSEQUION
{
	public partial class TelaProdutos : Form {
		int estadoUsuario = 0;

		Produtos produto;

		int PrudutoID = 0;

		List<Produtos> produtos;

		private Contexto contexto;
		public TelaProdutos() {
			InitializeComponent();

			produtos = new List<Produtos>();
			using (var produtosCtx = new Contexto()) {
				produtos = produtosCtx.Produtos.ToList();
			}
			dataGridView1.DataSource = produtos;
			contexto = new Contexto();
		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private void label3_Click(object sender, EventArgs e) {

		}

		private void Btn_Atualizar_Click(object sender, EventArgs e) {
			if (estadoUsuario == 2) {
				using (var contexto = new Contexto()) {
					var produtoRegistrado = contexto.Produtos.FirstOrDefault(
						p => p.ProdutosId == PrudutoID);

					produtoRegistrado.Preco = Convert.ToDecimal(Txt_Preco.Text);
					produtoRegistrado.Unidade = Txt_Unidade.Text;
					produtoRegistrado.Descricao = Txt_Descricao.Text;

					contexto.Produtos.Update(produtoRegistrado);
					contexto.SaveChanges();

					//Atualizar o DataGridView com os dados inseridos recentemente
					produtos = new List<Produtos>();

					produtos = contexto.Produtos.ToList();

					dataGridView1.DataSource = produtos;
				}
				estadoUsuario = 1;

				limparForm();

				Btn_Inserir.Enabled = true;
				Btn_Excluir.Enabled = true;
			} else {

				Produtos produtoSelected = dataGridView1.SelectedRows[0].DataBoundItem as Produtos;

				if (dataGridView1.SelectedRows.Count > 0) {
					PrudutoID = produtoSelected.ProdutosId;
					Txt_Preco.Text = Convert.ToString(produtoSelected.Preco);
					Txt_Unidade.Text = produtoSelected.Unidade;
					Txt_Descricao.Text = produtoSelected.Descricao;

					estadoUsuario = 2;
				}

				Btn_Inserir.Enabled = false;
				Btn_Excluir.Enabled = false;
			}
		}

		private void Txt_IDCliente_TextChanged(object sender, EventArgs e) {

		}

		private void Btn_Inserir_Click(object sender, EventArgs e) {
			Produtos novoproduto = new Produtos() {
				//ProdutoID = Convert.ToInt16(Txt_ProdutoId.Text),
				Descricao = Txt_Descricao.Text,
				Preco = Convert.ToDecimal(Txt_Preco.Text),
				Unidade = Txt_Unidade.Text,
			};

			contexto.Produtos.Add(novoproduto);
			contexto.SaveChanges();
			MessageBox.Show("Produto adicionado com sucesso!! :)");

			limparForm();


			produtos = new List<Produtos>();
			using (var produtosCtx = new Contexto()) {
				produtos = produtosCtx.Produtos.ToList();
			}
			dataGridView1.DataSource = produtos;
		}

		void limparForm() {
			Txt_ProdutoId.Text = "";
			Txt_Descricao.Text = "";
			Txt_Preco.Text = "";
			Txt_Unidade.Text = "";
		}

		private void Btn_Excluir_Click(object sender, EventArgs e) {
			{
				if (dataGridView1.SelectedRows.Count > 0) {
					Produtos produtosSelected = dataGridView1.SelectedRows[0].DataBoundItem as Produtos;

					using (var produtosCxt = new Contexto()) {
						var produtoParaDeletar = produtosCxt.Produtos.FirstOrDefault(
							p => p.ProdutosId == produtosSelected.ProdutosId);
						produtosCxt.Produtos.Remove(produtoParaDeletar);
						produtosCxt.SaveChanges();

						//Atualizar o datagridview com a lista sem o cliente deletado
						produtos = new List<Produtos>();
						produtos = produtosCxt.Produtos.ToList();
						dataGridView1.DataSource = produtos;
					}
				}

			}
		}

		private void Txt_Unidade_TextChanged(object sender, EventArgs e) {

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}