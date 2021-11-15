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

       public double totaal;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        List<string> Lijst = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            // de product en prijs invoeren komen in een string
            string Product = ProductInvoer.Text;
            string Prijs = PrijsInvoer.Text;
            PrijsInvoer.Text = "";
            // de prijs string wordt een double
            double getal = double.Parse(Prijs);
            // de double en de string komen in een list
            listBox1.Items.Add(Product + "\t\t\t" + Prijs);
            totaal += getal;
            vernieuwTotaal(totaal);
          
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // de verwijderde index wordt geselecteerd
            object verwijderen = listBox1.SelectedItem;
            // de object wordt naar een string veranderd
            string verwijderen2 = verwijderen.ToString();
            // de geselecteerde index string wordt uitgelezen
            string resultString = string.Join(string.Empty, System.Text.RegularExpressions.Regex.Matches(verwijderen2, @"\d+").OfType<System.Text.RegularExpressions.Match>().Select(m => m.Value));
            // de index wordt verwijderd vanuit de listbox
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
             // de resultaat string wordt omgezet naar een double 
            double mingetal = double.Parse(resultString);
            // het mingetal wordt van het totaal afgehaald 
             totaal -= mingetal;
            vernieuwTotaal(totaal);


        }

        private void vernieuwTotaal(double totaal)
        { 
            output.Text = totaal.ToString();
         }
         
         //made bij Matthias als je deze code kopieert ga je er mee akkoord dat jij plagiaat pleegt
       
       



    }
}
