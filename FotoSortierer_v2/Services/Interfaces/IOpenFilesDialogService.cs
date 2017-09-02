using System.Collections.Generic;

namespace FotoSortierer_v2.Services.Interfaces
{
    public interface IOpenFilesDialogService
    {
        IEnumerable<string> GetFileNames();
    }
}