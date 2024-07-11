using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Policy;
using SysVenda_OBSEQUION.entidades;
using SysVenda_OBSEQUION.API;

namespace SysVenda_OBSEQUION {
	public partial class Form_Cliente : Form {

		private Contexto contexto;

		int estadoUsuario = 0;

		Cliente cliente;

		List<Cliente> clientes;

		int clienteId = 0;

		public Form_Cliente() {
			InitializeComponent();
			contexto = new Contexto();

			clientes = new List<Cliente>();

			using (var clienteCxt = new Contexto()) {
				clientes = clienteCxt.Clientes.ToList();
			}

			DGV_ListaClientes.DataSource = clientes;
		}

		private void label6_Click(object sender, EventArgs e) {

		}

		private void textBox4_TextChanged(object sender, EventArgs e) {

		}

		private void Btn_INSERIR_Click(object sender, EventArgs e) {
			//Converção em formato de data
			DateTime dataNascimento;
			DateTime.TryParseExact(Txt_NASCIMENTO.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento);


			Cliente novocliente = new Cliente() {

				Nome = Txt_NOME.Text,
				RG = Txt_RG.Text,
				CPF = Txt_CPF.Text,
				Nascimento = dataNascimento,
				Endereco = Txt_ENDERECO.Text,
				Fone = Txt_FONE.Text,
				Email = Txt_EMAIL.Text,
			};

			//Inserção no bancos de dados
			contexto.Clientes.Add(novocliente);
			contexto.SaveChanges();
			MessageBox.Show("Cliente adicionado com sucesso!");

			//lImpeza das caixas de texto
			Txt_NOME.Text = "";
			Txt_RG.Text = "";
			Txt_CPF.Text = "";
			Txt_NASCIMENTO.Text = "";
			Txt_ENDERECO.Text = "";
			Txt_FONE.Text = "";
			Txt_EMAIL.Text = "";
			Txt_NOME.Focus();

			using (var clientesCxt = new Contexto()) {
				clientes = new List<Cliente>();
				clientes = clientesCxt.Clientes.ToList();
				DGV_ListaClientes.DataSource = clientes;
			}

		}

		private void Btn_ATUALIZAR_Click(object sender, EventArgs e) {
			if (estadoUsuario == 2) {
				using (var contexto = new Contexto()) {
					var clienteRegistrado = contexto.Clientes.FirstOrDefault(
						c => c.ClienteId == clienteId);

					if (clienteRegistrado != null && Txt_NOME != null) {
						clienteRegistrado.Nome = Txt_NOME.Text;
						clienteRegistrado.RG = Txt_RG.Text;
						clienteRegistrado.CPF = Txt_CPF.Text;
						clienteRegistrado.Endereco = Txt_ENDERECO.Text;
						clienteRegistrado.Fone = Txt_FONE.Text;
						clienteRegistrado.Email = Txt_EMAIL.Text;
						//clienteRegistrado.DataNascimento = dataNascimento;

						contexto.Clientes.Update(clienteRegistrado);
						contexto.SaveChanges();

						estadoUsuario = 1;

						MessageBox.Show("Clientes Atualizado!");


					} else {
						MessageBox.Show("Cliente não encontrado ou campos inválidos.");

					}
					clientes = new List<Cliente>();
					clientes = contexto.Clientes.ToList();
					DGV_ListaClientes.DataSource = clientes;
				}

			} else {
				if (DGV_ListaClientes.SelectedRows.Count > 0) {
					Cliente clienteSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

					clienteId = clienteSelected.ClienteId;
					Txt_NOME.Text = clienteSelected.Nome;
					Txt_RG.Text = clienteSelected.RG;
					Txt_CPF.Text = clienteSelected.CPF;
					Txt_ENDERECO.Text = clienteSelected.Endereco;
					Txt_FONE.Text = clienteSelected.Fone;
					Txt_EMAIL.Text = clienteSelected.Email;
					//Txt_NASCIMENTO.Text = clienteSelected.DataNascimento;

					estadoUsuario = 2;
				}
			}
		}

		private void Btn_EXCLUIR_Click(object sender, EventArgs e) {
			if (DGV_ListaClientes.SelectedRows.Count > 0) {
				Cliente clientesSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

				using (var clientesCxt = new Contexto()) {
					var clienteParaDeletar = clientesCxt.Clientes.FirstOrDefault(
						c => c.ClienteId == clientesSelected.ClienteId);

					clientesCxt.Clientes.Remove(clienteParaDeletar);
					clientesCxt.SaveChanges();

					clientes = new List<Cliente>();
					clientes = clientesCxt.Clientes.ToList();
					DGV_ListaClientes.DataSource = clientes;

					MessageBox.Show("Cliente Excluido!");
				}
			}
		}

		private void Btn_BUSCAR_Click(object sender, EventArgs e) {

			ClienteAPI cliente = new ClienteAPI();

			Endereco Resp = cliente.GetEndereco(Txt_CEP.Text);

			if (Resp.uf != null) {
				Txt_ENDERECO.Text = Resp.logradouro + ", " + Resp.localidade + ", " + Resp.uf;
			} else {
				MessageBox.Show("CEP inválido!");
			}
		}
	}
}
