using System.IO;
using Helper.Factories.Interfaces;
using ImageSimilarity;

namespace Helper.Factories
{
    /// <inheritdoc />
    public class CompareableImageFactory : ICompareableImageFactory
    {
        /// <inheritdoc />
        public IComparableImage Create(string fileInfo)
        {
            return new ComparableImage(new FileInfo(fileInfo));
        }
    }
}