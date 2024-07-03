using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_OBSEQUION.entidades {
	internal class Produtos {
		public int ProdutoId { get; set; }
		public string Descricao { get; set; }
		public string Unidade { get; set; }
		public decimal Preco { get; set; }
	}
}
