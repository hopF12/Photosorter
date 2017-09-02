using System.Collections.Generic;
using System.Threading.Tasks;
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
        /// <returns>Returns list of PhotoViewModels.</returns>
        Task<IEnumerable<IPhotoViewModel>> GetPhotosAsync();

        /// <summary>
        /// Saving photos async.
        /// </summary>
        /// <param name="photos">Collection of ViewModelPhotos that should be safed.</param>
        Task SaveAsync(IEnumerable<IPhotoViewModel> photos);
    }
}