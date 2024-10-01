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
    public partial class calc_celcius : Form
    {
        double celcius = 0;
        float fahren = 0;
        public calc_celcius()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado = celcius * 1.8 + 32;
            txt_calc.Text = resultado.ToString();

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_calc.Clear();
        }

        private void txt_calc_TextChanged_1(object sender, EventArgs e)
        {
            celcius = Convert.ToSingle(txt_calc.Text);
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
