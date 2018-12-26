using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class MP3Error : EventHandler
    {
        public MP3Error()
        {
            this.SetText("Chosen song does not contain any file to play.");
            this.SetTitle("Error");
            this.SetIcon(MessageBoxImage.Error);
            this.SetButton(MessageBoxButton.OK);
        }
    }
}
