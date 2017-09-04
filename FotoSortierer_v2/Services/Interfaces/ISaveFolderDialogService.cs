using System.Collections.Generic;
using Model.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    /// <summary>
    /// Service for saving photos in selected destination path.
    /// </summary>
    public interface ISaveFolderDialogService
    {
        /// <summary>
        /// Displays an SaveFolderBrowserDialog where user can select destination path.
        /// </summary>
        /// <param name="photos">Collection of PhotoModel or PhotoViewModels that should be saved.</param>
        void SaveFiles(IEnumerable<IPhotoModel> photos);
    }
}