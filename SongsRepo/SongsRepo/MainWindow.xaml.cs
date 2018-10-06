using SongsRepo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using SongsRepo.Forms;
using Microsoft.Win32;
using System.IO;
using Path = System.IO.Path;
using System.Xml.Serialization;
using System.Xml;

namespace SongsRepo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Song> songsList { get; set; }
        public void createDirectory()
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Notes"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Texts"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "MP3s"));
            }
        }

        public void clearDirectory(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            createDirectory();
            songsList = new ObservableCollection<Song> { };
            InitializeComponent();
        }

        private void addSongButton_Click(object sender, RoutedEventArgs e)
        {
            int songID;
            if (songsList.Any()) songID = songsList.Last().Id + 1;
            else songID = 1;
            Song newSong = new Song(songID, "", "");
            NewSongForm newSongForm = new NewSongForm(newSong, this);
            this.IsEnabled = false;
            newSongForm.Show();
            songsList.Add(newSong);
        }

        private void editItem_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            chosenSong.editSong(this);
        }

        private void deleteItem_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null) chosenSong.deleteSong(songsList);
        }

        private void addNotes_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            chosenSong.copyFile(".pdf");
        }

        private void addText_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            chosenSong.copyFile(".txt");
        }

        private void AddMP3_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            chosenSong.copyFile(".mp3");
        }

        private void disposeButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("This action is irreversible. Do you want to contnue?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                songsList.Clear();
                clearDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Notes"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Texts"));
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "MP3s"));
            }

        }

        private void window_Closed(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Song>));
            using (Stream fStream = new FileStream("songsList.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, songsList);
            }
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            if(File.Exists("songsList.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Song>));
                using (Stream fStream = new FileStream("songsList.xml", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    XmlReader reader = XmlReader.Create(fStream);
                    songsList.Clear();
                    songsList = (ObservableCollection<Song>)xmlSerializer.Deserialize(reader);
                    dataGrid.ItemsSource = songsList;
                }
            }
        }

        private void ShowSong_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            DisplayForm displayForm = new DisplayForm(chosenSong, this);
            this.IsEnabled = false;
            displayForm.Show();
        }
    }
}
