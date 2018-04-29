using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Helper;
using Helper.Builder.Interfaces;
using Helper.Factories.Interfaces;
using Helper.Others;
using Model.Interfaces;
using Repository.Interfaces;

namespace Repository
{
    ///<inheritdoc />
    public class PhotoRepository : IPhotoRepository
    {
        private readonly IPhotoModelBuilder _builder;
        private readonly IFactoryMethod _factory;

        public PhotoRepository(IPhotoModelBuilder builder, IFactoryMethod factory)
        {
            _builder = builder;
            _factory = factory;
        }

        ///<inheritdoc />
        public async Task<IEnumerable<IPhotoModel>> GetPhotosAsync(ICollection<string> fileNames, IProgressbarModel pbValue)
        {
            var photos = new List<IPhotoModel>();

            await Task.Run(() =>
            {
                foreach (var fileName in fileNames)
                {
                    using (var fs = new FileStream(fileName, FileMode.Open))
                    {
                        var metaData = (BitmapMetadata)BitmapFrame.Create(fs).Metadata;
                        var photoModel = _builder.Build(fileName, fileNames, metaData);
                        photos.Add(photoModel);
                    }

                    pbValue.ProgressbarValue++;
                }
            });

            return photos;
        }

        public async Task Save(IEnumerable<IPhotoModel> photos, IProgressbarModel progressbar, string destination, bool createSubfolder = false)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (!Directory.Exists(destination))
                        Directory.CreateDirectory(destination);

                    foreach (var image in photos)
                    {
                        var destinationFullPath = $"{destination}\\{image.Name}".Replace("JPG", "JPEG"); 

                        // Copy file first, because the source file is already used in another process
                        File.Copy(image.Path, destinationFullPath, true);

                        // change meta data
                        var metaDataAdapter = _factory.Create<JpegMetadataAdapter>(destinationFullPath);

                        metaDataAdapter.Metadata.DateTaken = image.DateTaken.ToString("yyyy.MM.dd hh:mm:ss");
                        metaDataAdapter.Metadata.Comment = image.Comment ?? string.Empty;

                        // save image again, now with change meta data
                        metaDataAdapter.SaveAs(destinationFullPath, true);

                        progressbar.ProgressbarValue++;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            });
        }
    }
}
