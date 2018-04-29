using System.IO;
using System.Windows.Media.Imaging;
using Helper.Others.Interfaces;

namespace Helper.Others
{
    public class JpegMetadataAdapter : IJpegMetadataAdapter
    {
        private readonly string _path;
        private readonly BitmapFrame _frame;

        public JpegMetadataAdapter(string path)
        {
            _path = path;
            _frame = GetBitmapFrame(path);
            if (_frame.Metadata != null) Metadata = (BitmapMetadata) _frame.Metadata.Clone();
        }

        public BitmapMetadata Metadata { get; }

        public void Save()
        {
            SaveAs(_path);
        }

        public void SaveAs(string path, bool overwrite = false)
        {
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(_frame, _frame.Thumbnail, Metadata, _frame.ColorContexts));
            using (Stream stream = File.Open(path, FileMode.Create, FileAccess.ReadWrite))
            {
                // save only if targetfile does not already exists or the user wants to overwrite
                if (!File.Exists(path) || overwrite)
                    encoder.Save(stream);
            }
        }

        private BitmapFrame GetBitmapFrame(string path)
        {
            BitmapDecoder decoder;
            using (Stream stream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
            {
                decoder = new JpegBitmapDecoder(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
            }
            return decoder.Frames[0];
        }
    }
}