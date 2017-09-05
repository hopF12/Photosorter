using System;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class CameraModel : ICameraModel
    {
        ///<inheritdoc />
        public string CameraName { get; set; }
        ///<inheritdoc />
        public TimeZoneInfo TimeZoneInfo { get; set; }
        ///<inheritdoc />
        public BitmapImage CameraIcon { get; set; }
    }
}