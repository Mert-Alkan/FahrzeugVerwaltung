using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Fahrzeug
{
    public partial class Form1 : Form
    {
        float tmpSteuer;
        public   Parkpool Parkpool = new Parkpool();
        Fahrzeugpool fahrzeugpool = new Fahrzeugpool();

        

        public Form1()
        {
            InitializeComponent();
            FahrzeugListBox.DisplayMember = "MeinKennzeichen";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            
        }
        //ruft form 2 auf und fügt die Datein in die FahrzeuglistBox
        private void FahrzeugListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is LKW)
            {
                HubText.Clear();
                Leistungstext.Clear();
                SchadstoffklasseTextBox.Clear();

                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                LKW LKW = FahrzeugListBox.SelectedItem as LKW;
                    textBox1.Text = LKW.MeinModell;
                    textBox2.Text = LKW.MeinKennzeichen;
                    textBox3.Text = Convert.ToString(LKW.MeinAnschaffungspreis);
                    textBox4.Text = Convert.ToString(LKW.MeineErstzulassung);
                    AchsenTextBox.Text = LKW.MeineAchsen;
                    ZuladungTextBox.Text =Convert.ToString(LKW.MeineZuladung);
                    SteuertextBox.Text = Convert.ToString(LKW.Steuerschuld);

                ;            }
            if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is PKW)
            {
                AchsenTextBox.Clear();
                ZuladungTextBox.Clear();

                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                PKW PKW = FahrzeugListBox.SelectedItem as PKW;
                textBox1.Text = PKW.MeinModell;
                textBox2.Text = PKW.MeinKennzeichen;
                textBox3.Text = Convert.ToString(PKW.MeinAnschaffungspreis);
                textBox4.Text = Convert.ToString(PKW.MeineErstzulassung);
                HubText.Text =Convert.ToString(PKW.MeinHubraum);
                Leistungstext.Text = Convert.ToString(PKW.MeineLeistung);
                SchadstoffklasseTextBox.Text = Convert.ToString(PKW.MeineSchadStoffKlasse);
                SteuertextBox.Text = Convert.ToString(PKW.Steuerschuld);
            }
            if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is Motorräder)
            {
                AchsenTextBox.Clear();       Leistungstext.Clear();
                ZuladungTextBox.Clear();     SchadstoffklasseTextBox.Clear();
              
               
                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                Motorräder motorräder = FahrzeugListBox.SelectedItem as Motorräder;
                textBox1.Text = motorräder.MeinModell;
                textBox2.Text = motorräder.MeinKennzeichen;
                textBox3.Text = Convert.ToString(motorräder.MeinAnschaffungspreis);
                textBox4.Text = Convert.ToString(motorräder.MeineErstzulassung);
                HubText.Text = Convert.ToString(motorräder.MeineHubraume);
                SteuertextBox.Text = Convert.ToString(motorräder.Steuerschuld);
                
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
            if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is LKW)
            {
                (FahrzeugListBox.SelectedItem as LKW).MeinModell = textBox1.Text;
                (FahrzeugListBox.SelectedItem as LKW).MeinKennzeichen = textBox2.Text;
                (FahrzeugListBox.SelectedItem as LKW).MeinAnschaffungspreis = Convert.ToInt32(textBox3.Text);
                (FahrzeugListBox.SelectedItem as LKW).MeineErstzulassung = Convert.ToString(textBox4.Text);
                (FahrzeugListBox.SelectedItem as LKW).MeineAchsen = AchsenTextBox.Text;
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
           foreach (Fahrzeug f in Fahrzeugpool.fahrzeugliste)    
            {
                tmpSteuer += f.Steuerschuld;
            }
            MessageBox.Show(tmpSteuer.ToString(), "Steuerschuld für Alle Fahrzeuge", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //von Mikail hilfe

        private void FahrzeugHinzufügen_Button_Click(object sender, EventArgs e)
        {
                FahrzeugListBox.Items.Add(fahrzeugpool.Fahrzeug_Hinzufügen1());
        }

        private void  BtnParkhausHinzufügen_Button_Click(object sender, EventArgs e)
        {
            
                FahrzeugListBox.Items.Add(Parkpool.Parkhaus_Hinzufügen1());
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
