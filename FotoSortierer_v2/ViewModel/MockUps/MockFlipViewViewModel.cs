using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for flipview.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockFlipViewViewModel : IFlipViewViewModel
    {
        public MockFlipViewViewModel()
        {
            Images = new ObservableCollection<IPhotoModel>
            {
                new PhotoViewModel{ Image = new BitmapImage(new Uri("pack://application:,,,/Icons/default.jpg")), Name = "Photo 1" },
                new PhotoViewModel{ Image = new BitmapImage(new Uri("pack://application:,,,/Icons/default.jpg")), Name = "Photo 2" },
                new PhotoViewModel{ Image = new BitmapImage(new Uri("pack://application:,,,/Icons/default.jpg")), Name = "Photo 3" },
                new PhotoViewModel{ Image = new BitmapImage(new Uri("pack://application:,,,/Icons/default.jpg")), Name = "Photo 4" },
                new PhotoViewModel{ Image = new BitmapImage(new Uri("pack://application:,,,/Icons/default.jpg")), Name = "Photo 5" }
            };
        }

        public int SelectedIndex { get; set; }
        public IPhotoModel SelectedItem { get; set; }
        public ObservableCollection<IPhotoModel> Images { get; set; }
    }
}