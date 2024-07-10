using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysVenda_OBSEQUION.entidades;

namespace SysVenda_OBSEQUION {
    public partial class TelaLogin : Form {
        public TelaLogin() {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e) {
            Usuario user;

            using (Contexto contexto = new Contexto()) {
                user = contexto.Usuarios.FirstOrDefault(
                       u => u.Login == Txb_LoginUsuario.Text
                );
            }

            if (user != null) {
                if (user.Senha == Txb_SenhaUsuario.Text) {
                   // MessageBox.Show("Bem vindo ao OBSEQUION");
                    this.Hide();
                    Form f = new TelaPrincipal();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
            }

            msgLogin.Text = "Usuário ou senha invalida";
            msgLogin.ForeColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (Cbx_VerSenha.Checked) {
                Txb_SenhaUsuario.UseSystemPasswordChar = false;
            } else {
                Txb_SenhaUsuario.UseSystemPasswordChar = true;
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e) {

        }
    }
}

