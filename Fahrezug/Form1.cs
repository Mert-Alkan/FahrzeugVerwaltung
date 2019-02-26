using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrezug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FahrzeugListe.DisplayMember = "MeinKennzeichen";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ruft Form2 Auf 
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                FahrzeugListe.Items.Add(form2.Fahrzeug); // Speichert die Daten Aus Fahrezug in Fahrzeugliste
            }
                    
        }

        private void FahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
