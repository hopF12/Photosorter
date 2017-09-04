using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder.Interfaces
{
    /// <summary>
    /// Builder for creating new CameraViewModels.
    /// </summary>
    public interface ICameraViewModelBuilder
    {
        /// <summary>
        /// Builds new CameraViewModels of CameraModels.
        /// </summary>
        /// <param name="model">CameraModel with all properties, that should be used for new CameraViewModel.</param>
        /// <returns>Returns a new instance of CameraViewModel.</returns>
        ICameraViewModel Build(ICameraModel model);
    }
}
