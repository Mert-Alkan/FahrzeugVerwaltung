using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Fahrzeug
{
    public partial class Form1 : Form
    {

        Fahrzeugpool fahrzeugpool = new Fahrzeugpool();
        public Form1()
        {
            InitializeComponent();
            FahrzeugListBox.DisplayMember = "MeinKennzeichen";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            
        }
        //ruft form 2 auf und fügt die Datein in die Fahrzeugliste 
      

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

            fahrzeugpool.Zurück(FahrzeugListBox.SelectedIndex);
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

        private void Berechne_Steuerschuld(object sender, EventArgs e)
        {
        
        }

        private void FahrzeugHinzufügen_Button_Click(object sender, EventArgs e)
        {

            
            
            FahrzeugListBox.Items.Add(fahrzeugpool.Fahrzeug_Hinzufügen1());
        }

        private void BtnParkhaus_erstellen(object sender, EventArgs e)
        {

        }
    }
}
