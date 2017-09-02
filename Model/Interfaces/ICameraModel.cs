using System;
using System.Windows.Media.Imaging;

namespace Model.Interfaces
{
    public interface ICameraModel
    {
        BitmapImage CameraIcon { get; set; }
        string CameraName { get; set; }
        TimeZoneInfo TimeZoneInfo { get; set; }
    }
}