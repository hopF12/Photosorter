using System.Collections.ObjectModel;
using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Model of import view.
    /// </summary>
    public class ImportModel : IImportModel
    {
        /// <summary>
        /// Object of selected photo in listview.
        /// </summary>
        public IPhotoModel SelectedPhoto { get; set; }
    }
}