using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    public class Motorräder: Fahrzeug
    {
        private int Hubraum;

        public void Berechne_Steuerschuld()
        {
            throw new System.NotImplementedException();
        }



        public int MeineHubraume 
        {
            get { return Hubraum; }
            set { Hubraum = value; }
        }

    }
}