using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;

// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBeMadeStatic.Global

namespace FotoSortierer_v2.Helper
{
    /// <summary>
    /// Debughelper class to initialize viewmodels with default values for debugging.
    /// Have to be removed befor release.
    /// </summary>
    public class DebugHelper
    {
        private static DebugHelper _instance;
        private static readonly object IsLocked = new object();

        private DebugHelper()
        { }

        public static DebugHelper Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (IsLocked)
                    if (_instance == null)
                        // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                        _instance = new DebugHelper();

                return _instance;
            }
        }

        public IObservableCollectionAdapter<ICameraViewModel> ImportViewModel_CameraViewModels => new ObservableCollectionAdapter<ICameraViewModel>()
        {
            new CameraViewModel {CameraName = "Camera 1", TimeZoneInfo = TimeZoneInfo.Local, CameraIcon = new BitmapImage(new Uri("pack://application:,,,/Icons/Camera_Factory_Icons/LG.ico"))},
            new CameraViewModel {CameraName = "Camera 2", TimeZoneInfo = TimeZoneInfo.Local, CameraIcon = new BitmapImage(new Uri("pack://application:,,,/Icons/Camera_Factory_Icons/Nikon.ico"))}
        };

        public IObservableCollectionAdapter<IPhotoViewModel> ImportViewModel_PhotoViewModels => new ObservableCollectionAdapter<IPhotoViewModel>()
        {
            new PhotoViewModel() {Name = "Photo 1", Comment = "Irgendein sehr langer text, wie lorem ipsum", Similarity = 0},
            new PhotoViewModel() {Name = "Photo 2", Comment = "Irgendein sehr langer text, wie lorem ipsum", Similarity = 90},
            new PhotoViewModel() {Name = "Photo 3", Comment = "Irgendein sehr langer text, wie lorem ipsum", Similarity = 50},
            new PhotoViewModel() {Name = "Photo 4", Comment = "Irgendein sehr langer text, wie lorem ipsum", Similarity = 20}
        };
    }
}
