using System.Collections.ObjectModel;
using Model.Interfaces;

namespace Model
{
    public class ImportModel : IImportModel
    {
        public IPhotoModel SelectedPhoto { get; set; }
    }
}