using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <summary>
    /// Cameraviewmodel for a recognized camera.
    /// </summary>
    public interface ICameraViewModel : ICameraModel
    {
        /// <summary>
        /// List of all available timezones.
        /// </summary>
        IEnumerable<TimeZoneInfo> TimeZoneInfos { get; }
    }
}