using System.Collections.ObjectModel;
using System.IO;
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

        public ObservableCollection<Song> LoadSerializedList()
        {
            ObservableCollection<Song> list = new ObservableCollection<Song>();
            if (File.Exists("songsList.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Song>));
                using (Stream fStream = new FileStream("songsList.xml", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    XmlReader reader = XmlReader.Create(fStream);
                    list = (ObservableCollection<Song>)xmlSerializer.Deserialize(reader);
                }
            }
            return list;
        }
    }
}
