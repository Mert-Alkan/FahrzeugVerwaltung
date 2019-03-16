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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.listBox1 != null)
            {

                // von dem was im Auto gespeichert wird ind die Fahrzeuliste speichern
                Fahrzeug auto = form3.listBox1.SelectedItem as Fahrzeug;
                ModellTextBox.Text = auto.MeinModell;
                HesterllerTextBox.Text = auto.MeinHersteller;
                KennzeichenTextBox.Text = auto.MeinKennzeichen;
                

                
            }


        }
    }
}