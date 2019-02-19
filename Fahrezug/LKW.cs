using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrezug
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

        private string Zuladung
        {
            get => default(string);
            set
            {
            }
        }

        public void Berechne_Steuerschuld()
        {
            throw new System.NotImplementedException();
        }
    }
}