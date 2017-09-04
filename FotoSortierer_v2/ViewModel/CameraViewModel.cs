using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    public class CameraViewModel : ViewModelBase<CameraModel>, ICameraViewModel
    {
        public CameraViewModel()
        {
            TimeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
        }

        public IEnumerable<TimeZoneInfo> TimeZoneInfos { get; }

        public string CameraName
        {
            get => Model.CameraName;
            set
            {
                Model.CameraName = value;
                OnPropertyChanged();
            }
        }

        public TimeZoneInfo TimeZoneInfo
        {
            get => Model.TimeZoneInfo;
            set
            {
                Model.TimeZoneInfo = value;
                OnPropertyChanged();
            }
        }

        public BitmapImage CameraIcon
        {
            get => Model.CameraIcon;
            set
            {
                if (Model.CameraIcon == value) return;
                Model.CameraIcon = value;
                OnPropertyChanged();
            }
        }
    }
}