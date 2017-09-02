using Model.Interfaces;

namespace Helper.Builder.Interfaces
{
    /// <summary>
    /// Builder for CameraModels.
    /// </summary>
    public interface ICameraModelBuilder
    {
        /// <summary>
        /// Builds a new instance of CameraModel with the given parameters.
        /// </summary>
        /// <param name="cameraManufacturer">Manufacturer of the camera. This will be used for selecting the CameraIcon and creating the CameraName</param>
        /// <param name="cameraModel">Model (or serialnumber) of the camera.</param>
        /// <returns>Returns a new instance of CameraModel.</returns>
        ICameraModel Build(string cameraManufacturer, string cameraModel);
    }
}