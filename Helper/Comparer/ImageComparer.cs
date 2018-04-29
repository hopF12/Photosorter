using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper.Comparer.Interfaces;
using Helper.Factories.Interfaces;
using Helper.Others;
using ImageSimilarity;

namespace Helper.Comparer
{
    /// <inheritdoc />
    public class ImageComparer : IImageComparer
    {
        private readonly ICompareableImageFactory _factory;

        public ImageComparer(ICompareableImageFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        /// <inheritdoc />
        public ICollection<ISimilarityImages> Compare(string currentImage, ICollection<string> allImages, float neededSimilarityGrade = Constants.SimilarityGrade)
        {
            var comparables = allImages.Where(fileName => fileName != currentImage).Select(image => _factory.Create(image)).ToList();
            var similarityImagesSorted = new List<ISimilarityImages>();

            var source = _factory.Create(currentImage);

            foreach (var destination in comparables)
            {
                var similarity = source.CalculateSimilarity(destination);

                // if similartiy is lower then set SimilartiyGrade continue
                if (!(Math.Round(similarity * 100, 1) >= neededSimilarityGrade)) continue;

                var sim = new SimilarityImages(source, destination, similarity);
                similarityImagesSorted.Add(sim);
            }

            return similarityImagesSorted;
        }

        public Task<ICollection<ISimilarityImages>> CompareAsync(string currentImage, ICollection<string> allImages, float neededSimilarityGrade = 90)
        {
            return Task.Run(() => Compare(currentImage, allImages, neededSimilarityGrade));
        }

        public async Task<ICollection<ISimilarityImages>> CompareAsync1(string currentImage, ICollection<string> allImages, float neededSimilarityGrade = 90)
        {
            return await Task.Run(() => Compare(currentImage, allImages, neededSimilarityGrade));
        }
    }
}