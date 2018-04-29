using System;
using System.Collections.Generic;
using ImageSimilarity;
using Model.Interfaces;

namespace Model
{
    /// <inheritdoc cref="IPhotoModel" />
    public class PhotoModel : IPhotoModel
    {
        public PhotoModel()
        {
            OffSet = TimeZoneInfo.Local;
        }

        ///<inheritdoc />
        public string Name { get; set; }
        ///<inheritdoc />
        public string Path { get; set; }
        ///<inheritdoc />
        public string Comment { get; set; }
        ///<inheritdoc />
        public string CameraFactory { get; set; }
        /// <inheritdoc />
        public string CameraModel { get; set; }
        ///<inheritdoc />
        public DateTime DateTaken { get; set; }
        /// <inheritdoc />
        public TimeZoneInfo OffSet { get; set; }
        /// <inheritdoc />
        public bool IsFolder { get; set; }

        public ICollection<ISimilarityImages> SimilarPhotos { get; set; }
    }
}