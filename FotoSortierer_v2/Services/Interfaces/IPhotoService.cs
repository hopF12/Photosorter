using System.Collections.Generic;
using System.Threading.Tasks;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    /// <summary>
    /// Service for getting PhotoViewModels async or saving photos async.
    /// </summary>
    public interface IPhotoService
    {
        /// <summary>
        /// Getting PhotoViewModel-objects from selected photos async.
        /// </summary>
        /// <param name="progressbar"></param>
        /// <param name="currentPhotos"></param>
        /// <returns>Returns list of PhotoViewModels.</returns>
        Task<ICollection<IPhotoViewModel>> GetPhotosAsync(IProgressbarViewModel progressbar, IEnumerable<IPhotoViewModel> currentPhotos);

        /// <summary>
        /// Saving photos async.
        /// </summary>
        /// <param name="photos">Collection of ViewModelPhotos that should be safed.</param>
        /// <param name="progressbar">The progressbar</param>
        /// <param name="createSubfolder">Indicates whether the program should create subfolders for each day or not.</param>
        Task SaveAsync(ICollection<IPhotoViewModel> photos, IProgressbarViewModel progressbar, bool createSubfolder = false);

        /// <summary>
        /// Gets the similar photos asynchronous.
        /// </summary>
        /// <param name="progressbar">The progressbar.</param>
        /// <param name="photos">The photos.</param>
        /// <returns></returns>
        Task<ICollection<IPhotoViewModel>> GetSimilarPhotosAsync(IProgressbarViewModel progressbar, ICollection<IPhotoViewModel> photos);

        /// <summary>
        /// Deletes the photo.
        /// </summary>
        /// <param name="path">The path to photo.</param>
        /// <param name="photos"></param>
        void DeletePhoto(string path, IObservableCollectionAdapter<IPhotoViewModel> photos);
    }
}