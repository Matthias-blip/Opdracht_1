using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // de product en prijs invoeren komen in een string
            string Product = ProductInvoer.Text;
            string Prijs = PrijsInvoer.Text;
            double getal = double.Parse(Prijs, System.Globalization.CultureInfo.InvariantCulture);
            List<Tuple<double, string>> Lijst = new List<Tuple<double, string>>();
            Lijst.Add(new Tuple<double, string>(getal, Product));

            listBox1.DataSource = Lijst;
        }
    }
}
