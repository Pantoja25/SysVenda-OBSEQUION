using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SysVenda_OBSEQUION.entidades {
	internal class Produtos {
		[Key]
		public int ProdutosId { get; set; }
		public string Descricao { get; set; }
		public string Unidade { get; set; }
		public double QtdEstoque { get; set; }
		public decimal Preco { get; set; }
	}
}
