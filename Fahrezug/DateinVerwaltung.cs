using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Fahrzeug
{
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
                formatter.Serialize(stream, form2.Fahrzeug1);
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
            BinaryFormatter Formatter = new BinaryFormatter();
            FileStream stream;
            stream = new FileStream("FahrzeugChronik.ect", FileMode.Open);
        }
    }
}