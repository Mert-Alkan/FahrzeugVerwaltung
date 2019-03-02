using System;
using System.Windows.Forms;
using System.IO;

namespace Fahrzeug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FahrzeugListe.DisplayMember = "MeinKennzeichen";  //Diese Eigenschaft MeinKennzeichen soll in der fahrzeug liste angezigt werden
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ruft Form2 Auf 
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                if(form2.Fahrzeug1 == null)  //Fehler wurde behoben damit nicht nichts gespeichert werden kann in Fahrzeug1
                {
                    MessageBox.Show("Sie sind wieder im Hauptmenü");
                }
                else 
                FahrzeugListe.Items.Add(form2.Fahrzeug1); // Speichert die Daten Aus Fahrzeug1 in Fahrzeugliste
            }
                    
        }

        private void FahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LöschButton_Click(object sender, EventArgs e)
        {
            FahrzeugListe.Items.Remove(FahrzeugListe.SelectedItem);

        }

        private void SpeicherButton_Click(object sender, EventArgs e)
        {
         //   string sFahrzeugDatei = @"..\..\Fahrzeug.txt"; //Speichern der Fahrzeuge!
           // string sParkplatzDatei = @"..\..\Parkplatz.txt";     //Speichern der Parkplätze! 

          //  StreamWriter swFDaten = new StreamWriter(sFahrzeugDatei);
         //   StreamWriter swPDaten = new StreamWriter(sParkplatzDatei);

       
        }
    }
}
