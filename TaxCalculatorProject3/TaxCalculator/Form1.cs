using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxModel;

namespace TaxCalculator
{
    public partial class TaxCalculator : Form
    {
        public TaxCalculator()
        {
            InitializeComponent();
        }

        string path = "../../tax_table_1.txt";
        
        private void button1_Click(object sender, EventArgs e)
        {
            TaxTable txtb = new TaxTable(path);
            double inc = double.Parse(income.Text);
            string tax = string.Format("{0:c}", txtb.computeTax(inc));
            ComputedTax.Text = tax;
            FileLocation.Text = "Tax table file path is " + path;
        }
    }
}
