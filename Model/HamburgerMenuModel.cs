using Model.Interfaces;

namespace Model
{
    public class HamburgerMenuModel : IHamburgerMenuModel
    {
        public bool IsHamburgerMenuPaneOpen { get; set; }
        public int SelectedIndex { get; set; }
    }
}