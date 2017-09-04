using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.ViewModel.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for camera tiles.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockCameraViewModel : ICameraViewModel
    {
        public BitmapImage CameraIcon { get; set; }
        public string CameraName { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
        public IEnumerable<TimeZoneInfo> TimeZoneInfos { get; }
    }
}