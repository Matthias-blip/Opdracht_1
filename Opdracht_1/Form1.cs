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

        List<string> MyList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            // de product en prijs invoeren komen in een string
            string Product = ProductInvoer.Text;
            string Prijs = PrijsInvoer.Text;
            // de prijs string wordt een double
            double getal = double.Parse(Prijs, System.Globalization.CultureInfo.InvariantCulture);
            double totaal = getal + getal;
            // de double en de string komen in een list
            listBox1.Items.Add(Product); 
            listBox1.Items.Add(Prijs);

            string y = totaal.ToString();
            textBox1.Text = y;



        }

     
    }
}
