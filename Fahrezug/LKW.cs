using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    public class LKW : Fahrzeug
    {
        private int Anzahl_Achsen
        {
            get => default(int);
            set
            {
            }
        }

        private int Zuladung
        {
            get => default(int);
            set
            {
            }
        }



        public int MeineAchsen
        {
            get { return Anzahl_Achsen; }
            set { Anzahl_Achsen = value; }
        }






        public int MeineZuladung
        {
            get { return Zuladung; }
            set { Zuladung = value; }
        }



        public void Berechne_Steuerschuld()
        {
            throw new System.NotImplementedException();
        }
    }
}