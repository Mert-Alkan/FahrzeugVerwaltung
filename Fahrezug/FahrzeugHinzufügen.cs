﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrzeug
{
    public partial class FahrzeugHinzufügen : Form
    {
        public Fahrzeug Fahrzeug1;
        List<Parkhaus> parkhäuser;
        public FahrzeugHinzufügen(List<Parkhaus> parks)
        {
            InitializeComponent();
            parkhäuser = parks;
        }
        //Eigenschfaten für die Klassen wurden hinzugefügt
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eigenschaften für LKW
            if(Fahrzeugcmbbx.SelectedItem.ToString() == "LKW")
            {
                tableLayoutPanel1.Controls.Add(ZuladungLabel,0,6);
                tableLayoutPanel1.Controls.Add(txtZuladung, 1, 6);
                tableLayoutPanel1.Controls.Add(AchsenAnzahlTextBox,1, 7);
                tableLayoutPanel1.Controls.Add(AnzahlAchsenLabel,0, 7);

                tableLayoutPanel1.Controls.Remove(HubTextBox);
                tableLayoutPanel1.Controls.Remove(HubraumLabel);
                tableLayoutPanel1.Controls.Remove(SchadstoffKlasseLabel);
                tableLayoutPanel1.Controls.Remove(SchadstoffKlasseText);
                tableLayoutPanel1.Controls.Remove(LeistungLabel);
                tableLayoutPanel1.Controls.Remove(LeistungTextBox);
            }

           //Eigenschaften für Die Klasse PKW werden Implemntiert
            if (Fahrzeugcmbbx.SelectedItem.ToString() == "PKW")
            {
                tableLayoutPanel1.Controls.Add(HubraumLabel, 0, 6);
                tableLayoutPanel1.Controls.Add(HubTextBox, 1, 6);
                tableLayoutPanel1.Controls.Add(LeistungLabel, 0,7);
                tableLayoutPanel1.Controls.Add(LeistungTextBox, 1, 7);
                tableLayoutPanel1.Controls.Add(SchadstoffKlasseLabel, 0, 6);
                tableLayoutPanel1.Controls.Add(SchadstoffKlasseText, 1, 6);
                tableLayoutPanel1.Controls.Add(LeistungLabel, 0, 7);
                tableLayoutPanel1.Controls.Add(LeistungTextBox, 1, 7);
                tableLayoutPanel1.Controls.Add(HubraumLabel, 0, 8);
                tableLayoutPanel1.Controls.Add(HubTextBox, 1, 8);

                tableLayoutPanel1.Controls.Remove(AnzahlAchsenLabel);
                tableLayoutPanel1.Controls.Remove(AchsenAnzahlTextBox);
                tableLayoutPanel1.Controls.Remove(ZuladungLabel);
                tableLayoutPanel1.Controls.Remove(txtZuladung);

                //Eigenschaften für Motorräder
            }
            if (Fahrzeugcmbbx.SelectedItem.ToString()=="Motorräder")
            {
                tableLayoutPanel1.Controls.Add(HubraumLabel, 0, 6);
                tableLayoutPanel1.Controls.Add(HubTextBox, 1,   6);

                tableLayoutPanel1.Controls.Remove(AnzahlAchsenLabel);
                tableLayoutPanel1.Controls.Remove(AchsenAnzahlTextBox);
                tableLayoutPanel1.Controls.Remove(ZuladungLabel);
                tableLayoutPanel1.Controls.Remove(txtZuladung);
                tableLayoutPanel1.Controls.Remove(SchadstoffKlasseLabel);
                tableLayoutPanel1.Controls.Remove(SchadstoffKlasseText);
                tableLayoutPanel1.Controls.Remove(LeistungLabel);
                tableLayoutPanel1.Controls.Remove(LeistungTextBox);
            }
        }

        // Es wird Programmiert was passiert wenn man auf den Hinzufüge Button drückt

        public void Hinzufügen_Click(object sender, EventArgs e)
        {
                if (Hersteller.Text != "" && Fahrzeugcmbbx.Text == "PKW" && KennzeichenTextBox.Text != "" && AnschaffungspreisTextBox.Text != "" && ErstzulassungTextBox.Text !=""&&Parkhaustext.Text!="" && ParkplatzText.Text!="" )
                {
                PKW pKW = new PKW();
                Fahrzeug1 = pKW;
                    pKW.MeinKennzeichen = KennzeichenTextBox.Text;
                    pKW.MeinModell = ModellTextBox.Text;
                    pKW.MeinHersteller = HerstellerTextBox.Text;
                    pKW.MeineErstzulassung = ErstzulassungTextBox.Text;
                    pKW.MeinFahrzeug = Fahrzeugcmbbx.Text;
                    pKW.MeinParkhaus = Parkhaustext.Text;
                try
                {
                    pKW.MeineParkplatz = Convert.ToInt32(ParkplatzText.Text);
                    pKW.MeineSchadStoffKlasse = Convert.ToInt32(SchadstoffKlasseText.Text);
                    pKW.MeinHubraum = Convert.ToInt32(HubTextBox.Text);
                    pKW.MeineLeistung = Convert.ToInt32(LeistungTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sie müssen Zahlen eventuell eingeben z.B Parkplatz");

                    return; throw;
                }
                }
                
                else if (Fahrzeugcmbbx.Text=="LKW")
                {
                LKW lKW = new LKW();
                Fahrzeug1 = lKW;
                   lKW.MeinKennzeichen = KennzeichenTextBox.Text;
                   lKW.MeinModell = ModellTextBox.Text;
                   lKW.MeinHersteller = HerstellerTextBox.Text;
                   lKW.MeineErstzulassung = ErstzulassungTextBox.Text;
                   lKW.MeinFahrzeug = Fahrzeugcmbbx.Text;
                   lKW.MeinParkhaus = Parkhaustext.Text;
                try
                {
                    lKW.MeineParkplatz = Convert.ToInt32(ParkplatzText.Text);
                    lKW.MeineZuladung =Convert.ToInt32(txtZuladung.Text);
                    lKW.MeineAchsen = AchsenAnzahlTextBox.Text;
                    lKW.MeinAnschaffungspreis = Convert.ToInt32(AnschaffungspreisTextBox.Text);
                }
                catch (Exception)
                {
                     MessageBox.Show("Sie müssen Zahlen eingeben bei den Achsen, beim Anschaffungpreis und der Zuladung Zahlen Angeben und beim parkplatz auch");
                     return;  throw;
                }
                    
                }
                else if (Fahrzeugcmbbx.Text=="Motorräder")
                {
                Motorräder motorräder = new Motorräder();
                Fahrzeug1 = motorräder;
                    motorräder.MeinKennzeichen = KennzeichenTextBox.Text;
                    motorräder.MeinModell = ModellTextBox.Text;
                    motorräder.MeinHersteller = HerstellerTextBox.Text;
                    motorräder.MeineErstzulassung = ErstzulassungTextBox.Text;
                    motorräder.MeinFahrzeug = Fahrzeugcmbbx.Text;
                    motorräder.MeinParkhaus = Parkhaustext.Text;

                try
                {
                    motorräder.MeineParkplatz = Convert.ToInt32(ParkplatzText.Text);
                    motorräder.MeineHubraume = Convert.ToInt32(HubTextBox.Text);
                    motorräder.MeinAnschaffungspreis = Convert.ToInt32(AnschaffungspreisTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sie dürfen nur Zahlen im dem text Feld Hubraum,parkplatz und im Feld Anschaffungspreis angeben");
                    return; throw;
                }
                }
                else
                {
                MessageBox.Show("Sie müssen alle Felder ausfüllen, wiederholen Sie den Vorgang");
                return;
                }
                
                this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Füllenundleeren();


            
            for (int i = 0; i < parkhäuser.Count; i++)
            {
                Parkhaustext.Items.Add(parkhäuser[i].Adresse);
            }
            if (parkhäuser.Count != -1)
            {
                Parkhaustext.SelectedIndex = 0;
            }

        }

        void Füllenundleeren()
        {
            tableLayoutPanel1.Controls.Remove(txtZuladung);
            tableLayoutPanel1.Controls.Remove(HubraumLabel);
            tableLayoutPanel1.Controls.Remove(ZuladungLabel);
            tableLayoutPanel1.Controls.Remove(SchadstoffKlasseLabel);
            tableLayoutPanel1.Controls.Remove(AnzahlAchsenLabel);
            tableLayoutPanel1.Controls.Remove(AchsenAnzahlTextBox);
            tableLayoutPanel1.Controls.Remove(LeistungLabel);
            tableLayoutPanel1.Controls.Remove(LeistungTextBox);
            tableLayoutPanel1.Controls.Remove(HubTextBox);
            tableLayoutPanel1.Controls.Remove(SchadstoffKlasseText);

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParkplatzText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
