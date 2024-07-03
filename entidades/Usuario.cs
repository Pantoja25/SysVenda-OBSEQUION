using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVenda_OBSEQUION.entidades {
	internal class Usuario {
		public int UsuarioId { get; set; }
		public string UsuarioName { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
		public string Tipo { get; set; }
		public string Email { get; set; } 
		public DateTime DataCriacao { get; set; } 
		public bool Ativo { get; set; } 
		public string Endereco { get; set; } 
		public string Telefone { get; set; } 
	}

}

