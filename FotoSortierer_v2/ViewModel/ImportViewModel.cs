using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using Model.Interfaces;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IImportViewModel" />
    public class ImportViewModel : ViewModelBase<ImportModel>, IImportViewModel
    {
        private readonly IMessenger _messenger;
        private readonly IPhotoService _photoService;
        private readonly ICameraService _cameraService;

        public ImportViewModel(IMessenger messenger, IPhotoService photoService, ICameraService cameraService)
        {
            _messenger = messenger;
            _photoService = photoService;
            _cameraService = cameraService;

            Photos = new ObservableCollectionAdapter<IPhotoViewModel>();
            Cameras = new ObservableCollectionAdapter<ICameraViewModel>();

            OkCommand = new RelayCommand(p => ExecuteOk());
            OpenCommand = new RelayCommand(p => ExecuteOpen());
        }

        private void ExecuteOk()
        {
            _messenger.Send(1, "ImportFinished"); // Send to Mainviewmodel: change to tabindex 1
        }

        private async void ExecuteOpen()
        {
            Photos.AddRange(await _photoService.GetPhotosAsync());
            Cameras.AddRange(_cameraService.GetCameras(Photos));
            _messenger.Send(Photos, "ImportFinished"); // Send to FlipViewModel: list of imported photos
        }

        public ICommand OpenCommand { get; }
        public ICommand OkCommand { get; }

        /// <inheritdoc />
        public IPhotoModel SelectedPhoto
        {
            get => Model.SelectedPhoto;
            set
            {
                if (Model.SelectedPhoto == value) return;
                Model.SelectedPhoto = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public IObservableCollectionAdapter<ICameraViewModel> Cameras { get; }

        /// <inheritdoc />
        public IObservableCollectionAdapter<IPhotoViewModel> Photos { get; }
    }
}