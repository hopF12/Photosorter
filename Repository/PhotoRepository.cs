using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Helper.Builder.Interfaces;
using Model.Interfaces;
using Repository.Interfaces;

namespace Repository
{
    ///<inheritdoc />
    public class PhotoRepository : IPhotoRepository
    {
        private readonly IPhotoModelBuilder _builder;

        public PhotoRepository(IPhotoModelBuilder builder)
        {
            _builder = builder;
        }

        ///<inheritdoc />
        public async Task<IEnumerable<IPhotoModel>> GetPhotosAsync(IEnumerable<string> fileNames)
        {
            var photos = new List<IPhotoModel>();

            await Task.Run(() =>
            {
                foreach (var fileName in fileNames)
                {
                    using (var fs = new FileStream(fileName, FileMode.Open))
                    {
                        var image = BitmapFrame.Create(fs);
                        var photoModel = _builder.Build(fileName, image);
                        photos.Add(photoModel);
                    }
                }
            });

            return photos;
        }
    }
}
