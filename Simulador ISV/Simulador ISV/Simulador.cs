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
    public partial class Simulador : Form
    {
        public Simulador()
        {
            InitializeComponent();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void tb_co2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_co2.Text, out int co2))
            {
                // Verifica se o valor está dentro do intervalo permitido
                if (co2 >= 0 && co2 <= 500)
                {
                    if (co2 >= 15)
                    {
                        // Mostrar panel6
                        panel6.Visible = true;
                    }
                    else
                    {
                        // Ocultar panel6
                        panel6.Visible = false;
                    }

                    if (co2 >= 5)
                    {
                        // Mostrar panel3, panel4, e panel5
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                    }
                    else
                    {
                        // Ocultar panel3, panel4, e panel5
                        panel3.Visible = false;
                        panel4.Visible = false;
                        panel5.Visible = false;
                    }
                }
                else
                {
                    // Se o valor estiver fora do intervalo permitido, ocultar todos os painéis
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    panel6.Visible = false;
                }
            }
            else
            {
                // Caso tb_co2 não seja um número válido ou esteja vazia, ocultar todos os painéis
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
            }
        }

        private void tb_cilindrada_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_cilindrada.Text, out int cilindrada))
            {
                if (cilindrada >= 200)
                {
                    // Mostrar panel2 e ocultar panel1
                    panel1.Visible = true;
                    panel2.Visible = true;
                }
                else if (cilindrada >= 100 && cilindrada < 200)
                {
                    // Mostrar panel1 e ocultar panel2
                    panel1.Visible = true;
                    panel2.Visible = false;
                }
                else
                {
                    // Se cilindrada < 100, você pode escolher mostrar ou ocultar ambos os painéis
                    panel1.Visible = true;
                    panel2.Visible = false;
                }
            }
            else
            {
                // Caso tb_cilindrada não seja um número válido ou esteja vazia
                // Mostrar panel1 e ocultar panel2
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void tb_cilindrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_co2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
