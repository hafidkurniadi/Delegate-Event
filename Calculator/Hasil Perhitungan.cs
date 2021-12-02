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
    public partial class Hasil_Perhitungan : Form
    {
        private List<CalculatorP> listDariHasil = new List<CalculatorP>();

        public Hasil_Perhitungan()
        {
            InitializeComponent();
            initialisasilvw();
        }

        private void initialisasilvw()
        {
            lvwHasil.View = View.Details;
            lvwHasil.Columns.Add("", 10, HorizontalAlignment.Left);
            lvwHasil.Columns.Add("", 200, HorizontalAlignment.Left);
        }

        private void Frmcalc_OnCalc(CalculatorP calc)
        {
            listDariHasil.Add(calc);

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(calc.Hasil);

            lvwHasil.Items.Add(item);
        }
        
        private void Hasil_Perhitungan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator("Calculator");
            calculator.OnCalc += Frmcalc_OnCalc;
            calculator.ShowDialog();
        }
    }
}