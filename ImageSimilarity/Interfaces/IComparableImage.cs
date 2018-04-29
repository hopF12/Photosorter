using System.IO;

namespace ImageSimilarity
{
    public interface IComparableImage
    {
        FileInfo File { get; }
        RgbProjections Projections { get; }

        double CalculateSimilarity(IComparableImage compare);
        string ToString();
    }
}