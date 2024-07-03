using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_OBSEQUION.entidades {
	internal class ItemVenda {
			public int ItemVendaId { get; set; }
			public string Titulo { get; set; }
			public string Descricao { get; set; } 
			public decimal Preco { get; set; } 
			public string Categoria { get; set; } 
			public string ImagemURL { get; set; } 
			public int QuantidadeEmEstoque { get; set; } 
			public bool Disponivel { get; set; } 
	}

}
