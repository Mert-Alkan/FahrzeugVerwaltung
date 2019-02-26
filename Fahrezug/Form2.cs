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
        public Fahrzeug Fahrzeug1 { get; protected set; }
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
                    Fahrzeug1 = new PKW();
                    Fahrzeug1.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug1.MeinModell = ModellTextBox.Text;
                    Fahrzeug1.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug1.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug1.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                else if (FahrzeugTextBox.Text=="LKW")
                {
                    Fahrzeug1 = new LKW();
                    Fahrzeug1.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug1.MeinModell = ModellTextBox.Text;
                    Fahrzeug1.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug1.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug1.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                else if (FahrzeugTextBox.Text=="Motorrräder")
                {
                Fahrzeug1 = new Motorräder();
                    Fahrzeug1.MeinKennzeichen = KennzeichenTextBox.Text;
                    Fahrzeug1.MeinModell = ModellTextBox.Text;
                    Fahrzeug1.MeinHersteller = HerstellerTextBox.Text;
                    Fahrzeug1.MeineErstzulassung = ErstzulassungTextBox.Text;
                    Fahrzeug1.MeinFahrzeug = FahrzeugTextBox.Text;
                }
                else
                {
                MessageBox.Show("Sie müssen alle Felder ausfüllen, wiederholen Sie den Vorgang");
                return;
                }
                
                this.Close();
        }
    }
}
