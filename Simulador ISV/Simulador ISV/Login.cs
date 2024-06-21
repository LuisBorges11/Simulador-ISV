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
            // Botão de fechar o formulário
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Lógica de autenticação (substitua esta parte com sua lógica real)
            string username = tb_user.Text;
            string password = tb_pass.Text;

            // Exemplo simples: se o username e a senha forem válidos, exibir mensagem
            if (username == "usuario" && password == "senha")
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Login falhou. Verifique suas credenciais.");
            }

            // Salvar os dados se a opção "Lembrar-me" estiver marcada
            if (cb_remember.Checked)
            {
                Properties.Settings.Default.Username = tb_user.Text;
                Properties.Settings.Default.Password = tb_pass.Text;
                Properties.Settings.Default.RememberMe = cb_remember.Checked;
            }
            else
            {
                // Se não lembrar, limpar os dados salvos
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }

            // Salvar as configurações
            Properties.Settings.Default.Save();
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança no textbox de usuário
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            // Evento de mudança no textbox de senha
        }

        private void cb_remember_CheckedChanged(object sender, EventArgs e)
        {
            // Evento de mudança no checkbox "Lembrar-me"
        }

        private void lkb_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.previousForm = this; // Atribui o formulário Login como o anterior
            registerForm.Show();
            this.Hide(); // Esconde o formulário Login
        }

        private void lkb_passRecu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar_PassW recuperarSenhaForm = new Recuperar_PassW();
            //recuperarSenhaForm.previousForm = this; // Atribui o formulário Login como o anterior
            recuperarSenhaForm.Show();
            this.Hide(); // Esconde o formulário Login
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

            // Criar uma instância do formulário Main ou qualquer outro formulário desejado
            Main formMain = new Main();

            // Exibir o novo formulário
            formMain.Show();
        }
    }
}
