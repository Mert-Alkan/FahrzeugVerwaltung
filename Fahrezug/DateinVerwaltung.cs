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
            try
            {
                FileStream stream;

                stream = new FileStream("FahrzeugChronik.ect", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, fahrzeugpool.MeineFahrzeugListe);
                stream.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Laden()
        {
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.Open);
                fahrzeugpool.MeineFahrzeugListe = (List<Fahrzeug>)Formatter.Deserialize(stream);
             
                foreach (Fahrzeug fahrzeug in fahrzeugpool.MeineFahrzeugListe)
                {
                    Form1 form1 = new Form1();
                    form1.FahrzeugListBox.Items.Add(fahrzeugpool.MeineFahrzeugListe);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }

       
        }
    }
}