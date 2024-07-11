using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysVenda_OBSEQUION.API {
	public class ClienteAPI {

		RestClient restClient = new RestClient("https://viacep.com.br/ws/");

		public Endereco GetEndereco(string cep) {
			//Exemplo de uso de interpolação de string c#
			try {
				Endereco resposta = restClient.Get<Endereco>(resource: $"{cep}/json");
				
				return resposta;
			} catch (System.InvalidOperationException) {
				return new Endereco();
			}
		}
	}
}
