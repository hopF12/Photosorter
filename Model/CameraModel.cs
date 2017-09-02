using System;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Model for a recognized camara.
    /// </summary>
    public class CameraModel : ICameraModel
    {
        /// <summary>
        /// Name of the camera.
        /// </summary>
        public string CameraName { get; set; }

        /// <summary>
        /// Indicates in which timezone the camera was used.
        /// </summary>
        public TimeZoneInfo TimeZoneInfo { get; set; }

        /// <summary>
        /// Icon for camera. Will be binded in tiles.
        /// </summary>
        public BitmapImage CameraIcon { get; set; }
    }
}