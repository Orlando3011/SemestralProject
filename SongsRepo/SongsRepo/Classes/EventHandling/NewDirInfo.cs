using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class NewDirInfo : EventHandler
    {
            public NewDirInfo()
            {
                this.SetText("Welcome in SongsRepo!\n\n" +
                    "Application created new folder for saved files." +
                    " It can be found in: \n\nMyDocuments/SongsRepo.");
                this.SetTitle("Welcome");
                this.SetIcon(MessageBoxImage.Information);
                this.SetButton(MessageBoxButton.OK);
            }
        }
}
