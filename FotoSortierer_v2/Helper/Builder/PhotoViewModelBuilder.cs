using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder
{
    public class PhotoViewModelBuilder : IPhotoViewModelBuilder
    {
        public IPhotoViewModel Build(IPhotoModel model)
        {
            var viewModel = new PhotoViewModel
            {
                CameraFactory = model.CameraFactory,
                CameraModel = model.CameraModel,
                Comment = model.Comment,
                DateTaken = model.DateTaken,
                Name = model.Name,
                Path = model.Path,
                Similarity = model.Similarity
            };

            return viewModel;
        }
    }
}