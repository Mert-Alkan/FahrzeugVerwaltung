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
        public Parkhaus Parkhaus1 = new Parkhaus();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void HinzufügeButton(object sender, EventArgs e)
        {
            if (OrttxtBox.Text!="" && AdresseTextBox.Text!= "" && PlzTextBox.Text !="")
            {
                   
                    Parkhaus1.MeineAdresse = AdresseTextBox.Text;
                    Parkhaus1.Meinort = OrttxtBox.Text;
                    Parkhaus1.MeinPlz = PlzTextBox.Text;
                    Close();
            }
            else
            {
                MessageBox.Show("Sie müssen alle Felder ausfüllen");
            }
        }
    }
}
