using System;
using System.Drawing;
using System.IO;

namespace ImageSimilarity
{
    public class ComparableImage : IComparableImage
    {
        public ComparableImage(FileInfo file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }

            File = file;

            using (var bitmap = ImageUtility.ResizeBitmap(new Bitmap(file.FullName), 100, 100))
            {
                Projections = new RgbProjections(ImageUtility.GetRgbProjections(bitmap));
            }
        }

        public FileInfo File { get; }

        public RgbProjections Projections { get; }

        /// <summary>
        /// Calculate the similarity to another image.
        /// </summary>
        /// <param name="compare">The image to compare with.</param>
        /// <returns>Return a value from 0 to 1 that is the similarity.</returns>
        public double CalculateSimilarity(IComparableImage compare)
        {
            return Projections.CalculateSimilarity(compare.Projections);
        }

        public override string ToString()
        {
            return File.Name;
        }
    }
}