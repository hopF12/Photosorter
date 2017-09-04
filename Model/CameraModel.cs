using System;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Model
{
    //ToDo comment this
    public class CameraModel : ICameraModel
    {
        public string CameraName { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
        public BitmapImage CameraIcon { get; set; }
    }
}