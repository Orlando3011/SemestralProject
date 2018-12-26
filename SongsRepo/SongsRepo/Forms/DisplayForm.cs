using SongsRepo.Classes;
using System;
using System.IO;
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

        private void scrollDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
            axAcroPDF1.gotoNextPage();
        }

        private void scrollUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.ScrollToCaret();
            axAcroPDF1.gotoPreviousPage();
        }

        private void setShortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        private void viewDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Default buttons to scroll:\n >> Right Arrow -- Next page of notes\n >> Left Arrow -- Previous page of notes");
        }

        private void DisplayForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.A):
                    {
                        textBox1.SelectionStart = textBox1.TextLength;
                        textBox1.ScrollToCaret();
                        break;
                    }
                case (Keys.D):
                    {
                        textBox1.SelectionStart = 0;
                        textBox1.ScrollToCaret();
                        break;
                    }
                default:
                    break;


            }
        }

        private void playSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm(chosenSong, this);
            playerForm.Show();
        }
    }
}
