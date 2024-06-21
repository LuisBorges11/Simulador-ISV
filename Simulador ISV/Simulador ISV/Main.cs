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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        

        private void bt_S_ISV_Click(object sender, EventArgs e)
        {

            Simulador simuladorForm = new Simulador();
            simuladorForm.ShowDialog();
            this.Hide();
        }



    }
}
