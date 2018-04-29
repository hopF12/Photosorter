using System;
using System.Collections.Generic;
using System.Globalization;
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
        public IPhotoModel Build(string fileName, ICollection<string> fileNames, BitmapMetadata metaData)
        {
            var model = new PhotoModel
            {
                Name = Path.GetFileName(fileName),
                Comment = metaData.Comment,
                CameraFactory = metaData.CameraManufacturer ?? "unbekannt",
                CameraModel = metaData.CameraModel ?? "unbekannt",
                Path = fileName,
                DateTaken = DateTime.ParseExact(metaData.DateTaken ?? new DateTime(2000, 1, 1).ToString(CultureInfo.CurrentUICulture), "dd.MM.yyyy HH:mm:ss",
                    CultureInfo.InvariantCulture)
            };

            return model;
        }
    }
}