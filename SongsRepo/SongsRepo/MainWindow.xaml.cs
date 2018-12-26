using SongsRepo.Classes;
using System;
using System.Linq;
using System.Windows;
using System.Collections.ObjectModel;
using SongsRepo.Forms;
using System.IO;
using SongsRepo.Classes.EventHandling;

namespace SongsRepo
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Song> SongsList { get; set; }

        public MainWindow()
        {
            DirectoryMenager dirMenager = new DirectoryMenager();
            dirMenager.CreateDirectory();

            SongsList = new ObservableCollection<Song> { };

            InitializeComponent();
        }

        private void AddSongButton_Click(object sender, RoutedEventArgs e)
        {
            int songID;
            if (SongsList.Any()) songID = SongsList.Last().Id + 1;
            else songID = 1;

            Song newSong = new Song(songID, "", "");
            NewSongForm newSongForm = new NewSongForm(newSong, this);
            this.IsEnabled = false;
            newSongForm.Show();
            SongsList.Add(newSong);
        }

        private void EditItem_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if(chosenSong != null) chosenSong.EditSong(this);
            else
            {
                NothingChosenError error = new NothingChosenError();
                error.DisplayMessage();
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null) chosenSong.DeleteSong(SongsList);
            else
            {
                NothingChosenError error = new NothingChosenError();
                error.DisplayMessage();
            }
        }

        private void AddNotes_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null)  chosenSong.CopyFile(".pdf");
            else
            {
                NothingChosenError error = new NothingChosenError();
                error.DisplayMessage();
            }
        }

        private void AddText_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null) chosenSong.CopyFile(".txt");
            else
            {
                NothingChosenError error = new NothingChosenError();
                error.DisplayMessage();
            }
        }

        private void AddMP3_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null) chosenSong.CopyFile(".mp3");
            else
            {
                NothingChosenError error = new NothingChosenError();
                error.DisplayMessage();
            }
        }

        private void DisposeButton_Click(object sender, RoutedEventArgs e)
        {
            QuestionInfo question = new QuestionInfo();
            if (question.AskYesNo() == true)
            {
                DirectoryMenager dirMenager = new DirectoryMenager();
                dirMenager.ClearDirectory();
                SongsList.Clear();
            }
        }

        private void ShowSong_Click(object sender, RoutedEventArgs e)
        {
            
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if(chosenSong != null)
            {
                if (chosenSong.NotesPath != null && chosenSong.TextPath != null)
                {
                    DisplayForm displayForm = new DisplayForm(chosenSong, this);
                    this.IsEnabled = false;
                    displayForm.Show();
                }
                else
                {
                    DocumentError error = new DocumentError();
                    error.DisplayMessage();
                }
            }
            else
            {
                DocumentError error = new DocumentError();
                error.DisplayMessage();
            }
        }

        private void PlaySong_Click(object sender, RoutedEventArgs e)
        {
            Song chosenSong = (Song)dataGrid.SelectedItem;
            if (chosenSong != null)
            {
                if (chosenSong.MP3Path != null)
                {
                    PlayerForm playerForm = new PlayerForm(chosenSong);
                    playerForm.Show();
                }
                else
                {
                    MP3Error error = new MP3Error();
                    error.DisplayMessage();
                }
            }
            else
            {
                MP3Error error = new MP3Error();
                error.DisplayMessage();
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void window_Closed(object sender, EventArgs e)
        {
            SerializeMenager sMenager = new SerializeMenager();
            sMenager.SerializeList(SongsList);
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("songsList.xml"))
            {
                SerializeMenager sMenager = new SerializeMenager();
                foreach (Song song in sMenager.LoadSerializedList()) SongsList.Add(song);
                dataGrid.ItemsSource = SongsList;
                }
            else
            {
                NewDirInfo info = new NewDirInfo();
                info.DisplayMessage();
            }
        }
    }
}
