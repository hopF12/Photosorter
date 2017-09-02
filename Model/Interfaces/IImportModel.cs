namespace Model.Interfaces
{
    /// <summary>
    /// Model of import view.
    /// </summary>
    public interface IImportModel
    {
        /// <summary>
        /// Object of selected photo in listview.
        /// </summary>
        IPhotoModel SelectedPhoto { get; set; }
    }
}