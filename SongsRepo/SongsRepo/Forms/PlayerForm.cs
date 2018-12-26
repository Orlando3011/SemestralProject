using SongsRepo.Classes;
using System;
using System.Windows.Forms;

namespace SongsRepo.Forms
{
    public partial class PlayerForm : Form
    {
        private DisplayForm parentWindow;
        private Song chosenSong;

        public PlayerForm()
        {
            InitializeComponent();
        }

        public PlayerForm(Song _chosenSong, DisplayForm _parentWindow)
        {
            this.chosenSong = _chosenSong;
            this.parentWindow = _parentWindow;

            InitializeComponent();
        }

        public PlayerForm(Song _chosenSong)
        {
            this.chosenSong = _chosenSong;

            InitializeComponent();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = chosenSong.MP3Path;
        }
    }
}
