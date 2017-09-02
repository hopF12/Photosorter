using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Repository.Interfaces
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<IPhotoModel>> GetPhotosAsync(IEnumerable<string> fileNames);
    }
}