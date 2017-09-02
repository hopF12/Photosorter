using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Model for hamburgermenu
    /// </summary>
    public class HamburgerMenuModel : IHamburgerMenuModel
    {
        /// <summary>
        /// Property that indicates whether the pane is open or not.
        /// </summary>
        public bool IsHamburgerMenuPaneOpen { get; set; }

        /// <summary>
        /// Index of selected item.
        /// </summary>
        public int SelectedIndex { get; set; }
    }
}