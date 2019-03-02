using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    public class PKW : Fahrzeug
    {
        private int Hubraum;
        private double Leistung;
        private string Schadstoffklasse;

        public void Berechne_Steuerschuld()
        {
            throw new System.NotImplementedException();
        }
         

        public  double MeineLeistung
        {
            get { return Leistung; }
            set { Leistung = value; }
        }



        public string  MeineSchadStoffKlasse
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