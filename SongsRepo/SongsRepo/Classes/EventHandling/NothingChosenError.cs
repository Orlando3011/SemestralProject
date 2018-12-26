using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class NothingChosenError : EventHandler
    {
        public NothingChosenError()
        {
            this.SetText("You have to choose song to perform this action.");
            this.SetTitle("Error");
            this.SetIcon(MessageBoxImage.Error);
            this.SetButton(MessageBoxButton.OK);
        }
    }
}
