using System;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.Helper.Builder.Interfaces;
using FotoSortierer_v2.ViewModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;
using MVVM.Messenger;

namespace FotoSortierer_v2.Helper.Builder
{
    public class CameraViewModelBuilder : ICameraViewModelBuilder
    {
        private readonly IMessenger _messenger;

        public CameraViewModelBuilder(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public ICameraViewModel Build(string manufactorer, string model)
        {
            var viewModel = new CameraViewModel(_messenger)
            {
                TimeZoneInfo = TimeZoneInfo.Local,
                CameraName = $"{manufactorer} {model}",
                CameraIcon = new BitmapImage(new Uri($"pack://application:,,,/Icons/Camera_Factory_Icons/{manufactorer}.ico"))
            };

            return viewModel;
        }
    }
}