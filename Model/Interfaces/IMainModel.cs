namespace Model.Interfaces
{
    /// <summary>
    /// Model for Mainview.
    /// </summary>
    public interface IMainModel
    {
        /// <summary>
        /// Index of selected tab.
        /// </summary>
        int SelectedTabIndex { get; set; }


        /// <summary>
        /// Gets or sets the progressbar values.
        /// </summary>
        /// <value>
        /// The progressbar.
        /// </value>
        IProgressbarModel Progressbar { get; set; }
    }
}