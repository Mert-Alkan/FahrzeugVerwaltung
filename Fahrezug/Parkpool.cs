using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Fahrzeug
{
    public class Parkpool
    {
        public  int Stellplatz_Nr;
        List<Parkhaus> parkhaus = new List<Parkhaus>();
        public Parkpool()
        {
            
        }

        public void FahrzeugZuweisung()
        {
            throw new System.NotImplementedException();
        }
        public Parkhaus Parkhaus_Erstellen()
        {
            using (Form4 form4 = new Form4())
            {
                form4.ShowDialog();
                if (form4.Parkhaus1 == null)  //weil der Wert nie null darf sein habe ich jetzt einfach eine messagebox bei null als Lösung hinzugefügt
                {
                    MessageBox.Show("Sie sind wieder im Hauptmenü");
                }
                else
                    parkhaus.Add(form4.Parkhaus1);
                try
                {
                    return form4.Parkhaus1;
                }
                catch (Exception)
                {
                    return null;
                }

            }

        }
    }
}