namespace Model.Interfaces
{
    /// <summary>
    /// Model for hamburgermenu
    /// </summary>
    public interface IHamburgerMenuModel
    {
        /// <summary>
        /// Property that indicates whether the pane is open or not.
        /// </summary>
        bool IsHamburgerMenuPaneOpen { get; set; }

        /// <summary>
        /// Index of selected item.
        /// </summary>
        int SelectedIndex { get; set; }
    }
}