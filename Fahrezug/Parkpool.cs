using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Fahrzeug
{
    [Serializable]
    public class Parkpool
    {
        public  int Stellplatz_Nr;
        public List<Parkhaus> parkhaus = new List<Parkhaus>();

        public Parkpool()
        {
            
        }

        public void FahrzeugZuweisung()
        {
            throw new System.NotImplementedException();
        }

        public void ParkhäuserLaden()
        {
            DateinVerwaltung dateinVerwaltung = new DateinVerwaltung();

            parkhaus = dateinVerwaltung.ParkhäuserLaden();
        }
        public void NeuesParkhaus(string adresse, string ort, string plz, string msdPKW, string msdLKW, string msdMotorrad)
        {
            parkhaus.Add(new Parkhaus());
            parkhaus[parkhaus.Count - 1].Adresse = adresse;
            parkhaus[parkhaus.Count - 1].Ort = ort;
            parkhaus[parkhaus.Count - 1].Postleitzahl = plz;
            //Fügt die Stellplätze in die List hinzu
            parkhaus[parkhaus.Count - 1].FüllenListPKW(Convert.ToInt32(msdPKW));
            parkhaus[parkhaus.Count - 1].FüllenListLKW(Convert.ToInt32(msdLKW));
            parkhaus[parkhaus.Count - 1].FüllenListMotorrad(Convert.ToInt32(msdMotorrad));
        }
    }
}