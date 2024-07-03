using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_OBSEQUION.entidades {
	internal class Venda {
		public int VendaId { get; set; }
		public int ClinteId { get; set; }
		public int ProdutoId { get; set; }
		public DateTime DataVenda { get; set; }
		public int Quantidade { get; set; }

		public Cliente Cliente { get; set; }
		public Produtos Produto { get; set; }

	}
}
