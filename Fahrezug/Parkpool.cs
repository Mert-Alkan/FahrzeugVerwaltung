using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Fahrzeug
{
    [Serializable]
    public class Parkpool
    {
        public  int Stellplatz_Nr;
        public List<Parkhaus> parkhaus = new List<Parkhaus>();

        public Parkpool()
        {
            
        }
        public void FahrzeugZuweisung()
        {
            throw new System.NotImplementedException();
        }
        public Parkhaus Parkhaus_Hinzufügen1()
        {
            Form1 form1 = new Form1();
            if (form1.Parkhaus1 != null)  
            {
                parkhaus.Add(form1.Parkhaus1);
            }
            try
            {
              return form1.Parkhaus1;
            }
            catch (Exception)
            {
               return null;
            }
        }
    }
}