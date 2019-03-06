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
            FahrzeugListe.DisplayMember = "GetFormatierteAusgabe";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            
        }
        //ruft form 2 auf und fügt die Datein in die Fahrzeugliste 
        private void Button1_Click(object sender, EventArgs e)
        {
            
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                if(form2.Fahrzeug1 == null)  //weil der Wer nie null darf sein habe ich jetzt einfach eine messagebox bei null als Lösung hinzugefügt
                {
                    MessageBox.Show("Sie sind wieder im Hauptmenü");
                }
                else 
                FahrzeugListe.Items.Add(form2.Fahrzeug1); // Speichert die Daten Aus Fahrzeug1 in Fahrzeugliste
            }
          
        }

        private void FahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FahrzeugListe.SelectedItem != null)
            {

                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                Fahrzeug auto = FahrzeugListe.SelectedItem as Fahrzeug;
                textBox1.Text = auto.MeinModell;
                textBox2.Text = auto.MeinKennzeichen;
                textBox3.Text = Convert.ToString(auto.MeinAnschaffungspreis);
                textBox4.Text = Convert.ToString(auto.MeineErstzulassung);
            }
        }
        // Es wird programmiert was passiert, wenn man auf den LöschButton klickt 
        private void LöschButton_Click(object sender, EventArgs e)
        {
            FahrzeugListe.Items.Remove(FahrzeugListe.SelectedItem);
            FahrzeugListe.ClearSelected();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // Es wird Programmiert was passiert wenn man auf den Bearbeiten Button drückt
        private void Bearbeiten_Button(object sender, EventArgs e)
        {
            if (FahrzeugListe.SelectedItem != null)
            {
                (FahrzeugListe.SelectedItem as Fahrzeug).MeinModell = textBox1.Text;
                (FahrzeugListe.SelectedItem as Fahrzeug).MeinKennzeichen = textBox2.Text;
                (FahrzeugListe.SelectedItem as Fahrzeug).MeinAnschaffungspreis = Convert.ToInt32(textBox3.Text);
                (FahrzeugListe.SelectedItem as Fahrzeug).MeineErstzulassung = Convert.ToString(textBox4.Text);
            }
            FahrzeugListe.DisplayMember = null;
            FahrzeugListe.DisplayMember = "GetFormatierteAusgabe";
        }
    }
}
