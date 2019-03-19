using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fahrzeug
{
    public class Fahrzeugpool
    {
        static public List<Fahrzeug> fahrzeugliste = new List<Fahrzeug>();
        
        public Fahrzeug Fahrzeug_Hinzufügen1()
        {

            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();
                if (form2.Fahrzeug1 == null)  //weil der Wert nie null darf sein habe ich jetzt einfach eine messagebox bei null als Lösung hinzugefügt
                {
                    MessageBox.Show("Sie sind wieder im Hauptmenü");
                }
                else
                    fahrzeugliste.Add(form2.Fahrzeug1);
                try
                {
                    // Speichert die Daten Aus Fahrzeug1 in Fahrzeugliste
                    //FahrzeugListBox.Items.Add(form2.Fahrzeug1);
                    return form2.Fahrzeug1;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public void Zurück(int index)
        {
            fahrzeugliste.RemoveAt(index);
        }
    }
}