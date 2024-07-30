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
		private void Txt_Qtd_TextChanged(object sender, EventArgs e) {
			if (Txt_QTDitem.Text.Length > 0) {
				int qtdVendida = Convert.ToInt32(Txt_QTDitem.Text);

				if (qtdVendida > 0) {
					ItemVendaAtual.Quantidade = qtdVendida;
					Txt_SubTotal.Text = ItemVendaAtual.Subtotal.ToString("G", CultureInfo.CurrentCulture);
				}
			} else {
				Txt_SubTotal.Text = string.Empty;
			}
		}

		private void Txt_IDProduto_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)Keys.Enter) {
				if (Txt_IDProduto.Text.Length > 0) {
					int idProduto = Convert.ToInt16(Txt_IDProduto.Text);

					LblStatusBuscaProduto.Text = "Buscando produto";
					LblStatusBuscaProduto.ForeColor = Color.Green;

					using (var context = new Contexto()) {
						prodAtual = context.Produtos.FirstOrDefault(p => p.ProdutosId == idProduto);

						if (prodAtual != null) {
							ItemVendaAtual.ProdutoId = prodAtual.ProdutosId;
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
				}
			}

			Txt_Qtd_TextChanged(new object(), new EventArgs());

		}

		private void textBox4_TextChanged(object sender, EventArgs e) {
			Txt_Qtd_TextChanged(sender, e);
		}


		private void Txt_Cliente_Click(object sender, EventArgs e) {

		}

		private void Txt_ClienteId_TextChanged(object sender, EventArgs e) {
			if (Txt_ClienteId.Text.Length > 0) {

				int idCliente = Convert.ToInt32(Txt_ClienteId.Text);
				Cliente clienteAtual = new Cliente();

				LblStatusBuscaCliente.Text = "Buscando cliente";
				LblStatusBuscaCliente.ForeColor = Color.Green;

				using (var context = new Contexto()) {
					clienteAtual = context.Clientes.FirstOrDefault(p => p.ClienteId == idCliente);

					if (clienteAtual != null) {
						Txt_NomeCliente.Text = clienteAtual.Nome;

						//vendaAtual.Cliente = clienteAtual;
						vendaAtual.ClinteId = clienteAtual.ClienteId;

						LblStatusBuscaCliente.Text = "Status cliente";
						LblStatusBuscaCliente.ForeColor = Color.Black;
					} else {
						LblStatusBuscaCliente.Text = "Cliente não encontrado";
						LblStatusBuscaCliente.ForeColor = Color.Red;
					}
				}
			}
		}

		private void Btn_OK_Click(object sender, EventArgs e) {
			itensDaVenda.Add(
				new ItemVenda {
					VendaId = 0,
					ProdutoId = prodAtual.ProdutosId,
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
				vendaAtual.ValorTotal = valorTotalVenda;

				Venda ultimaVenda = ctx.Vendas.OrderByDescending(v => v.VendaId).Take(1).Last();
				int idVendaAtual = ultimaVenda.VendaId;

				vendaAtual.VendaId = ++idVendaAtual;

				vendaAtual.StatusVenda = TiposStatusVenda.CONCLUIDA;

				ctx.Vendas.Add(vendaAtual);
				ctx.SaveChanges();

				itensDaVenda.ForEach(item => {
					item.VendaId = vendaAtual.VendaId;
				});

				ctx.ItensVenda.AddRange(itensDaVenda);
				ctx.SaveChanges();
			}


			List<ItemVendaDTO> intem = new List<ItemVendaDTO>();
		}
	}
}
