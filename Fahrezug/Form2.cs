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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        //Hinzufügen in die Liste 

        private void Hinzufügen_Click(object sender, EventArgs e)
        {
            if (Hersteller.Text != "" && FahrzeugTextBox.Text != "PKW" && KennzeichenTextBox.Text != "" && AnschaffungspreisTextBox.Text != "" && ErstzulassungTextBox.Text!="")
            {
                Fahrzeug fahrzeug1 = new PKW();

                fahrzeug1.MeinKennzeichen    = Convert.ToInt32(KennzeichenTextBox.Text);
                fahrzeug1.MeinModell         = ModellTextBox.Text;
                fahrzeug1.MeinHersteller     = HerstellerTextBox.Text;
                fahrzeug1.MeineErstzulassung = ErstzulassungTextBox.Text;
                fahrzeug1.MeinFahrzeug       = FahrzeugTextBox.Text;

                
                this.Close();
            }

        }
    }
}
