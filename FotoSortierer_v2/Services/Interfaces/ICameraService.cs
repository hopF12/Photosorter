using System.Collections.Generic;
using System.Threading.Tasks;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    /// <summary>
    /// Service for getting CameraViewModels.
    /// </summary>
    public interface ICameraService
    {
        /// <summary>
        /// Get each CameraViewModel once out of the given photoCollection.
        /// </summary>
        /// <param name="photoCollection">Collection of PhotoViewModels, where the CameraViewModels should be filtered out.</param>
        /// <returns>Returns each used Camera once.</returns>
        IEnumerable<ICameraViewModel> GetCameras(IEnumerable<IPhotoViewModel> photoCollection);
    }
}