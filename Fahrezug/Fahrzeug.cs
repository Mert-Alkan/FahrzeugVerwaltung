using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrezug
{
    public class Fahrzeug
    {
        protected string Hersteller;
        protected int Anschaffungspreis;
        protected string Modell;
        protected int Kennzeichen;
        protected string Erstzulassung;

        

        public string MeinHersteller
        {
            get { return MeinHersteller ; }
            set { MeinHersteller = value; }
        }

        

        public int MeinAnschaffungspreis
        {
            get { return MeinAnschaffungspreis ; }
            set {MeinAnschaffungspreis  = value; }
        }

        

        public string  MeinModell
        {
            get { return MeinModell; }
            set { MeinModell = value; }
        }


        public  int MeinKennzeichen
        {
            get { return MeinKennzeichen; }
            set { MeinKennzeichen = value; }
        }

         

        public  string MeineErstzulassung
        {
            get { return MeineErstzulassung; }
            set { MeineErstzulassung = value;}
        }



        public  string MeinFahrzeug
        {
            get { return MeinFahrzeug; }
            set { MeinFahrzeug= value; }
        }
       
                
        
    }
}