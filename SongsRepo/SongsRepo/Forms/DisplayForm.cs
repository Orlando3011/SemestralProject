using SongsRepo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SongsRepo.Forms
{
    public partial class DisplayForm : Form
    {
        private Window parentWindow;
        private Song chosenSong;
        public DisplayForm()
        {
            InitializeComponent();
        }

        public DisplayForm(Song _chosenSong, Window _parentWindow)
        {
            this.chosenSong = _chosenSong;
            this.parentWindow = _parentWindow;
            
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if(chosenSong.TextPath != null) textBox1.Text = File.ReadAllText(chosenSong.TextPath);
            if (chosenSong.NotesPath != null) axAcroPDF1.src = chosenSong.NotesPath;
        }

        private void DisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentWindow.IsEnabled = true;
        }
    }
}
