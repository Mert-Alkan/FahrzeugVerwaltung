using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Fahrzeug
{
    [Serializable]
    public class DateinVerwaltung
    {
       

        public void Speichern()
        {

            Form2 form2 = new Form2();
            try
            {
                FileStream stream;

                stream = new FileStream("FahrzeugChronik.ect", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Fahrzeugpool.fahrzeugliste);
                stream.Close();

            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Laden()
        {
            Form2 form2 = new Form2();
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream stream;
                stream = new FileStream("FahrzeugChronik.ect", FileMode.Open);
                Fahrzeugpool.fahrzeugliste = (List<Fahrzeug>)Formatter.Deserialize(stream);

                foreach (Fahrzeug fahrzeug in Fahrzeugpool.fahrzeugliste)
                {
                    Form1 form1 = new Form1();
                    
                    form1.FahrzeugListBox.Items.Add(Fahrzeugpool.fahrzeugliste);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}