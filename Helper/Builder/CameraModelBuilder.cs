using System;
using System.Windows.Media.Imaging;
using Helper.Builder.Interfaces;
using Model;
using Model.Interfaces;

namespace Helper.Builder
{
    //ToDo comment this
    public class CameraModelBuilder : ICameraModelBuilder
    {
        public ICameraModel Build(string cameraManufacturer, string cameraModel)
        {
            var model = new CameraModel
            {
                CameraName = $"{cameraManufacturer} {cameraModel}",
                TimeZoneInfo = TimeZoneInfo.Local,
                // get the correct icon for the camera facturer from recourses
                CameraIcon = new BitmapImage(new Uri($"pack://application:,,,/Icons/Camera_Factory_Icons/{cameraManufacturer}.ico"))
            };

            return model;
        }
    }
}