using System.Collections.Generic;
using System.Threading.Tasks;
using ImageSimilarity;

namespace Helper.Comparer.Interfaces
{
    /// <summary>
    /// Helper class for comparing images.
    /// </summary>
    public interface IImageComparer
    {
        /// <summary>
        /// Compares the specified file infos to get the similarity to other images.
        /// </summary>
        /// <param name="currentImage">Current image, that should be compared with others.</param>
        /// <param name="allImages">All current images.</param>
        /// <param name="neededSimilarityGrade">Set the needed similarity grade that the photos set as similar.</param>
        /// <returns>Returns a list with similarity grade to other images.</returns>
        ICollection<ISimilarityImages> Compare(string currentImage, ICollection<string> allImages, float neededSimilarityGrade = 90);

        /// <summary>
        /// Compares the specified file infos to get the similarity to other images.
        /// </summary>
        /// <param name="currentImage">Current image, that should be compared with others.</param>
        /// <param name="allImages">All current images.</param>
        /// <param name="neededSimilarityGrade">Set the needed similarity grade that the photos set as similar.</param>
        /// <returns>Returns a list with similarity grade to other images.</returns>
        Task<ICollection<ISimilarityImages>> CompareAsync(string currentImage, ICollection<string> allImages, float neededSimilarityGrade = 90);
    }
}