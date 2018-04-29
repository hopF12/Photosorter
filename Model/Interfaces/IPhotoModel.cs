using System;
using System.Collections.Generic;
using ImageSimilarity;

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
        /// Set the timezone for the photo. It will be used to get the real date taken.
        /// </summary>
        TimeZoneInfo OffSet { set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a folder or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is folder; otherwise, <c>false</c>.
        /// </value>
        bool IsFolder { get; set; }

        /// <summary>
        /// Gets or sets the similar photos.
        /// </summary>
        /// <value>
        /// The similar photos.
        /// </value>
        ICollection<ISimilarityImages> SimilarPhotos { get; set; }
    }
}