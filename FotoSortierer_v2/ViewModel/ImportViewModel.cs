using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.Services.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Helper.Factories.Interfaces;
using ImageSimilarity;
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
        private readonly IIsSomethingRunning _isSomethingRunning;

        public ImportViewModel(IMessenger messenger, IPhotoService photoService, IFactoryMethod factory, IIsSomethingRunning isSomethingRunning)
        {
            _messenger = messenger;
            _photoService = photoService;
            _isSomethingRunning = isSomethingRunning;

            Photos = factory.Create<ObservableCollectionAdapter<IPhotoViewModel>>();
            Cameras = factory.Create<ObservableCollectionAdapter<ICameraViewModel>>();

            OkCommand = new RelayCommand(p => ExecuteOk());
            ImportCommand = new RelayCommand(p => ExecuteOpen(), c => CanExecute());
            DeleteCommand = new RelayCommand(p => ExecuteDelete((string)p), c => CanExecute());
            CompareCommand = new RelayCommand(p => ExecuteCompare(), c => CanExecute() && Photos.Any());


            _messenger.Register<ICollection<IPhotoViewModel>>(this, "PhotoImportFinished", p => Photos.Init(p));
            _messenger.Register<ICollection<ICameraViewModel>>(this, "PhotoImportFinished", p => Cameras.Init(p));
        }

        private bool CanExecute()
        {
            return !_isSomethingRunning.IsSomethingRunning;
        }

        private void ExecuteOk()
        {
            _messenger.Send(1, "ImportFinished"); // Send to Mainviewmodel: change to tabindex 1
        }

        private void ExecuteOpen()
        {
            _messenger.Send(Photos, "ImportPhotos"); // Send to MainViewModel: event that importing photos should be started.
        }

        private void ExecuteCompare()
        {
            _messenger.Send(Photos, "ComparePhotos");
        }

        private void ExecuteDelete(string path)
        {
            _photoService.DeletePhoto(path, Photos);
        }

        /// <inheritdoc />
        public ICommand ImportCommand { get; }

        /// <inheritdoc />
        public ICommand CompareCommand { get; }

        /// <inheritdoc />
        public ICommand OkCommand { get; }

        /// <inheritdoc />
        public ICommand DeleteCommand { get; }

        /// <inheritdoc />
        public IPhotoModel SelectedPhoto
        {
            get => Model.SelectedPhoto;
            set
            {
                if (Model.SelectedPhoto == value) return;
                Model.SelectedPhoto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(BannerText));
            }
        }

        /// <inheritdoc />
        public ISimilarityImages FlipViewSelectedPhoto
        {
            get => Model.FlipViewSelectedPhoto;
            set
            {
                if (Model.FlipViewSelectedPhoto == value) return;
                Model.FlipViewSelectedPhoto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(BannerText));
            }
        }

        /// <inheritdoc />
        public string BannerText => $"Zu {FlipViewSelectedPhoto?.Similarity ?? 0}% gleich.";

        /// <inheritdoc />
        public IObservableCollectionAdapter<ICameraViewModel> Cameras { get; }

        /// <inheritdoc />
        public IObservableCollectionAdapter<IPhotoViewModel> Photos { get; }
    }
}