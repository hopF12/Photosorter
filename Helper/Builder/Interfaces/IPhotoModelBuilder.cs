using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Helper.Builder.Interfaces
{
    public interface IPhotoModelBuilder
    {
        IPhotoModel Build(string fileName, BitmapFrame bitmapFrame);
    }
}
