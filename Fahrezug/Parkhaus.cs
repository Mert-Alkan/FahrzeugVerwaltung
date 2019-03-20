using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    public class Parkhaus
    {

        public int Anzahl_Sitzplätze;
        public int GaragenNr;
        private string Adresse;
        private string Ort;
        private string Plz;





        public  string MeinPlz
        {
            get { return Plz; }
            set { Plz = value; }
        }


        public string  Meinort
        {
            get { return Ort; }
            set { Ort = value; }
        }


        public string MeineAdresse
        {
            get { return Adresse; }
            set {Adresse = value; }
        }
    }
}