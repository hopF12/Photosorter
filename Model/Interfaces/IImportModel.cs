using ImageSimilarity;

namespace Model.Interfaces
{
    /// <summary>
    /// Model of import view.
    /// </summary>
    public interface IImportModel
    {
        /// <summary>
        /// Object of selected photo in listview.
        /// </summary>
        IPhotoModel SelectedPhoto { get; set; }

        /// <summary>
        /// Gets or sets the index for the selected item in flip view.
        /// </summary>
        /// <value>
        /// The index of the selected item in flip view.
        /// </value>
        ISimilarityImages FlipViewSelectedPhoto { get; set; }
    }
}