using System.Collections.ObjectModel;
using Model.Interfaces;

namespace Model
{
    //ToDo comment this
    public class ImportModel : IImportModel
    {
        public IPhotoModel SelectedPhoto { get; set; }
    }
}