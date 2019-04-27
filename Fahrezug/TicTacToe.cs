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
    public partial class TicTacToe5 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public TicTacToe5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void SchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
                b.Text = "0";
           
            turn = !turn;

            turn_count++;
            b.Enabled = false;
            Gewinner();
        }

        private void Gewinner()
        {
            //Horizontal 
            bool da_ist_ein_gewinner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                da_ist_ein_gewinner = true;
           else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
                da_ist_ein_gewinner = true;
           else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                da_ist_ein_gewinner = true;
            //Vertikal
           else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                da_ist_ein_gewinner = true;
           else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                da_ist_ein_gewinner = true;
           else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                da_ist_ein_gewinner = true;
            //Diagonal
           else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                da_ist_ein_gewinner = true;
           else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                da_ist_ein_gewinner = true;
         

            if (da_ist_ein_gewinner)
            {
                VerschwindenButton();
                String Gewinner = "";
                if (turn)
                {
                    Gewinner = "0";
                }
                else
                    Gewinner = "X";
                MessageBox.Show(Gewinner + "hat gewonnen!");
            }
            else
            {
                if (turn_count == 9)
                MessageBox.Show("Unentschieden,");
            }
        }

        private void VerschwindenButton()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
           
        }

        private void NeuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { } 
        }
    }
}
