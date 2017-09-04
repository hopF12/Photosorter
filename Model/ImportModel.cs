using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class ImportModel : IImportModel
    {
        ///<inheritdoc />
        public IPhotoModel SelectedPhoto { get; set; }
    }
}