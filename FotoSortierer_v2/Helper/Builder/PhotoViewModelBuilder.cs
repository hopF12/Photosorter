using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.Helper.Builder
{
    public class PhotoViewModelBuilder : IPhotoViewModelBuilder
    {
        private readonly ICameraViewModelBuilder _cameraViewModelBuilder;

        public PhotoViewModelBuilder(ICameraViewModelBuilder cameraViewModelBuilder)
        {
            _cameraViewModelBuilder = cameraViewModelBuilder;
        }

        public IPhotoViewModel Create(IPhotoModel model)
        {
            var viewModel = new PhotoViewModel
            {
                Image = model.Image,
                Camera = _cameraViewModelBuilder.Build(model.Camera),
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