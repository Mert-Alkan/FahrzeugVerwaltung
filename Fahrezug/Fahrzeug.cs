﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrezug
{
    public class Fahrzeug
    {
        protected string Hersteller;
        protected int    Anschaffungspreis;
        protected string Modell;
        protected string Kennzeichen;
        protected string Erstzulassung;
        protected string fahren;
        

        

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
       
                
        
    }
}