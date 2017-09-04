using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Model
{
    public class PhotoModel : IPhotoModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ImageSource Image { get; set; }
        public string Comment { get; set; }
        public ICameraModel Camera { get; set; }
        public DateTime DateTaken { get; set; }
        public int Similarity { get; set; }
    }
}