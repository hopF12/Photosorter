using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IFlipViewViewModel" />
    public class FlipViewViewModel : ViewModelBase<FlipViewModel>, IFlipViewViewModel
    {
        private readonly IMessenger _messenger;
        private IObservableCollectionAdapter<IPhotoViewModel> _images;

        public FlipViewViewModel(IMessenger messenger)
        {
            _messenger = messenger;
            _images = new ObservableCollectionAdapter<IPhotoViewModel>();

            messenger.Register<int>(this, "SelectedIndex", index => { SelectedIndex = index; });
            messenger.Register<IObservableCollectionAdapter<IPhotoViewModel>>(this, "ImportFinished", (photos) =>
            {
                Images.AddRange(photos);
            });
        }

        /// <inheritdoc />
        public IObservableCollectionAdapter<IPhotoViewModel> Images
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
                _messenger.Send(SelectedIndex, "SelectedIndex"); // Send to HamburgerMenuViewModel: selected index
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