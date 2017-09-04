using System;
using System.Windows.Media;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IPhotoViewModel" />
    public class PhotoViewModel : ViewModelBase<PhotoModel>, IPhotoViewModel
    {
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
        public ImageSource Image    
        {
            get => Model.Image;
            set
            {
                if (Model.Image == value) return;
                Model.Image = value;
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
        public int Similarity
        {
            get => Model.Similarity;
            set
            {
                if (Model.Similarity == value) return;
                Model.Similarity = value;
                OnPropertyChanged();
            }
        }
        /// <inheritdoc />
        public ICameraModel Camera
        {
            get => Model.Camera;
            set
            {
                if (Model.Camera == value) return;
                Model.Camera = value;
                OnPropertyChanged();
            }
        }
        /// <inheritdoc />
        public DateTime DateTaken
        {
            get => Model.DateTaken;
            set
            {
                if (Model.DateTaken == value) return;
                Model.DateTaken = value;
                OnPropertyChanged();
            }
        }
    }
}