using System.Collections.Generic;
using Model.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    /// <summary>
    /// Service for saving photos in selected destination path.
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Displays an OpenFileDialog where user can select photos.
        /// </summary>
        /// <returns>If user select photos, it will return the paths of these, else an empty list.</returns>
        IEnumerable<string> GetFileNames();

        /// <summary>
        /// Displays an SaveFolderBrowserDialog where user can select destination path.
        /// </summary>
        /// <param name="photos">Collection of PhotoModel or PhotoViewModels that should be saved.</param>
        string SaveFiles(IEnumerable<IPhotoModel> photos);

        /// <summary>
        /// Displays a dialog whether the item should be deleted or not.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        bool ShouldDelete(string path);
    }
}