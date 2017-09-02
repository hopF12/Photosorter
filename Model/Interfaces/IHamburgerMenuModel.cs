namespace Model.Interfaces
{
    public interface IHamburgerMenuModel
    {
        bool IsHamburgerMenuPaneOpen { get; set; }
        int SelectedIndex { get; set; }
    }
}