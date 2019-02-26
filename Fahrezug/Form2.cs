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
        public Fahrzeug Fahrzeug { get; protected set; }
        public Form2()
        {
            InitializeComponent();
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        // Es wird Programmiert was passiert wenn man auf den Hinzufüge Button drückt

        private void Hinzufügen_Click(object sender, EventArgs e)
        {
                if (Hersteller.Text != "" && FahrzeugTextBox.Text == "PKW" && KennzeichenTextBox.Text != "" && AnschaffungspreisTextBox.Text != "" && ErstzulassungTextBox.Text != "")
                {
                    Fahrzeug = new PKW();
                    Fahrzeug.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug.MeinModell = ModellTextBox.Text;
                    Fahrzeug.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                else if (FahrzeugTextBox.Text=="LKW")
                {
                    Fahrzeug = new LKW();
                    Fahrzeug.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug.MeinModell = ModellTextBox.Text;
                    Fahrzeug.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                else if (FahrzeugTextBox.Text=="Motorrräder")
                {
                Fahrzeug = new Motorräder();
                    Fahrzeug.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug.MeinModell = ModellTextBox.Text;
                    Fahrzeug.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                
                this.Close();
        }
    }
}
