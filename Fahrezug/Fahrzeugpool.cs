using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fahrzeug
{
    [Serializable]
    public class Fahrzeugpool
    {
        static private List<Fahrzeug> fahrzeugliste = new List<Fahrzeug>();

        public List<Fahrzeug> MeineFahrzeugListe
        {
            get { return fahrzeugliste; }
            set { fahrzeugliste = value; }
        }

        public Fahrzeug Fahrzeug_Hinzufügen1(List<Parkhaus> parkhäuser)
        {
            using (FahrzeugHinzufügen form2 = new FahrzeugHinzufügen(parkhäuser))
            {
                form2.ShowDialog();
                if (form2.Fahrzeug1 != null)  
                {
                    fahrzeugliste.Add(form2.Fahrzeug1);
                }
                try
                {
                    return form2.Fahrzeug1;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public void Steuerschuld()
        {
            throw new System.NotImplementedException();
        }

        public void FahrzeugeLaden()
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();

            MeineFahrzeugListe = dateinVerwaltung.FahrzeugeLaden();
        }
    }
}