using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysVenda_OBSEQUION.entidades {
	internal class ItemVenda {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ItemVendaId { get; set; }
		public int VendaId { get; set; }
		public int ProdutoId { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }
		public bool Disponivel { get; set; }
		public decimal Quantidade { get; set; }
		public decimal ValorUnitario { get; set; }
		public decimal Subtotal {
			get { return ValorUnitario * Quantidade; }

		}

		public Venda Venda { get; set; }
		public Produtos Produtos { get; set; }
	}
}
