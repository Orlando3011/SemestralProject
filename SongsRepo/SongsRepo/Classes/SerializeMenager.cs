using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

namespace SongsRepo.Classes
{
    class SerializeMenager
    {
        public SerializeMenager()
        {
        }

        public void SerializeList(ObservableCollection<Song> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Song>));
            using (Stream fStream = new FileStream("songsList.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, list);
            }
        }

        public void LoadSerializedList(ObservableCollection<Song> list)
        {
            if (File.Exists("songsList.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Song>));
                using (Stream fStream = new FileStream("songsList.xml", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    XmlReader reader = XmlReader.Create(fStream);
                    list.Clear();
                    list = (ObservableCollection<Song>)xmlSerializer.Deserialize(reader);
                }
            }
        }
    }
}
