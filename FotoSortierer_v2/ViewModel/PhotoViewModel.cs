using System;
using System.Collections.Generic;
using FotoSortierer_v2.Helper;
using FotoSortierer_v2.ViewModel.Interfaces;
using ImageSimilarity;
using Model;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IPhotoViewModel" />
    public class PhotoViewModel : ViewModelBase<PhotoModel>, IPhotoViewModel
    {
        public PhotoViewModel(IMessenger messenger)
        {
            messenger.Register<CameraViewModel>(this, "UpdateOffset", viewModel =>
            {
                // Update offset if camera's timezone has changed
                if ($"{CameraFactory} {CameraModel}" == viewModel.CameraName)
                    OffSet = viewModel.TimeZoneInfo;
            });
        }

        /// <inheritdoc />
        public string Name
        {
            get => Model.Name;
            set
            {
                if (Model.Name == value) return;
                Model.Name = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public string Path
        {
            get => Model.Path;
            set
            {
                if (Model.Path == value) return;
                Model.Path = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public string Comment
        {
            get => Model.Comment;
            set
            {
                if (Model.Comment == value) return;
                Model.Comment = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public ICollection<ISimilarityImages> SimilarPhotos
        {
            get => Model.SimilarPhotos;
            set
            {
                if (Equals(Model.SimilarPhotos, value)) return;
                Model.SimilarPhotos = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public string CameraFactory
        {
            get => Model.CameraFactory;
            set
            {
                if (Model.CameraFactory == value) return;
                Model.CameraFactory = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public string CameraModel
        {
            get => Model.CameraModel;
            set
            {
                if (Model.CameraModel == value) return;
                Model.CameraModel = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public DateTime DateTaken
        {
            get => Model.DateTaken.AddHours(OffSet.GetOffsetInHours());
            set
            {
                if (Model.DateTaken == value) return;
                Model.DateTaken = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public TimeZoneInfo OffSet
        {
            private get => Model.OffSet;
            set
            {
                if (Equals(Model.OffSet, value)) return;
                Model.OffSet = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public bool IsFolder
        {
            get => Model.IsFolder;
            set
            {
                if (Model.IsFolder == value) return;
                Model.IsFolder = value;
                OnPropertyChanged();
            }
        }
    }
}