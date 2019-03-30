using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeug
{
    [Serializable]
    public class Parkhaus
    {
        public List<int> listStellplätzePKW = new List<int>();
        public List<int> listStellplätzeLKW = new List<int>();
        public List<int> listStellplätzeMotorrad = new List<int>();

        private string sAdresse;
        private string sOrt;
        private string Plz;

        public  string Postleitzahl
        {
            get { return Plz; }
            set { Plz = value; }
        }


        public string  Ort
        {
            get { return sOrt; }
            set { sOrt = value; }
        }


        public string Adresse
        {
            get { return sAdresse; }
            set { sAdresse = value; }
        }

        public void SetztenParkhausWerte(string adresse, string ort, string plz)
        {
            sAdresse = adresse;
            sOrt = ort;
            Plz = plz;
        }

     //Mikail
        public void FüllenListPKW(int pkw)
        {
            for (int i = 0; i < pkw; i++)
            {
               listStellplätzePKW.Add(pkw);
            }
        }
        public void FüllenListLKW(int lkw)
        {
            for (int i = 0; i < lkw; i++)
            {
                listStellplätzePKW.Add(lkw);

            }
        }
        public void FüllenListMotorrad(int motorrad)
        {
            for (int i = 0; i < motorrad; i++)
            {
                listStellplätzePKW.Add(motorrad);
            }
        }
    }
}