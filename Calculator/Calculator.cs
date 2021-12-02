using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public delegate void EventHandler(CalculatorP calc);
        public event EventHandler OnCalc;

        private CalculatorP calc;
        public Calculator()
        {
            InitializeComponent();
        }

        public Calculator(string title) : this()
        {
            this.Text = title;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            calc = new CalculatorP();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);

            if (cmbO.Text == "Penjumlahan")
                calc.Hasil = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);

            if (cmbO.Text == "Pengurangan")
                calc.Hasil = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);

            if (cmbO.Text == "Perkalian")
                calc.Hasil = string.Format("Hasil Perkalian {0} * {1} = {2}", a, b, a * b);

            if (cmbO.Text == "Pembagian")
                calc.Hasil = string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, a / b);

            OnCalc(calc);
            txtNilaiA.Clear();
            txtNilaiB.Clear();
            txtNilaiA.Focus();
        }
    }
}
