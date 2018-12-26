using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class NameError : EventHandler
    {
        public NameError()
        {
            this.SetText("Name field cannot be empty.");
            this.SetTitle("Error");
            this.SetIcon(MessageBoxImage.Error);
            this.SetButton(MessageBoxButton.OK);
        }
    }
}
