using System.Collections.Generic;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Repository.Interfaces
{
    /// <summary>
    /// Repository for the photos.
    /// </summary>
    public interface IPhotoRepository
    {
        /// <summary>
        /// Get for each filename an object of Photomodel.
        /// </summary>
        /// <param name="fileNames">The paths of each photo that should be created as a model.</param>
        /// <param name="pbValue"></param>
        /// <returns>Returns the photomodels.</returns>
        Task<IEnumerable<IPhotoModel>> GetPhotosAsync(ICollection<string> fileNames, IProgressbarModel pbValue);

        Task Save(IEnumerable<IPhotoModel> photos, IProgressbarModel progressbar, string destination, bool createSubfolder = false);
    }
}