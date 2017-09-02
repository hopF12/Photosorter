using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder.Interfaces
{
    /// <summary>
    /// Builder for creating new PhotoViewModels.
    /// </summary>
    public interface IPhotoViewModelBuilder
    {
        /// <summary>
        /// Builds new instance of PhotoViewModel of a instance of PhotoModel.
        /// </summary>
        /// <param name="model">PhotoModel with all properties, that should be used for new CameraViewModel.</param>
        /// <returns>Returns a new instance of PhotoViewModel.</returns>
        IPhotoViewModel Build(IPhotoModel model);
    }
}