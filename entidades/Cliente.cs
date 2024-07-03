using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_OBSEQUION.entidades {
	internal class Cliente {
		public int ClienteId { get; set; }
		public string Nome { get; set; }
		public string RG { get; set; }
		public string CPF { get; set; }
		public DateTime Nascimento { get; set; }
		public string Endereco { get; set; }
		public string Fone { get; set; }
		public string Email { get; set; }
	}
}
