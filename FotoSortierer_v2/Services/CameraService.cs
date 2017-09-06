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
    public class CameraService : ICameraService
    {
        private readonly ICameraViewModelBuilder _cameraViewModelBuilder;

        public CameraService(ICameraViewModelBuilder cameraViewModelBuilder)
        {
            _cameraViewModelBuilder = cameraViewModelBuilder;
        }

        public IEnumerable<ICameraViewModel> GetCameras(IEnumerable<IPhotoViewModel> photoCollection)
        {
            var cameras = photoCollection.Select(photo => _cameraViewModelBuilder.Build(photo.CameraFactory, photo.CameraModel)).GroupBy(c => c.CameraName).Select(c => c.First());
            return cameras;
        }
    }
}