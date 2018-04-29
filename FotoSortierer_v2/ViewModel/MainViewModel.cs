using System.Reflection;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IMainViewModel" />
    public class MainViewModel : ViewModelBase<MainModel>, IMainViewModel
    {
        private readonly IMessenger _messenger;
        private readonly IPhotoService _photoService;
        private readonly ICameraService _cameraService;

        public MainViewModel(IMessenger messenger, IPhotoService photoService, ICameraService cameraService, IProgressbarViewModel progressbar)
        {
            _messenger = messenger;
            _photoService = photoService;
            _cameraService = cameraService;
            Progressbar = progressbar;

            messenger.Register<int>(this, "ImportFinished", selectIndex => { SelectedTabIndex = selectIndex; });
            messenger.Register<IObservableCollectionAdapter<IPhotoViewModel>>(this, "ImportPhotos", ImportPhotos);
            messenger.Register<IObservableCollectionAdapter<IPhotoViewModel>>(this, "ComparePhotos", ComparePhotos);
            messenger.Register<IObservableCollectionAdapter<IPhotoViewModel>>(this, "SaveImages", SavePhotos);
        }
        /// <inheritdoc />
        public string Header => $"Fotosortierer v{ Assembly.GetExecutingAssembly().GetName().Version }";

        private async void ImportPhotos(IObservableCollectionAdapter<IPhotoViewModel> currentPhotos)
        {
            var photos = await _photoService.GetPhotosAsync((IProgressbarViewModel)Progressbar, currentPhotos);
            var cameras = _cameraService.GetCameras(photos);

            _messenger.Send(photos, "PhotoImportFinished"); // Send to ImportViewModel: list of imported photos
            _messenger.Send(cameras, "PhotoImportFinished"); // Send to ImportViewModel: list of used cameras
            _messenger.Send(photos, "ImportFinished"); // Send to FlipViewModel: list of imported photos
        }

        private async void ComparePhotos(IObservableCollectionAdapter<IPhotoViewModel> currentPhotos)
        {
            await _photoService.GetSimilarPhotosAsync((IProgressbarViewModel) Progressbar, currentPhotos);
        }

        private async void SavePhotos(IObservableCollectionAdapter<IPhotoViewModel> photos)
        {
            await _photoService.SaveAsync(photos, (IProgressbarViewModel)Progressbar);
        }

        /// <inheritdoc />
        public int SelectedTabIndex
        {
            get => Model.SelectedTabIndex;
            set
            {
                if (Model.SelectedTabIndex == value) return;
                Model.SelectedTabIndex = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public IProgressbarModel Progressbar
        {
            get => Model.Progressbar;
            set
            {
                if (Model.Progressbar == value) return;
                Model.Progressbar = value;
                OnPropertyChanged();
            }
        }
    }
}