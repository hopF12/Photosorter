using System.Windows.Input;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <inheritdoc cref="IImportModel" />
    /// <summary>
    /// Viewmodel for importview.
    /// </summary>
    public interface IImportViewModel : IImportModel
    {
        /// <summary>
        /// Gets the open command.
        /// </summary>
        /// <value>
        /// The open command.
        /// </value>
        ICommand ImportCommand { get; }

        /// <summary>
        /// Gets the compare command.
        /// </summary>
        /// <value>
        /// The compare command.
        /// </value>
        ICommand CompareCommand { get; }

        /// <summary>
        /// Gets the ok command.
        /// </summary>
        /// <value>
        /// The ok command.
        /// </value>
        ICommand OkCommand { get; }

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <value>
        /// The delete command.
        /// </value>
        ICommand DeleteCommand { get; }

        /// <summary>
        /// Gets or sets the banner text for displaying similar photos.
        /// </summary>
        /// <value>
        /// The banner text.
        /// </value>
        string BannerText { get; }

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