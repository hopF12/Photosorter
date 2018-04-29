using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using ImageSimilarity;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <inheritdoc />
    /// <summary>
    /// Mockimportviewmodel for importview.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public class MockImportViewModel : IImportViewModel
    {
        public ICommand ImportCommand { get; }
        public ICommand CompareCommand { get; }
        public ICommand OkCommand { get; }
        public ICommand DeleteCommand { get; }
        public IObservableCollectionAdapter<ICameraViewModel> Cameras { get; set; }
        public IObservableCollectionAdapter<IPhotoViewModel> Photos { get; set; }
        public IPhotoModel SelectedPhoto { get; set; }
        public IProgressbarModel Progressbar { get; set; }
        public ISimilarityImages FlipViewSelectedPhoto { get; set; }
        public string BannerText { get; set; }
    }
}