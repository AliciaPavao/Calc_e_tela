using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_e_tela
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barra.Value = barra.Value + 1;


            if (barra.Value == 100)
            {

                carregando.Enabled = false;
                this.Hide();

                calculadora formCalculadora = new calculadora();
                formCalculadora.ShowDialog();

                calc_celcius formcalc_celcius = new calc_celcius();
                formcalc_celcius.ShowDialog();

                
            }

        }

        private void carregamento_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
