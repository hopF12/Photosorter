using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Viewmodel for flipview
    /// </summary>
    public class FlipViewModel : IFlipViewModel
    {
        /// <summary>
        /// Selected index of current photo in flipview.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Object of current photo in flipview.
        /// </summary>
        public IPhotoModel SelectedItem { get; set; }
    }
}