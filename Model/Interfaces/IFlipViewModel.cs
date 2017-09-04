namespace Model.Interfaces
{
    /// <summary>
    /// Viewmodel for flipview
    /// </summary>
    public interface IFlipViewModel
    {
        /// <summary>
        /// Selected index of current photo in flipview.
        /// </summary>
        int SelectedIndex { get; set; }

        /// <summary>
        /// Object of current photo in flipview.
        /// </summary>
        IPhotoModel SelectedItem { get; set; }
    }
}