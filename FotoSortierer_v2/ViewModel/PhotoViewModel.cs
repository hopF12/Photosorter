using System;
using System.Windows.Media;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    public class PhotoViewModel : ViewModelBase<PhotoModel>, IPhotoViewModel
    {
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