using System;
using System.Windows.Media;

namespace Model.Interfaces
{
    /// <summary>
    /// Model for a singe photo.
    /// </summary>
    public interface IPhotoModel
    {
        /// <summary>
        /// Name of the photo.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Path of the photo.
        /// </summary>
        string Path { get; set; }

        /// <summary>
        /// Comment of photo. User can enter a comment for photo in view.
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// Name of camera's factory.
        /// </summary>
        string CameraFactory { get; set; }

        /// <summary>
        /// Model-Name of the camera.
        /// </summary>
        string CameraModel { get; set; }

        /// <summary>
        /// Datetime when the photo is taken. Calculates with the set offset of camera.
        /// </summary>
        DateTime DateTaken { get; set; }

        /// <summary>
        /// Similarity of photo with most similar photo in the imported list. NYI
        /// </summary>
        int Similarity { get; set; }
    }
}