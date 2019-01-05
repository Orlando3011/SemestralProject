using System.Windows;

namespace SongsRepo.Classes.EventHandling
{
    class ExtensionError : EventHandler
    {

    public ExtensionError()
    {
        this.SetText("Chosen file has wrong extension.\nChoose .txt file for texts, .pdf file for notes, and .mp3 file for music.");
        this.SetTitle("Error");
        this.SetIcon(MessageBoxImage.Error);
        this.SetButton(MessageBoxButton.OK);
    }
}
}
