using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    public class Motorräder : Fahrzeug
    {
        private int Hubraum;

        public override float Steuerschuld => (float)(Hubraum + 99) / 100 * 20;    //(Hubraum+99) / 100 * 20 Euro  von Mikail 




        public int MeineHubraume 
        {
            get { return Hubraum; }
            set { Hubraum = value; }
        }


    }
}