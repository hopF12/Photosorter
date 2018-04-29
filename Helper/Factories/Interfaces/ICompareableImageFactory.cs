using System.IO;
using ImageSimilarity;

namespace Helper.Factories.Interfaces
{
    /// <summary>
    /// Factory-Method class for creating new instances of CompareableImage.
    /// </summary>
    public interface ICompareableImageFactory
    {
        /// <summary>
        /// Creates a new instance of ComparableImage from given file.
        /// </summary>
        /// <param name="fileInfo">The image.</param>
        /// <returns></returns>
        IComparableImage Create(string fileInfo);
    }
}