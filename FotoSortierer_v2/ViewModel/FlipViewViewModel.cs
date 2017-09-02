using System.Collections.ObjectModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    public class FlipViewViewModel : ViewModelBase<FlipViewModel>, IFlipViewViewModel
    {
        private ObservableCollection<IPhotoModel> _images;

        public ObservableCollection<IPhotoModel> Images
        {
            get => _images;
            set
            {
                if (_images == value) return;
                _images = value;
                OnPropertyChanged();
            }
        }

        public int SelectedIndex
        {
            get => Model.SelectedIndex;
            set
            {
                if (Model.SelectedIndex == value) return;
                Model.SelectedIndex = value;
                OnPropertyChanged();
            }
        }

        public IPhotoModel SelectedItem
        {
            get => Model.SelectedItem;
            set
            {
                if (Model.SelectedItem == value) return;
                Model.SelectedItem = value;
                OnPropertyChanged();
            }
        }
    }
}