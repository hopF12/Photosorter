using System;
using System.Windows.Media.Imaging;

namespace Model.Interfaces
{
    /// <summary>
    /// Model for a recognized camara.
    /// </summary>
    public interface ICameraModel
    {
        /// <summary>
        /// Name of the camera.
        /// </summary>
        BitmapImage CameraIcon { get; set; }

        /// <summary>
        /// Indicates in which timezone the camera was used.
        /// </summary>
        string CameraName { get; set; }

        /// <summary>
        /// Icon for camera. Will be binded in tiles.
        /// </summary>
        TimeZoneInfo TimeZoneInfo { get; set; }
    }
}