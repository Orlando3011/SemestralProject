using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class DocumentError : EventHandler
    {
        public DocumentError()
        {
            this.SetText("Chosen song does not contain any document to display.");
            this.SetTitle("Error");
            this.SetIcon(MessageBoxImage.Error);
            this.SetButton(MessageBoxButton.OK);
        }
    }
}
