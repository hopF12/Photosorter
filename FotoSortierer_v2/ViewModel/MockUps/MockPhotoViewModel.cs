using System;
using System.Collections.Generic;
using System.Windows.Media;
using FotoSortierer_v2.ViewModel.Interfaces;
using ImageSimilarity;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for single photo.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockPhotoViewModel : IPhotoViewModel
    {
        public ImageSource Image { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Comment { get; set; }
        public string CameraFactory { get; set; }
        public string CameraModel { get; set; }
        public DateTime DateTaken { get; set; }
        public TimeZoneInfo OffSet { get; set; }
        public ICollection<ISimilarityImages> SimilarPhotos { get; set; }
        public bool IsFolder { get; set; }
        public float ProgressbarValue { get; set; }
    }
}