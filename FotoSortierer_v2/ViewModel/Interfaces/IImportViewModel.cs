using FotoSortierer_v2.Helper.Adapter.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Viewmodel for importview.
    /// </summary>
    public interface IImportViewModel : IImportModel
    {
        /// <summary>
        /// List of all recognized cameras.
        /// </summary>
        IObservableCollectionAdapter<ICameraViewModel> Cameras { get; }

        /// <summary>
        /// List of all imported images.
        /// </summary>
        IObservableCollectionAdapter<IPhotoViewModel> Photos { get; }
    }
}