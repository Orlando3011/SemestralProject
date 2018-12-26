using System;
using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
     public class EventHandler
    {
        private string text;
        private string title;
        private MessageBoxImage image;
        private MessageBoxButton button;

        public void DisplayMessage()
        {
            MessageBox.Show(this.text, this.title, this.button, this.image);
        }

        public Boolean AskYesNo()
        {
            Boolean dialogResult;
            if (System.Windows.MessageBox.Show(this.text, this.title, this.button, this.image) == MessageBoxResult.Yes)
                dialogResult = true;
            else
                dialogResult = false;

            return dialogResult;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetIcon(MessageBoxImage image)
        {
            this.image = image;
        }

        public void SetButton(MessageBoxButton button)
        {
            this.button = button;
        }
    }
}
