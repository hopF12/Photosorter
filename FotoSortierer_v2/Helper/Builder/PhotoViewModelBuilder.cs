using System;
using System.IO;
using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;
using MVVM.Messenger;

namespace FotoSortierer_v2.Helper.Builder
{
    public class PhotoViewModelBuilder : IPhotoViewModelBuilder
    {
        private readonly IMessenger _messenger;

        public PhotoViewModelBuilder(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public IPhotoViewModel Build(IPhotoModel model)
        {
            var viewModel = new PhotoViewModel(_messenger)
            {
                CameraFactory = model.CameraFactory,
                CameraModel = model.CameraModel,
                Comment = model.Comment,
                DateTaken = model.DateTaken,
                Name = model.Name,
                Path = model.Path,
                IsFolder = model.IsFolder
            };

            return viewModel;
        }

        /// <inheritdoc />
        public IPhotoViewModel BuildSeperator(DateTime date)
        {
            var model = new PhotoViewModel(_messenger)
            {
                Name = "Nächster Tag",
                Path = Path.Combine(Path.GetFullPath(@"..\..\"), @"Icons\default.jpg"),
                DateTaken = date,
                Comment = date.ToShortDateString(),
                IsFolder = true
            };

            return model;
        }
    }
}