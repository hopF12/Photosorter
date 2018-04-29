using System.Collections.Generic;
using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Helper.Factories.Interfaces;
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
        private readonly IPhotoService _photoService;
        private IObservableCollectionAdapter<IPhotoViewModel> _images;

        public FlipViewViewModel(IMessenger messenger, IPhotoService photoService, IFactoryMethod factory)
        {
            _messenger = messenger;
            _photoService = photoService;
            _images = factory.Create<ObservableCollectionAdapter<IPhotoViewModel>>();

            SaveCommand = new RelayCommand(p => ExcecuteSave());

            messenger.Register<int>(this, "SelectedIndex", index => { SelectedIndex = index; });
            messenger.Register<bool>(this, "UpdateOrder", ReorderPhotos);
            messenger.Register<ICollection<IPhotoViewModel>>(this, "ImportFinished", ImportFinished);
        }

        private void ExcecuteSave()
        {
            _messenger.Send(Images, "SaveImages");
        }

        /// <summary>
        /// Import is finished and photos have arrived.
        /// </summary>
        private void ImportFinished(ICollection<IPhotoViewModel> photos)
        {
            Images.AddRange(photos);
        }

        /// <summary>
        /// Reorders the photos.
        /// </summary>
        private void ReorderPhotos(bool b)
        {
            Images = Images.Order(photo => photo.DateTaken);
            _messenger.Send(Images, "ReorderPhotos");
        }

        public ICommand SaveCommand { get; }

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