using System.Windows.Media.Imaging;

namespace Helper.Others.Interfaces
{
    public interface IJpegMetadataAdapter
    {
        BitmapMetadata Metadata { get; }

        void Save();
        void SaveAs(string path, bool overwrite = false);
    }
}