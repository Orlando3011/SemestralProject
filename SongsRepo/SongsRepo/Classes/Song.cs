using Microsoft.Win32;
using SongsRepo.Classes.EventHandling;
using SongsRepo.Forms;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace SongsRepo.Classes
{
    public class Song
    {
        private int id;
        private string name;
        private string author;
        private string notes;
        private string text;
        private string mp3;
        private string notesPath;
        private string textPath;
        private string mp3Path;

        public Song()
        {
        }

        public Song(int id, string name, string author)
        {
            this.id = id;
            this.name = name;
            this.author = author;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
        public string MP3
        {
            get
            {
                return mp3;
            }
            set
            {
                mp3 = value;
            }
        }
        public string NotesPath
        {
            get
            {
                return notesPath;
            }
            set
            {
                notesPath = value;
            }
        }
        public string TextPath
        {
            get
            {
                return textPath;
            }
            set
            {
                textPath = value;
            }
        }
        public string MP3Path
        {
            get
            {
                return mp3Path;
            }
            set
            {
                mp3Path = value;
            }
        }

        public void DeleteFile(string chosenFile) // "Notes", "Text" or "MP3"
        {
            switch (chosenFile)
            {
                case "Notes":
                    if (this.NotesPath != null) File.Delete(this.NotesPath);

                    this.Notes = null;
                    this.NotesPath = null;
                    break;
                case "Text":
                    if (this.TextPath != null) File.Delete(this.TextPath);
                    this.Text = null;
                    this.TextPath = null;
                    break;
                case "MP3":
                    if (this.MP3Path != null) File.Delete(this.MP3Path);
                    this.MP3 = null;
                    this.MP3Path = null;
                    break;
            }
        }

        public void CopyFile(string fileExt) //".pdf", ".txt" or ".mp3" 
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();

            if (Path.GetExtension(openFileDialog1.FileName) == fileExt)
            {
                string destinationFolder = "";
                string fileName = "";
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo");
                switch (fileExt)
                {
                    case ".pdf":
                        this.DeleteFile("Notes");
                        this.Notes = this.Name + "_notes";
                        fileName = this.Notes;
                        destinationFolder = "Notes";
                        path = Path.Combine(path, destinationFolder, fileName + fileExt);
                        this.NotesPath = path;
                        break;
                    case ".txt":
                        this.DeleteFile("Text");
                        this.Text = this.Name + "_text";
                        fileName = this.Text;
                        destinationFolder = "Texts";
                        path = Path.Combine(path, destinationFolder, fileName + fileExt);
                        this.TextPath = path;
                        break;
                    case ".mp3":
                        this.DeleteFile("MP3");
                        this.MP3 = this.Name + "_mp3";
                        fileName = this.MP3;
                        destinationFolder = "MP3s";
                        path = Path.Combine(path, destinationFolder, fileName + fileExt);
                        this.MP3Path = path;
                        break;
                }
                File.Copy(openFileDialog1.FileName, path);
            }
            else
            {
                ExtensionError extensionError = new ExtensionError();
                extensionError.DisplayMessage();
            }
        }

        public void DeleteSong(ObservableCollection<Song> songsList)
        {
            songsList.Remove(this);
            if (this.NotesPath != null) File.Delete(this.NotesPath);
            if (this.TextPath != null) File.Delete(this.TextPath);
            if (this.MP3Path != null) File.Delete(this.MP3Path);
        }

        public void EditSong(Window window)
        {
            if (this != null)
            {
                NewSongForm newSongForm = new NewSongForm(this, window);
                window.IsEnabled = false;
                newSongForm.Show();
            }
        }
    }
}