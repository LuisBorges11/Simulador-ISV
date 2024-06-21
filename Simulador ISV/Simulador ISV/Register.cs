using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_ISV
{
    public partial class Register : Form
    {
        public Form previousForm;
        public Register()
        {
            InitializeComponent();
        }

        private void lkb_Termos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Texto dos termos e condições
            string termos = @"
                
                Termos e Condições de Registo

                Bem-vindo(a) ao nosso serviço de registo. Antes de continuar, por favor, leia atentamente os termos e condições abaixo:

                1. Aceitação dos Termos: Ao registar-se na nossa plataforma, concorda em cumprir estes termos e condições, assim como as nossas políticas de privacidade.

                2. Uso Adequado: Compromete-se a utilizar os nossos serviços apenas para fins legais, em conformidade com todas as leis e regulamentos aplicáveis.

                3. Informações de Registo: É da sua responsabilidade fornecer informações precisas e completas durante o processo de registo. É também responsável por manter essas informações atualizadas.

                4. Segurança da Conta: Compromete-se a manter a segurança da sua conta e palavra-passe. Deverá notificar-nos imediatamente sobre qualquer uso não autorizado da sua conta.

                5. Privacidade: Respeitamos a sua privacidade. Todas as informações pessoais fornecidas durante o registo são tratadas de acordo com a nossa política de privacidade.

                6. Alterações nos Termos: Podemos atualizar ou modificar estes termos periodicamente. Será informado(a) sobre quaisquer alterações significativas.

                7. Encerramento da Conta: Pode encerrar a sua conta a qualquer momento, seguindo os procedimentos específicos estabelecidos na nossa plataforma.

                8. Contacto: Se tiver dúvidas ou preocupações sobre estes termos e condições, entre em contacto connosco através dos canais de suporte disponíveis.

                Ao clicar em ""Registar"", confirma que leu, compreendeu e concorda com estes termos e condições.
                ";

            // Exibir os termos em uma MessageBox
            MessageBox.Show(termos, "Termos e Condições", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (previousForm != null && previousForm is Login)
            {
                this.Hide(); // Esconde o formulário atual (Register)
                previousForm.Show(); // Exibe o formulário anterior (Login)
            }
        }

        private void tb_pass2R_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            //tb_pass2R.Text = "Digite sua senha novamente";
            //tb_pass2R.ForeColor = SystemColors.GrayText; // Cor do texto cinza

            //tb_passR.Text = "Digite sua senha ";
            //tb_passR.ForeColor = SystemColors.GrayText; // Cor do texto cinza

            //tb_emailR.Text = "Digite o seu email";
            //tb_emailR.ForeColor = SystemColors.GrayText; // Cor do texto cinza

            //tb_userR.Text = "Digite o seu username";
            //tb_userR.ForeColor = SystemColors.GrayText; // Cor do texto cinza
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_userR.Text) || tb_userR.Text == "Digite o seu username" ||
                string.IsNullOrWhiteSpace(tb_emailR.Text) || tb_emailR.Text == "Digite o seu email" ||
                string.IsNullOrWhiteSpace(tb_passR.Text) || tb_passR.Text == "Digite sua senha" ||
                string.IsNullOrWhiteSpace(tb_pass2R.Text) || tb_pass2R.Text == "Digite sua senha novamente")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Verifica se a CheckBox está marcada
            if (!cb_termos.Checked)
            {
                MessageBox.Show("Você deve aceitar os termos e condições para se registrar.", "Termos e Condições", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }


            // Supõe que previousForm é uma instância de Login
            if (previousForm != null && previousForm is Login)
            {
                this.Hide(); 
                previousForm.Show();
            }
            else
            {
                // Se previousForm não está definido, criar uma nova instância de Login
                Login loginForm = new Login();
                loginForm.Show();
                this.Close(); 
            }
        }
    }
}
