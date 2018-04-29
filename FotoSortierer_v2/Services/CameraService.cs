using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Helper.Builder;
using Model.Interfaces;
using Repository.Interfaces;

namespace FotoSortierer_v2.Services
{
    /// <inheritdoc />
    public class CameraService : ICameraService
    {
        private readonly ICameraViewModelBuilder _cameraViewModelBuilder;

        public CameraService(ICameraViewModelBuilder cameraViewModelBuilder)
        {
            _cameraViewModelBuilder = cameraViewModelBuilder;
        }

        /// <inheritdoc />
        public ICollection<ICameraViewModel> GetCameras(IEnumerable<IPhotoViewModel> photoCollection)
        {
            var cameras = photoCollection.Where(photo => !string.IsNullOrWhiteSpace(photo.CameraFactory))
                                         .Select(photo => _cameraViewModelBuilder.Build(photo.CameraFactory, photo.CameraModel))
                                         .GroupBy(c => c.CameraName).Select(c => c.First()).ToList();
            return cameras;
        }
    }
}