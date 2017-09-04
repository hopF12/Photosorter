using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class PhotoModel : IPhotoModel
    {
        ///<inheritdoc />
        public string Name { get; set; }
        ///<inheritdoc />
        public string Path { get; set; }
        ///<inheritdoc />
        public ImageSource Image { get; set; }
        ///<inheritdoc />
        public string Comment { get; set; }
        ///<inheritdoc />
        public ICameraModel Camera { get; set; }
        ///<inheritdoc />
        public DateTime DateTaken { get; set; }
        ///<inheritdoc />
        public int Similarity { get; set; }
    }
}