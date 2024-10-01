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
    public partial class calculadora : Form
    {

        float valor1 = 0;
        string operacao = "";

        public calculadora()
        {
            InitializeComponent();
        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "7";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "1";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "9";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "6";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "3";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text + "0";
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txt_visor.Text);
            operacao = "soma";
            txt_visor.Clear();
        }

        private void btn_divisao_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txt_visor.Text);
            operacao = "divisao";
            txt_visor.Clear();
        }

        private void btn_vezes_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txt_visor.Text);
            operacao = "multiplicacao";
            txt_visor.Clear();
        }

        private void btn_menos_Click_1(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txt_visor.Text);
            operacao = "subtracao";
            txt_visor.Clear();
        }

        private void btn_apaga_Click(object sender, EventArgs e)
        {
            txt_visor.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (this.operacao)
            {
                case "soma":
                    txt_visor.Text = Convert.ToString(valor1 + Convert.ToSingle(txt_visor.Text)); break;

                case "subtracao":
                    txt_visor.Text = Convert.ToString(valor1 - Convert.ToSingle(txt_visor.Text)); break;

                case "multiplicacao":
                    txt_visor.Text = Convert.ToString(valor1 * Convert.ToSingle(txt_visor.Text)); break;

                case "divisao":
                    txt_visor.Text = Convert.ToString(valor1 / Convert.ToSingle(txt_visor.Text)); break;
            }

        }

        private void txt_visor_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_medidas_Click(object sender, EventArgs e)
        {
            calc_celcius formcalc_celcius = new calc_celcius();
            formcalc_celcius.ShowDialog();
        }
    }

}