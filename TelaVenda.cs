using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVenda_OBSEQUION.entidades;
using SysVendas2.DTO;

namespace SysVenda_OBSEQUION {
	public partial class TelaVenda : Form {
		Venda vendaAtual = new Venda();
		Cliente clienteVenda = new Cliente();
		ItemVenda ItemVendaAtual = new ItemVenda();
		List<ItemVenda> itensDaVenda = new List<ItemVenda>();
		Produtos prodAtual = new Produtos();

		int idItemDaVenda = 0;

		decimal valorTotalVenda = 0;
		decimal valorPago = 0;
		public TelaVenda() {
			InitializeComponent();
		}

		private void Txt_TotalGeral_Click(object sender, EventArgs e) {
			if (prodAtual != null) {
				ItemVendaAtual.ProdutosId = prodAtual.ProdutosId;
				ItemVendaAtual.ValorUnitario = prodAtual.Preco;

				Txt_NomeProduto.Text = prodAtual.Descricao;
				Lbl_ValorProduto.Text = prodAtual.Preco.ToString("G", CultureInfo.CurrentCulture);


				LblStatusBuscaProduto.Text = "Status";
				LblStatusBuscaProduto.ForeColor = Color.Black;
			} else {
				LblStatusBuscaProduto.Text = "Produto não encontrado";
				LblStatusBuscaProduto.ForeColor = Color.Red;
			}
		}

		private void Txt_Total_Click(object sender, EventArgs e) {

		}

		private void Txt_label_Click(object sender, EventArgs e) {

		}

		private void Txt_ETQ_Click(object sender, EventArgs e) {

		}

		private void Btn_OK_Click(object sender, EventArgs e) {
			itensDaVenda.Add(
				new ItemVenda {
					VendaId = 0,
					ProdutosId = prodAtual.ProdutosId,
					Quantidade = ItemVendaAtual.Quantidade,
					ValorUnitario = prodAtual.Preco
				}
			);
			DGV_ListaPedido.Rows.Add(
				++idItemDaVenda,
				prodAtual.Descricao,
				ItemVendaAtual.ValorUnitario.ToString("C2", CultureInfo.CurrentCulture),
				ItemVendaAtual.Quantidade,
				ItemVendaAtual.Subtotal.ToString("C2", CultureInfo.CurrentCulture)
			 );

			valorTotalVenda += ItemVendaAtual.Subtotal;

			Lbl_TotalVenda.Text = valorTotalVenda.ToString("C2", CultureInfo.CurrentCulture);
		}

		private void TxT_ValorPago_TextChanged(object sender, EventArgs e) {
			if (TxT_ValorPago.Text.Length > 0) {
				decimal troco = Convert.ToDecimal(TxT_ValorPago.Text) - valorTotalVenda;

				Lbl_ValorTroco.Text = troco.ToString("C2", CultureInfo.CurrentCulture);
				if (troco < 0) {
					Lbl_ValorTroco.ForeColor = Color.Black;
				} else {
					Lbl_ValorTroco.ForeColor = Color.Black;
				}
			}
		}

		private void Btn_Registra_Click(object sender, EventArgs e) {
			using (var ctx = new Contexto()) {
				//vendaAtual.ValorTotal = valorTotalVenda;

				Venda ultimaVenda;
				int idVendaAtual;

				try {
					ultimaVenda = ctx.Vendas.OrderByDescending(v => v.VendaId).Take(1).Last();
					idVendaAtual = ultimaVenda.VendaId;

				} catch (Exception ex) {
					idVendaAtual = 0;
				}



				vendaAtual.VendaId = ++idVendaAtual;
				vendaAtual.Cliente = ctx.Clientes.FirstOrDefault(c => c.ClienteId == vendaAtual.ClinteId);

				//vendaAtual.StatusVenda = TiposStatusVenda.CONCLUIDA;

				ctx.Vendas.Add(vendaAtual);
				ctx.SaveChanges();

				itensDaVenda.ForEach(item => {
					item.VendaId = vendaAtual.VendaId;
				});

				ctx.ItensVendas.AddRange(itensDaVenda);
				ctx.SaveChanges();
			}


			List<ItemVendaDTO> intem = new List<ItemVendaDTO>();
		}

		private void Lbl_QtdEstoque_Click(object sender, EventArgs e) {

			if (Txt_IDProduto.Text.Length > 0) {

				int idProduto = Convert.ToInt32(Txt_IDProduto.Text);
				Produtos produtoAtual = new Produtos();

				Lbl_QtdEstoque.Text = "Buscando produto";
				Lbl_QtdEstoque.ForeColor = Color.Green;

				using (var context = new Contexto()) {
					produtoAtual = context.Clientes.FirstOrDefault(p => p.Produtosid == ProdutosId);

					if (produtoAtual != null) {
						Txt_IDProduto.Text = produtoAtual.Disponivel;

						//vendaAtual.Cliente = clienteAtual;
						vendaAtual.ProdutosId = produtoAtual.ProdutosId;

						Lbl_QtdEstoque.Text = "Status Produto";
						Lbl_QtdEstoque.ForeColor = Color.Black;
					} else {
						Lbl_QtdEstoque.Text = "Produto não encontrado";
						Lbl_QtdEstoque.ForeColor = Color.Red;
					}
				}
			}
		}

	}
}
