using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Helper.Builder.Interfaces
{
    /// <summary>
    /// Builder for photomodels.
    /// </summary>
    public interface IPhotoModelBuilder
    {
        /// <summary> 
        /// Builds a new instance of PhotoModel with the given parameters.
        /// </summary>
        /// <param name="fileName">Path of the photo.</param>
        /// <param name="bitmapFrame">BitmapFrame of the photo.</param>
        /// <returns>Returns a new instance of Photomodel.</returns>
        IPhotoModel Build(string fileName, BitmapFrame bitmapFrame);
    }
}
