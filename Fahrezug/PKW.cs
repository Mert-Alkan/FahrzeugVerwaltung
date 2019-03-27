using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    [Serializable]
    public class PKW : Fahrzeug
    {
        private int Hubraum;
        private double Leistung;
        private int Schadstoffklasse;

        public override float Steuerschuld
        {
            //PKW: (Hubraum+99) / 100 * 10 Euro * (Schadstoffklasse+1)
            get { return (float)(Hubraum + 99) / 100 * 10 * (Schadstoffklasse + 1); }

        }


        public  double MeineLeistung
        {
            get { return Leistung; }
            set { Leistung = value; }
        }



        public int  MeineSchadStoffKlasse
        {
            get { return Schadstoffklasse; }
            set { Schadstoffklasse= value; }
        }


        public int MeinHubraum
        {
            get { return Hubraum; }
            set { Hubraum= value; }
        }

    }
}