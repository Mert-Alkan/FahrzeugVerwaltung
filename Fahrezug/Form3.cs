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
    public partial class Form3 : Form
    {
        Fahrzeugpool Fahrzeugpool = new Fahrzeugpool();
        public Form3()
        {
            //Die daten der liste werden in die listbox hinzugefügt
            InitializeComponent();
            listBox1.DataSource = Fahrzeugpool.fahrzeugliste;
            listBox1.DisplayMember = "MeinKennzeichen";
            Form2 form2 = new Form2();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Suchen_Klick(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();

            for (int i = listBox1.Items.Count -1; i >= 0;i-- )
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(SuchtextBox.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }
            label2.Text = listBox1.SelectedItems.Count.ToString()+ "Kennzeichen wurde gefunden";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
