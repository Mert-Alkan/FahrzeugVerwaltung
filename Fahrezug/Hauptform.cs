using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Fahrzeug
{
    public partial class Form1 : Form
    {

        public Parkpool Parkpool = new Parkpool();
        public Fahrzeugpool fahrzeugpool = new Fahrzeugpool();
        DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
        public Parkhaus Parkhaus1 = new Parkhaus();
        float tmpSteuer;
        CurrencyManager cmParkhaus;

        public Form1()
        {
            InitializeComponent();
            FahrzeugListBox.DisplayMember = "MeinKennzeichen";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            GespeicherteFahrzeugeLaden();                       //Startet die methode 

            #region Parkhaus-Tab
            dataGridViewParkhäuser.DataSource = Parkpool.parkhaus;
            cmParkhaus = (CurrencyManager)dataGridViewParkhäuser.BindingContext[Parkpool.parkhaus];
            #endregion

        }

        void GespeicherteFahrzeugeLaden()
        {
            List<Fahrzeug> tmpList = dateinVerwaltung.Laden();          //holt die daten aus  der tmpliste 

            foreach (Fahrzeug f in tmpList)
            {
                FahrzeugListBox.Items.Add(f);                       //fügt die Daten von f in die listbox ein
            }
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
                AchsenTextBox.Text =Convert.ToString(LKW.MeineAchsen);
                ZuladungTextBox.Text = Convert.ToString(LKW.MeineZuladung);
                SteuertextBox.Text = Convert.ToString(LKW.Steuerschuld);
                textBox6.Text = LKW.MeinParkhaus;
                textBox7.Text = Convert.ToString(LKW.MeineParkplatz);
            }
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
                HubText.Text = Convert.ToString(PKW.MeinHubraum);
                Leistungstext.Text = Convert.ToString(PKW.MeineLeistung);
                SchadstoffklasseTextBox.Text = Convert.ToString(PKW.MeineSchadStoffKlasse);
                SteuertextBox.Text = Convert.ToString(PKW.Steuerschuld);
                textBox6.Text = PKW.MeinParkhaus;
                textBox7.Text = Convert.ToString(PKW.MeineParkplatz);
            }
            if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is Motorräder)
            {
                AchsenTextBox.Clear(); Leistungstext.Clear();
                ZuladungTextBox.Clear(); SchadstoffklasseTextBox.Clear();


                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                Motorräder motorräder = FahrzeugListBox.SelectedItem as Motorräder;
                textBox1.Text = motorräder.MeinModell;
                textBox2.Text = motorräder.MeinKennzeichen;
                textBox3.Text = Convert.ToString(motorräder.MeinAnschaffungspreis);
                textBox4.Text = Convert.ToString(motorräder.MeineErstzulassung);
                HubText.Text = Convert.ToString(motorräder.MeineHubraume);
                SteuertextBox.Text = Convert.ToString(motorräder.Steuerschuld);
                textBox6.Text = motorräder.MeinParkhaus;
                textBox7.Text = Convert.ToString(motorräder.MeineParkplatz);
            }
        }
        // Es wird programmiert was passiert, wenn man auf den LöschButton klickt 
        private void LöschButton_Click(object sender, EventArgs e)
        {
            if (FahrzeugListBox.SelectedItem != null)
            {
                fahrzeugpool.MeineFahrzeugListe.RemoveAt(FahrzeugListBox.SelectedIndex);
            }
            FahrzeugListBox.Items.Remove(FahrzeugListBox.SelectedItem);
            FahrzeugListBox.ClearSelected();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            HubText.Clear();
            SchadstoffklasseTextBox.Clear();
            Leistungstext.Clear();
            AchsenTextBox.Clear();  
            SteuertextBox.Clear();
            ZuladungTextBox.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            FahrzeugBeispiell();
         //   HinzufügenStandardFahrzeuge(); ist auskommentiert, weil die methode nur einmal aufgerufen werden soll. Damit die Beispiel daten nicht immer erneut geladen und gespeichert werden
        }
        // Es wird Programmiert was passiert wenn man auf den Bearbeiten Button drückt  //geht nicht mehr 
        private void Bearbeiten_Button(object sender, EventArgs e)
        {
            //    if (FahrzeugListBox.SelectedItem != null && FahrzeugListBox.SelectedItem is Fahrzeug)
            //    {
            //        (FahrzeugListBox.SelectedItem as Fahrzeug).MeinModell = textBox1.Text;
            //       (FahrzeugListBox.SelectedItem as Fahrzeug).MeinKennzeichen = textBox2.Text;
            //      (FahrzeugListBox.SelectedItem as Fahrzeug).MeinAnschaffungspreis = Convert.ToInt32(textBox3.Text);
            //     (FahrzeugListBox.SelectedItem as Fahrzeug).MeineErstzulassung = Convert.ToString(textBox4.Text);
            //  }
            //  FahrzeugListBox.DisplayMember = null;
            // FahrzeugListBox.DisplayMember = "GetFormatierteAusgabe";
        }

        private void Suchen_Klick(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
            }
        }
        private void Berechne_Steuerschuld(object sender, EventArgs e)  //hilfe von Mikail
        {
            foreach (Fahrzeug f in fahrzeugpool.MeineFahrzeugListe)  //für jedes fahrzeug soll er die steuerschul berechnen von der liste meinefarhzeugliste
            {
                tmpSteuer += f.Steuerschuld;
            }
            MessageBox.Show(tmpSteuer.ToString(), "Steuerschuld für Alle Fahrzeuge", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FahrzeugHinzufügen_Button_Click(object sender, EventArgs e)
        {
            //TODO Fehler abfangen
            try
            {
                FahrzeugListBox.Items.Add(fahrzeugpool.Fahrzeug_Hinzufügen1(Parkpool.parkhaus));
                DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
                dateinVerwaltung.Speichern();
            }
            catch (Exception)
            {


            }

        }

        private void BtnParkhausHinzufügen_Button_Click(object sender, EventArgs e)
        {

            FahrzeugListBox.Items.Add(Parkpool.Parkhaus_Hinzufügen1());

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void BeispielDaten()
        {
            //nur für mich 
        }
        private void Speichern_Click(object sender, EventArgs e)
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
            dateinVerwaltung.Speichern();
        }

        private void Laden_Click(object sender, EventArgs e)
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
            dateinVerwaltung.Laden();
        }

        private void Schließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Speichere_Click(object sender, EventArgs e)
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
            dateinVerwaltung.Speichern();
        }

        private void Schließe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        private void HinzufügeButton(object sender, EventArgs e)
        {
            Parkpool.parkhaus.Add(new Parkhaus());
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Adresse= AdresseTextBox.Text;
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Ort= OrttxtBox.Text;
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Postleitzahl= PlzTextBox.Text;
            //Fügt die Stellplätze in die List hinzu
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListPKW(Convert.ToInt32(msdPKW.Text));
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListLKW(Convert.ToInt32(msdLKW.Text));
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListMotorrad(Convert.ToInt32(msdMotorrad.Text));

            AdresseTextBox.Clear();
            OrttxtBox.Clear();
            PlzTextBox.Clear();
            msdPKW.Clear();
            msdLKW.Clear();
            msdMotorrad.Clear();
            //damit die Daten angezeit werden
            cmParkhaus.Refresh();
        }
        private void TabPage2_Click(object sender, EventArgs e)
        {
          
        }
       
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void FahrzeugBeispiell()
        {
            //Parkhaus1(Ort, Plz, Straße): Köln, 51105, Westerwaldstr. 99
            Parkpool.parkhaus.Add(new Parkhaus());
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Ort = "Köln";
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Postleitzahl = "51105";
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].Adresse= "Westerwaldstr. 99";
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListPKW(98);
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListLKW(98);
            Parkpool.parkhaus[Parkpool.parkhaus.Count - 1].FüllenListMotorrad(98);
        }
        private void HinzufügenStandardFahrzeuge()
        {
                Fahrzeug fahrzeug;
                 //PKWs
                fahrzeug = new PKW();
                fahrzeugpool.MeineFahrzeugListe.Add(fahrzeug);
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinFahrzeug = "PKW";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinAnschaffungspreis = 9999;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineErstzulassung = "1965";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinHersteller = "VW";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinKennzeichen = "K-GS-01";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinModell = "Käfer";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinParkhaus = "1";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineParkplatz = 100;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeinHubraum = 1000;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineLeistung = 30;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineSchadStoffKlasse = 1;
                 
                fahrzeug = new PKW();
                fahrzeugpool.MeineFahrzeugListe.Add(fahrzeug);
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinFahrzeug = "PKW";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinAnschaffungspreis = 12000;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineErstzulassung = "1964";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinHersteller = "Opel";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinKennzeichen = "K-GS-02";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinModell = "Kadett";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinParkhaus = "1";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineParkplatz = 101;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeinHubraum = 1600;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineLeistung = 60;
                ((PKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineSchadStoffKlasse = 2;
                //Motorrad
                fahrzeug = new Motorräder();
                fahrzeugpool.MeineFahrzeugListe.Add(fahrzeug);
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinFahrzeug = "Motorrad";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinAnschaffungspreis = 6000;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineErstzulassung = "1999";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinHersteller = "BMW";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinParkhaus = "1";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineParkplatz = 200;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinKennzeichen = "K-GS-03";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinModell = "R1200r";
                ((Motorräder)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineHubraume = 1170;
                //LKW
                fahrzeug = new LKW();
                fahrzeugpool.MeineFahrzeugListe.Add(fahrzeug);
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinFahrzeug = "LKW";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinAnschaffungspreis = 23000;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineErstzulassung = "1960";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinHersteller = "Mercedes";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinParkhaus = "1";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeineParkplatz = 300;
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinKennzeichen = "K-GS-04";
                fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1].MeinModell = "LG 315";
                ((LKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineZuladung = 5500;
                ((LKW)fahrzeugpool.MeineFahrzeugListe[fahrzeugpool.MeineFahrzeugListe.Count - 1]).MeineAchsen = "2";

                foreach (Fahrzeug f in fahrzeugpool.MeineFahrzeugListe)
                {
                    FahrzeugListBox.Items.Add(f);                       //fügt die Daten von f in die listbox ein
                }
               
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SpielButton(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
            
        }
    }
}
