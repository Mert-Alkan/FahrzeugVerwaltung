using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Fahrzeug
{
    public partial class Hauptform : Form
    {

        public Parkpool Parkpool = new Parkpool();
        public Fahrzeugpool fahrzeugpool = new Fahrzeugpool();
        DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
        public Parkhaus Parkhaus1 = new Parkhaus();
        float tmpSteuer;
        CurrencyManager cmParkhaus;

        public Hauptform()
        {
            InitializeComponent();
            FahrzeugListBox.DisplayMember = "MeinKennzeichen";  //Diese Eigenschaft  soll in der fahrzeug liste angezigt werden
            GespeicherteFahrzeugeLaden();                       //Startet die methode 
            //Parkpool.parkhaus = dateinVerwaltung.ParkhäuserLaden();

        }

        void GespeicherteFahrzeugeLaden()
        {
            List<Fahrzeug> tmpList = dateinVerwaltung.FahrzeugeLaden();          //holt die daten aus  der tmpliste 

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

            fahrzeugpool.FahrzeugeLaden();
            Parkpool.ParkhäuserLaden();

            #region Parkhaus-Tab
            dataGridViewParkhäuser.DataSource = Parkpool.parkhaus;
            cmParkhaus = (CurrencyManager)dataGridViewParkhäuser.BindingContext[Parkpool.parkhaus];
            #endregion


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
            using (Suche suche = new Suche())
            {
                suche.ShowDialog();
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
                dateinVerwaltung.Speichern(Parkpool.parkhaus, fahrzeugpool.MeineFahrzeugListe);
            }
            catch (Exception)
            {


            }

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
            dateinVerwaltung.Speichern(Parkpool.parkhaus, fahrzeugpool.MeineFahrzeugListe);
        }

        private void Laden_Click(object sender, EventArgs e)
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
            dateinVerwaltung.FahrzeugeLaden();
            dateinVerwaltung.ParkhäuserLaden();
        }

        private void Schließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Speichere_Click(object sender, EventArgs e)
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();
            dateinVerwaltung.Speichern(Parkpool.parkhaus, fahrzeugpool.MeineFahrzeugListe);
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
            Parkpool.NeuesParkhaus(AdresseTextBox.Text, OrttxtBox.Text, PlzTextBox.Text,
                msdPKW.Text, msdLKW.Text, msdMotorrad.Text);


            AdresseTextBox.Clear();
            OrttxtBox.Clear();
            PlzTextBox.Clear();
            msdPKW.Clear();
            msdLKW.Clear();
            msdMotorrad.Clear();
            //damit die Daten angezeit werden
            cmParkhaus.Refresh();
            dateinVerwaltung.Speichern(Parkpool.parkhaus, fahrzeugpool.MeineFahrzeugListe);
        }
        private void TabPage2_Click(object sender, EventArgs e)
        {
          
        }
       
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SpielButton(object sender, EventArgs e)
        {
            TicTacToe5 tictactoe = new TicTacToe5();
            tictactoe.ShowDialog();
            
        }
    }
}
