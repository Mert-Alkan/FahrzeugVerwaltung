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
        public void Speichern(List<Parkhaus> parkhäuser, List<Fahrzeug> fahrzeuge)
        {
            //Speichert Fahrzeuge
            FileStream stream;
            File.Delete("FahrzeugChronik.bin");
            stream = new FileStream("FahrzeugChronik.bin", FileMode.OpenOrCreate)
            {
                Position = 0
            };
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, fahrzeuge);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            stream.Close();


            //Speichert Parkhäuser
            File.Delete("ParkhausChronik.bin");
            stream = new FileStream("ParkhausChronik.bin", FileMode.OpenOrCreate)
            {
                Position = 0
            };
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, parkhäuser);

            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public List<Fahrzeug> FahrzeugeLaden()
        {
            List<Fahrzeug> tmpList = new List<Fahrzeug>();
            FileStream stream;

            stream = new FileStream("FahrzeugChronik.bin", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                tmpList = (List<Fahrzeug>)Formatter.Deserialize(stream);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            stream.Close();
            return tmpList;
        }


        public List<Parkhaus> ParkhäuserLaden()
        {
            List<Parkhaus> tmpList = new List<Parkhaus>();
            FileStream stream;

            stream = new FileStream("ParkhausChronik.bin", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                tmpList = (List<Parkhaus>)Formatter.Deserialize(stream);

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