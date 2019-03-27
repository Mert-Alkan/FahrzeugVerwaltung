using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    [Serializable]
    public abstract class Fahrzeug
    {
        private string Parkhaus;
        protected int Parkplatz;
        protected string Hersteller;
        protected int    Anschaffungspreis;
        protected string Modell;
        protected string Kennzeichen;
        protected string Erstzulassung;
        protected string fahren;

        public static int Length { get; internal set; }

        public string MeinHersteller
        {
            get { return Hersteller ; }
            set { Hersteller = value; }
        }

        

        public int MeinAnschaffungspreis
        {
            get { return Anschaffungspreis ; }
            set {Anschaffungspreis  = value; }
        }

        

        public string  MeinModell
        {
            get { return Modell; }
            set { Modell = value; }
        }


        public  string MeinKennzeichen
        {
            get { return Kennzeichen; }
            set { Kennzeichen = value; }
        }

         

        public  string MeineErstzulassung
        {
            get { return Erstzulassung; }
            set { Erstzulassung = value;}
        }



        public  string MeinFahrzeug
        {
            get { return fahren; }
            set { fahren= value; }
        }

        public abstract float Steuerschuld
        {
            get;
        }
      

        public int MeineParkplatz
        {
            get { return Parkplatz; }
            set { Parkplatz = value; }
        }
                                        
        public string MeinParkhaus
        {
            get { return Parkhaus; }
            set { Parkhaus = value; }
        }
    }
}