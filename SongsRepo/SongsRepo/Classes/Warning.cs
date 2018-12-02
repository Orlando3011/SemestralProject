using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SongsRepo.Classes
{
    class Warning
    {
        public Warning()
        {

        }

        public void DisplayMP3Error()
        {
            System.Windows.MessageBox.Show("Chosen song doses not contain an MP3 file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void DisplayDocumentsError()
        {
            System.Windows.MessageBox.Show("Chosen song doses not contain any document to display.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public Boolean DisplayDeleteWarning()
        {
            Boolean dialogResult;
            if (System.Windows.MessageBox.Show("This action is irreversible. Do you want to contnue?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                dialogResult = true;
            else
                dialogResult = false;

            return dialogResult;
        }

        public void DisplayCreatedDirectoryInfo()
        {
            System.Windows.MessageBox.Show("Application created new folder for saved files. It can be found in My Documents/SongsRepo.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
