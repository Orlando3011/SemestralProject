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
using System.Windows.Shapes;

namespace SongsRepo.Forms
{
    /// <summary>
    /// Interaction logic for NewSongForm.xaml
    /// </summary>
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
            }
            parentWindow.IsEnabled = true;
            this.Close();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.nameBox.Text != "")
            {
                parentWindow.IsEnabled = true;
                this.Close();
            }
            else MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            parentWindow.IsEnabled = true;
        }
    }
}
