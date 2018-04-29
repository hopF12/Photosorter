using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="ICameraViewModel" />
    public class CameraViewModel : ViewModelBase<CameraModel>, ICameraViewModel
    {
        private readonly IMessenger _messenger;

        public CameraViewModel(IMessenger messenger)
        {
            _messenger = messenger;
            TimeZoneInfos = TimeZoneInfo.GetSystemTimeZones();
        }

        /// <inheritdoc />
        public IEnumerable<TimeZoneInfo> TimeZoneInfos { get; }

        public string CameraName
        {
            get => Model.CameraName;
            set
            {
                if (Model.CameraName == value) return;
                Model.CameraName = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public TimeZoneInfo TimeZoneInfo
        {
            get => Model.TimeZoneInfo;
            set
            {
                if (Equals(Model.TimeZoneInfo, value)) return;
                Model.TimeZoneInfo = value;
                _messenger.Send(this, "UpdateOffset"); // Send to PhotoViewModel: the selected timezone
                _messenger.Send(true, "UpdateOrder"); // Send to PhotoViewModel: the selected timezone
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public BitmapImage CameraIcon
        {
            get => Model.CameraIcon;
            set
            {
                if (Equals(Model.CameraIcon, value)) return;
                Model.CameraIcon = value;
                OnPropertyChanged();
            }
        }
    }
}