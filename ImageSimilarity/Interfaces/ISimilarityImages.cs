namespace ImageSimilarity
{
    public interface ISimilarityImages
    {
        IComparableImage Destination { get; }
        double Similarity { get; }
        IComparableImage Source { get; }

        int Compare(SimilarityImages x, SimilarityImages y);
        int CompareTo(object obj);
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}