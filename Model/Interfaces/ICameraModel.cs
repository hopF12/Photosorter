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
        /// Icon for camera. Will be binded in tiles.
        /// </summary>
        BitmapImage CameraIcon { get; set; }

        /// <summary>
        /// Name of the camera.
        /// </summary>
        string CameraName { get; set; }

        /// <summary>
        /// Indicates in which timezone the camera was used.
        /// </summary>
        TimeZoneInfo TimeZoneInfo { get; set; }
    }
}