using FotoSortierer_v2.Helper;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <inheritdoc />
    /// <summary>
    /// Mockimportviewmodel for importview.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockImportViewModel : IImportViewModel
    {
        public MockImportViewModel()
        {
            Cameras = DebugHelper.Instance.ImportViewModel_CameraViewModels;
            Photos = DebugHelper.Instance.ImportViewModel_PhotoViewModels;
        }

        public IObservableCollectionAdapter<ICameraViewModel> Cameras { get; set; }
        public IObservableCollectionAdapter<IPhotoViewModel> Photos { get; set; }
        public IPhotoModel SelectedPhoto { get; set; }
    }
}