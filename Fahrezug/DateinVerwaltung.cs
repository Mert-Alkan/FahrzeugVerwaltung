using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fahrzeug
{
    [Serializable]
    public class DateinVerwaltung
    {
        Fahrzeugpool fahrzeugpool = new Fahrzeugpool();
        public void Speichern()
        {
            FileStream stream;
            File.Delete("FahrzeugChronik.bin");
            stream = new FileStream("FahrzeugChronik.bin", FileMode.OpenOrCreate)
            {
                Position = 0
            };
            try
            {
                
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, fahrzeugpool.MeineFahrzeugListe);
                
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            stream.Close();
        }
        public List<Fahrzeug> Laden()
        {
            List<Fahrzeug> tmpList = new List<Fahrzeug>();
            FileStream stream;

            stream = new FileStream("FahrzeugChronik.bin", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                fahrzeugpool.MeineFahrzeugListe = (List<Fahrzeug>)Formatter.Deserialize(stream);
             
                foreach (Fahrzeug fahrzeug in fahrzeugpool.MeineFahrzeugListe)
                {
                    tmpList.Add(fahrzeug);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            stream.Close();
            return tmpList;
         
        }

    }
}