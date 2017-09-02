using System.Collections.Generic;

namespace FotoSortierer_v2.Services.Interfaces
{
    /// <summary>
    /// Service for displaying OpenFileDialogs and returning selected filepaths.
    /// </summary>
    public interface IOpenFilesDialogService
    {
        /// <summary>
        /// Displays an OpenFileDialog where user can select photos.
        /// </summary>
        /// <returns>If user select photos, it will return the paths of these, else an empty list.</returns>
        IEnumerable<string> GetFileNames();
    }
}