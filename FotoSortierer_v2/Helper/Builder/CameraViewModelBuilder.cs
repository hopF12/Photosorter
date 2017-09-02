using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder
{
    public class CameraViewModelBuilder : ICameraViewModelBuilder
    {
        public ICameraViewModel Build(ICameraModel model)
        {
            var viewModel = new CameraViewModel
            {
                TimeZoneInfo = model.TimeZoneInfo,
                CameraName = model.CameraName,
                CameraIcon = model.CameraIcon
            };

            return viewModel;
        }
    }
}