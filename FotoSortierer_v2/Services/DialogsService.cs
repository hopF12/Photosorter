using System.Collections.Generic;
using System.Linq;
using FotoSortierer_v2.Services.Interfaces;
using Model.Interfaces;
using Ookii.Dialogs.Wpf;

namespace FotoSortierer_v2.Services
{
    /// <inheritdoc />
    public class DialogsService : IDialogService
    {
        private readonly VistaOpenFileDialog _openFileDialog;
        private readonly VistaFolderBrowserDialog _folderBrowserDialog;

        public DialogsService(VistaOpenFileDialog openFileDialog, VistaFolderBrowserDialog folderBrowserDialog)
        {
            _openFileDialog = openFileDialog;
            _folderBrowserDialog = folderBrowserDialog;
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
        public string SaveFiles(IEnumerable<IPhotoModel> photos)
        {
            // return path from folder dialog
            return !_folderBrowserDialog.ShowDialog().HasValue ? null : _folderBrowserDialog.SelectedPath;
        }

        /// <inheritdoc />
        public bool ShouldDelete(string path)
        {
            bool result;

            using (var taskDialog = new TaskDialog())
            {
                taskDialog.Buttons.Add(new TaskDialogButton(ButtonType.Yes));
                taskDialog.Buttons.Add(new TaskDialogButton(ButtonType.No));
                taskDialog.Buttons.Add(new TaskDialogButton(ButtonType.Cancel));

                taskDialog.MainInstruction = "Bild entfernen?";
                taskDialog.Content = $"Möchtest du das Bild: {path} wirklich entfernen?";

                result = taskDialog.ShowDialog().ButtonType == ButtonType.Yes;
            }

            return result;
        }
    }
}