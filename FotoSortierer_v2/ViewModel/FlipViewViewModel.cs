using System.Collections.ObjectModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IFlipViewViewModel" />
    public class FlipViewViewModel : ViewModelBase<FlipViewModel>, IFlipViewViewModel
    {
        private ObservableCollection<IPhotoModel> _images;
        /// <inheritdoc />
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
        /// <inheritdoc />
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

        /// <inheritdoc />
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