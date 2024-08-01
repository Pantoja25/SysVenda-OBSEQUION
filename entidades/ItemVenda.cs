
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SysVenda_OBSEQUION.entidades {
	internal class ItemVenda {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ItemVendaId { get; set; }
		public int VendaId { get; set; }
		public int ProdutosId { get; set; }
		public string? Descricao { get; set; }
		public decimal Preco { get; set; }
		public decimal Quantidade { get; set; }
		public decimal ValorUnitario { get; set; }
		public decimal Subtotal {
			get { return ValorUnitario * Quantidade; }
		}

		public Venda Venda { get; set; }
		public Produtos Produtos { get; set; }
	}
}
