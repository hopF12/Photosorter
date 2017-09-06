using FotoSortierer_v2.ViewModel.Interfaces;

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
        /// <param name="manufactorer">Manufactorername of the camera.</param>
        /// <param name="model">Modelname of the camera.</param>
        /// <returns>Returns a new instance of CameraViewModel.</returns>
        ICameraViewModel Build(string manufactorer, string model);
    }
}
