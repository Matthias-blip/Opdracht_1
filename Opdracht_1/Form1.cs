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
            string Product = ProductInvoer.Text;
            string Prijs = PrijsInvoer.Text;
            List<string> Lijst = new List<string>();
            Lijst.Add(Product);
            Lijst.Add(Prijs);

            listBox1.DataSource = Lijst;
        }
    }
}
