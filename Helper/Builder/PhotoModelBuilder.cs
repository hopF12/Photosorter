using System;
using System.IO;
using System.Windows.Media.Imaging;
using Helper.Builder.Interfaces;
using Model;
using Model.Interfaces;

namespace Helper.Builder
{
    ///<inheritdoc />
    public class PhotoModelBuilder : IPhotoModelBuilder
    {
        ///<inheritdoc />
        public IPhotoModel Build(string fileName, BitmapMetadata metaData)
        {
            var model = new PhotoModel
            {
                Name = Path.GetFileName(fileName),
                Comment = metaData.Comment,
                CameraFactory = metaData.CameraManufacturer,
                CameraModel = metaData.CameraModel,
                DateTaken = DateTime.ParseExact(metaData.DateTaken, "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture), // Todo: change this to string
                Path = fileName
            };

            return model;
        }
    }
}