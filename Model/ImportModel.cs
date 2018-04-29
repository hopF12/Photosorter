using ImageSimilarity;
using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class ImportModel : IImportModel
    {
        ///<inheritdoc />
        public IPhotoModel SelectedPhoto { get; set; }

        /// <inheritdoc />
        public IProgressbarModel Progressbar { get; set; }

        /// <inheritdoc />
        public ISimilarityImages FlipViewSelectedPhoto { get; set; }
    }
}