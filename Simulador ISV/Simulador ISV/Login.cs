namespace Simulador_ISV
{
    public partial class Login : Form
    {
        private Form previousForm;

        public Login()
        {
            InitializeComponent();



            // Carregar os dados salvos
            if (Properties.Settings.Default.RememberMe)
            {
                tb_user.Text = Properties.Settings.Default.Username;
                tb_pass.Text = Properties.Settings.Default.Password;
                cb_remember.Checked = Properties.Settings.Default.RememberMe;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bot�o de fechar o formul�rio
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // L�gica de autentica��o (substitua esta parte com sua l�gica real)
            string username = tb_user.Text;
            string password = tb_pass.Text;

            // Exemplo simples: se o username e a senha forem v�lidos, exibir mensagem
            if (username == "usuario" && password == "senha")
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais.");
            }

            // Salvar os dados se a op��o "Lembrar-me" estiver marcada
            if (cb_remember.Checked)
            {
                Properties.Settings.Default.Username = tb_user.Text;
                Properties.Settings.Default.Password = tb_pass.Text;
                Properties.Settings.Default.RememberMe = cb_remember.Checked;
            }
            else
            {
                // Se n�o lembrar, limpar os dados salvos
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }

            // Salvar as configura��es
            Properties.Settings.Default.Save();
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudan�a no textbox de usu�rio
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudan�a no textbox de senha
        }

        private void cb_remember_CheckedChanged(object sender, EventArgs e)
        {
            // Evento de mudan�a no checkbox "Lembrar-me"
        }

        private void lkb_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.previousForm = this; // Atribui o formul�rio Login como o anterior
            registerForm.Show();
            this.Hide(); // Esconde o formul�rio Login
        }

        private void lkb_passRecu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_PassW recuperarSenhaForm = new Recuperar_PassW();
            //recuperarSenhaForm.previousForm = this; // Atribui o formul�rio Login como o anterior
            recuperarSenhaForm.Show();
            this.Hide(); // Esconde o formul�rio Login
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_user.Text = "Digite o seu email";
            tb_user.ForeColor = SystemColors.GrayText; // Cor do texto cinza

            tb_pass.Text = "Digite o seu username";
            tb_pass.ForeColor = SystemColors.GrayText; // Cor do texto cinza
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Criar uma inst�ncia do formul�rio Main ou qualquer outro formul�rio desejado
            Main formMain = new Main();

            // Exibir o novo formul�rio
            formMain.Show();
        }
    }
}
