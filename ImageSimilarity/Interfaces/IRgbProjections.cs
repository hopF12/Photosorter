namespace ImageSimilarity
{
    public interface IRgbProjections
    {
        double[] HorizontalProjection { get; }
        double[] VerticalProjection { get; }

        double CalculateSimilarity(RgbProjections compare);
    }
}