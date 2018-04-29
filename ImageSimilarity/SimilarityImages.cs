using System;
// ReSharper disable PossibleNullReferenceException

namespace ImageSimilarity
{
    public class SimilarityImages : ISimilarityImages
    {
        private readonly double _similarity;

        public SimilarityImages(IComparableImage source, IComparableImage destination, double similarity)
        {
            Source = source;
            Destination = destination;
            _similarity = similarity;
        }

        public IComparableImage Source { get; }

        public IComparableImage Destination { get; }

        public double Similarity => Math.Round(_similarity * 100, 1);

        public static int operator !=(SimilarityImages value, SimilarityImages compare)
        {
            return value.CompareTo(compare);
        }

        public static int operator <(SimilarityImages value, SimilarityImages compare)
        {
            return value.CompareTo(compare);
        }

        public static int operator ==(SimilarityImages value, SimilarityImages compare)
        {
            return value.CompareTo(compare);
        }

        public static int operator >(SimilarityImages value, SimilarityImages compare)
        {
            return value.CompareTo(compare);
        }

        public override string ToString()
        {
            return $"{Source.File.Name}, {Destination.File.Name} --> {_similarity}";
        }

        #region IComparer<SimilarityImages> Members

        public int Compare(SimilarityImages x, SimilarityImages y)
        {
            return x._similarity.CompareTo(y._similarity);
        }

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {
            var other = (SimilarityImages)obj;
            return Compare(this, other);
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (SimilarityImages)obj;

            var equals = Source.File.FullName.Equals(other.Source.File.FullName, StringComparison.InvariantCultureIgnoreCase);

            if (!equals)
            {
                return false;
            }

            equals = Destination.File.FullName.Equals(other.Destination.File.FullName, StringComparison.InvariantCultureIgnoreCase);

            return equals;
        }

        public override int GetHashCode()
        {
            return $"{Source.File.FullName};{Destination.File.FullName}".GetHashCode();
        }
    }
}