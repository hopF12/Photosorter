using System.Collections.Generic;
using System.Linq;
using FotoSortierer_v2.Services.Interfaces;
using Model.Interfaces;
using Ookii.Dialogs.Wpf;

namespace FotoSortierer_v2.Services
{
    public class DialogsService : IOpenFilesDialogService, ISaveFolderDialogService
    {
        private readonly VistaOpenFileDialog _openFileDialog;
        private readonly VistaFolderBrowserDialog _folderBrowserDialog;

        public DialogsService(VistaOpenFileDialog openFileDialog, VistaFolderBrowserDialog folderBrowserDialog)
        {
            _openFileDialog = openFileDialog;
            _folderBrowserDialog = folderBrowserDialog;
        }

        public IEnumerable<string> GetFileNames()
        {
            var fileNames = new List<string>();

            // if user selects photos return the paths of photos.
            if (_openFileDialog.ShowDialog() == true)
            {
                fileNames = _openFileDialog.FileNames.ToList();
            }

            return fileNames;
        }

        public void SaveFiles(IEnumerable<IPhotoModel> photos)
        {
            // save all files in target path

            throw new System.NotImplementedException();
        }
    }
}