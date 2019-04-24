using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    [Serializable]
    public class Motorräder : Fahrzeug
    {
        private int Hubraum;

        public override float Steuerschuld => (float)(Hubraum + 99) / 100 * 20;   

        public int MeineHubraume 
        {
            get { return Hubraum; }
            set { Hubraum = value; }
        }
    }
}