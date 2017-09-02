using System.Collections.Generic;
using Model.Interfaces;

namespace FotoSortierer_v2.Services.Interfaces
{
    public interface ISaveFolderDialogService
    {
        void SaveFiles(IEnumerable<IPhotoModel> photos);
    }
}