using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Fahrzeug
{
    public partial class Form1 : Form
    {
        static public List<Fahrzeug> fahrzeugliste = new List<Fahrzeug>();
        
        public Form1()
        {
            InitializeComponent();
            FahrzeugListBox.DisplayMember = "GetFormatierteAusgabe";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            
        }
        //ruft form 2 auf und fügt die Datein in die Fahrzeugliste 
        private void Fahrzeug_Hinzufügen(object sender, EventArgs e)
        {
            
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                if(form2.Fahrzeug1 == null)  //weil der Wert nie null darf sein habe ich jetzt einfach eine messagebox bei null als Lösung hinzugefügt
                {
                    MessageBox.Show("Sie sind wieder im Hauptmenü");
                }
                else 
                fahrzeugliste.Add(form2.Fahrzeug1);
                try
                {
                   // Speichert die Daten Aus Fahrzeug1 in Fahrzeugliste
                    FahrzeugListBox.Items.Add(form2.Fahrzeug1);
                }
                catch (Exception)
                {
                    return;
                }    
            }

        }

        private void FahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FahrzeugListBox.SelectedItem != null)
            {

                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                Fahrzeug auto = FahrzeugListBox.SelectedItem as Fahrzeug;
                textBox1.Text = auto.MeinModell;
                textBox2.Text = auto.MeinKennzeichen;
                textBox3.Text = Convert.ToString(auto.MeinAnschaffungspreis);
                textBox4.Text = Convert.ToString(auto.MeineErstzulassung);
            }
        }
        // Es wird programmiert was passiert, wenn man auf den LöschButton klickt 
        private void LöschButton_Click(object sender, EventArgs e)
        {
            FahrzeugListBox.Items.Remove(FahrzeugListBox.SelectedItem);
            FahrzeugListBox.ClearSelected();
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
            if (FahrzeugListBox.SelectedItem != null)
            {
                (FahrzeugListBox.SelectedItem as Fahrzeug).MeinModell = textBox1.Text;
                (FahrzeugListBox.SelectedItem as Fahrzeug).MeinKennzeichen = textBox2.Text;
                (FahrzeugListBox.SelectedItem as Fahrzeug).MeinAnschaffungspreis = Convert.ToInt32(textBox3.Text);
                (FahrzeugListBox.SelectedItem as Fahrzeug).MeineErstzulassung = Convert.ToString(textBox4.Text);
            }
            FahrzeugListBox.DisplayMember = null;
            FahrzeugListBox.DisplayMember = "GetFormatierteAusgabe";
        }

        private void Suchen_Klick(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
            }
        }
    }
}
