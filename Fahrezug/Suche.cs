using System;
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
    public partial class Suche : Form
    {
        Fahrzeugpool Fahrzeugpool = new Fahrzeugpool();
        List<int> Ergebnisse = new List<int>();
        int ausgewähltesFahrzeug;

        public Suche()
        {
            //Die daten der liste werden in die listbox hinzugefügt
            InitializeComponent();
            listBox1.DataSource = Fahrzeugpool.MeineFahrzeugListe;
            listBox1.DisplayMember = "MeinKennzeichen";

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Suchen_Klick(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  Form4 form4 = new Form4();
          //  form4.ShowDialog();
           
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Ergebnisse.Clear();
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                if (Fahrzeugpool.MeineFahrzeugListe[i].MeinKennzeichen.ToString().ToLower().Contains(SuchtextBox.Text.ToLower()))
                {
                    Ergebnisse.Add(i);
                }
                
            }
            if (Ergebnisse.Count != -1)
            {
                try
                {
                    listBox1.SelectedIndex = Ergebnisse[0];         //Wählt das erste suchergebniss aus
                    ausgewähltesFahrzeug = 0;
                }
                catch (Exception)
                {
                }

            }
            label2.Text = Ergebnisse.Count + " Kennzeichen wurde gefunden";
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            // Wird beim drücken der enter taste ausgeführt
            if(e.KeyCode == Keys.Enter)                              
            {
                try
                {
                    if (ausgewähltesFahrzeug >= Ergebnisse.Count - 1)
                    {
                        ausgewähltesFahrzeug = 0;
                        listBox1.SelectedIndex = Ergebnisse[ausgewähltesFahrzeug];          // Wählt das erste Ergebnis an falls das letzte schon angewählt war
                    }
                    else
                    {
                        listBox1.SelectedIndex = Ergebnisse[ausgewähltesFahrzeug + 1];
                        ausgewähltesFahrzeug++;
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
