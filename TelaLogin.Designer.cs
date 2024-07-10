namespace SysVenda_OBSEQUION {
    partial class TelaLogin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            Btn_login = new Button();
            Txb_SenhaUsuario = new TextBox();
            label1 = new Label();
            Txb_LoginUsuario = new TextBox();
            label2 = new Label();
            Cbx_VerSenha = new CheckBox();
            msgLogin = new Label();
            SuspendLayout();
            // 
            // Btn_login
            // 
            Btn_login.BackColor = Color.White;
            Btn_login.BackgroundImageLayout = ImageLayout.None;
            Btn_login.Location = new Point(330, 286);
            Btn_login.Name = "Btn_login";
            Btn_login.Size = new Size(147, 31);
            Btn_login.TabIndex = 0;
            Btn_login.Text = "Entrar";
            Btn_login.UseVisualStyleBackColor = false;
            Btn_login.Click += Btn_login_Click;
            // 
            // Txb_SenhaUsuario
            // 
            Txb_SenhaUsuario.Location = new Point(330, 207);
            Txb_SenhaUsuario.Name = "Txb_SenhaUsuario";
            Txb_SenhaUsuario.Size = new Size(145, 27);
            Txb_SenhaUsuario.TabIndex = 1;
            Txb_SenhaUsuario.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(262, 164);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // Txb_LoginUsuario
            // 
            Txb_LoginUsuario.BackColor = SystemColors.InactiveBorder;
            Txb_LoginUsuario.Location = new Point(330, 161);
            Txb_LoginUsuario.Name = "Txb_LoginUsuario";
            Txb_LoginUsuario.Size = new Size(145, 27);
            Txb_LoginUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Cursor = Cursors.AppStarting;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(266, 209);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // Cbx_VerSenha
            // 
            Cbx_VerSenha.AutoSize = true;
            Cbx_VerSenha.BackColor = Color.Transparent;
            Cbx_VerSenha.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Cbx_VerSenha.ForeColor = SystemColors.ButtonFace;
            Cbx_VerSenha.Location = new Point(330, 241);
            Cbx_VerSenha.Name = "Cbx_VerSenha";
            Cbx_VerSenha.Size = new Size(74, 17);
            Cbx_VerSenha.TabIndex = 5;
            Cbx_VerSenha.Text = "ver senha";
            Cbx_VerSenha.UseVisualStyleBackColor = false;
            Cbx_VerSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // msgLogin
            // 
            msgLogin.AutoSize = true;
            msgLogin.BackColor = Color.Transparent;
            msgLogin.Cursor = Cursors.AppStarting;
            msgLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgLogin.ForeColor = SystemColors.ButtonFace;
            msgLogin.Location = new Point(330, 142);
            msgLogin.Name = "msgLogin";
            msgLogin.Size = new Size(0, 15);
            msgLogin.TabIndex = 6;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 474);
            Controls.Add(msgLogin);
            Controls.Add(Cbx_VerSenha);
            Controls.Add(label2);
            Controls.Add(Txb_LoginUsuario);
            Controls.Add(label1);
            Controls.Add(Btn_login);
            Controls.Add(Txb_SenhaUsuario);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_login;
        private TextBox Txb_SenhaUsuario;
        private Label label1;
        private TextBox Txb_LoginUsuario;
        private Label label2;
        private CheckBox Cbx_VerSenha;
        private Label msgLogin;
    }
}