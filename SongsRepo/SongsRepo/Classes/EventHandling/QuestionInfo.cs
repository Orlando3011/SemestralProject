using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class QuestionInfo : EventHandler
    {
        public QuestionInfo()
        {
            this.SetText("This action is irreversible. Do you want to contnue?");
            this.SetTitle("Error");
            this.SetIcon(MessageBoxImage.Warning);
            this.SetButton(MessageBoxButton.YesNo);
        }
    }
}
