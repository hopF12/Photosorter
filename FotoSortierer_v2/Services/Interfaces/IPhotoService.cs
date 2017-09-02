using System.Collections.Generic;
using System.Threading.Tasks;
using FotoSortierer_v2.ViewModel.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    public interface IPhotoService
    {
        Task<IEnumerable<IPhotoViewModel>> GetPhotosAsync();
        Task SaveAsync(IEnumerable<IPhotoViewModel> photos);
    }
}