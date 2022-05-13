using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAppCalc : Form
    {
        public FrmAppCalc()
        {
            InitializeComponent();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou AC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou -");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou +");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Caixa de texto");
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou +/-");
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou %");
        }

        private void btnDividido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou ÷");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 7");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 9");
        }

        private void btnVezez_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou X");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou 0");
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou ,");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digitou =");
        }

        private void FrmAppCalc_Load(object sender, EventArgs e)
        {

        }
    }
}
