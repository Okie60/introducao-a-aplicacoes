using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtValor1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double valor3 = Convert.ToDouble(txtValor3.Text);
            double maior = 0;
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            if (valor1 > valor2 && valor1 > valor3)
            {
                maior = valor1;
                lblSoma.Text = "O número " + maior.ToString() + " é maior";
            }else if (valor1 < valor2 && valor2 > valor3)
            {
                maior = valor2;
                lblSoma.Text = "O número " + maior.ToString() + " é maior";
            }else if (valor3 > valor1 && valor3 > valor2)
            {
                maior = valor3;
                lblSoma.Text = "O número " + maior.ToString() + " é maior";
            }
            else if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            {
                MessageBox.Show("Números iguais.", "Valores iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor1.Text = "";
                txtValor2.Text = "";
                txtValor3.Text = "";
                lblSoma.Text = "";
                txtValor1.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lable2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}