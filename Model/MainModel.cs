using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Model for Mainview.
    /// </summary>
    public class MainModel : IMainModel
    {
        /// <summary>
        /// Index of selected tab.
        /// </summary>
        public int SelectedTabIndex { get; set; }
    }
}