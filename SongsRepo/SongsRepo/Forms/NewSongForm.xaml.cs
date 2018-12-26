using SongsRepo.Classes;
using SongsRepo.Classes.EventHandling;
using System;
using System.Windows;

namespace SongsRepo.Forms
{
    public partial class NewSongForm : Window
    {

        private Song editedSong;
        private Window parentWindow;
        private String name;
        private String author;

        public NewSongForm()
        {
            InitializeComponent();
        }
        public NewSongForm(Song song, Window _parentWindow)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.parentWindow = _parentWindow;
            this.editedSong = song;
            this.name = song.Name;
            this.author = song.Author;
            this.DataContext = editedSong;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.name != null)
            {
                this.editedSong.Name = this.name;
                this.editedSong.Author = this.author;
                parentWindow.IsEnabled = true;
                this.Close();
            }
            else
            {
                NameError nError = new NameError();
                nError.DisplayMessage();
            }
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.nameBox.Text != "")
            {
                parentWindow.IsEnabled = true;
                this.Close();
            }
            else
            {
                NameError nError = new NameError();
                nError.DisplayMessage();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            parentWindow.IsEnabled = true;
        }
    }
}
