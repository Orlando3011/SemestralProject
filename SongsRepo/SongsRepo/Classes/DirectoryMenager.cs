using System;
using System.IO;

namespace SongsRepo.Classes
{
    class DirectoryMenager
    {
        private string directoryPath;
        private string notesDirectoryPath;
        private string textDirectoryPath;
        private string mp3DirectoryPath;

        public DirectoryMenager()
        {

            this.directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo");
            this.notesDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Notes");
            this.textDirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "Texts");
            this.mp3DirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SongsRepo", "MP3s");
        }
        public void CreateSubfolders()
        {
            Directory.CreateDirectory(this.notesDirectoryPath);
            Directory.CreateDirectory(this.textDirectoryPath);
            Directory.CreateDirectory(this.mp3DirectoryPath);
        }

        public void ClearDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(this.directoryPath);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            this.CreateSubfolders();
        }

        public void CreateDirectory()
        {
            if (!Directory.Exists(this.directoryPath))
            {
                Directory.CreateDirectory(this.directoryPath);
                this.CreateSubfolders();
            }
        }

    }
}





