using System;
using System.IO;
using System.Windows.Media.Imaging;
using Helper.Builder.Interfaces;
using Model;
using Model.Interfaces;

namespace Helper.Builder
{
    public class PhotoModelBuilder : IPhotoModelBuilder
    {
        private readonly ICameraModelBuilder _cameraBuilder;

        public PhotoModelBuilder(ICameraModelBuilder cameraBuilder)
        {
            _cameraBuilder = cameraBuilder;
        }

        public IPhotoModel Build(string fileName, BitmapFrame bitmapFrame)
        {
            var metaData = (BitmapMetadata)bitmapFrame.Metadata;

            if (metaData == null) throw new InvalidCastException();

            var model = new PhotoModel
            {
                Name = Path.GetFileName(fileName),
                Comment = metaData.Comment,
                Camera = _cameraBuilder.Build(metaData.CameraManufacturer, metaData.CameraModel),
                DateTaken = DateTime.ParseExact(metaData.DateTaken, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Path = fileName,
                Image = bitmapFrame
            };


            return model;
        }
    }
}