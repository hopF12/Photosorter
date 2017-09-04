using Model.Interfaces;

namespace Model
{
    //ToDo comment this
    public class HamburgerMenuModel : IHamburgerMenuModel
    {
        public bool IsHamburgerMenuPaneOpen { get; set; }
        public int SelectedIndex { get; set; }
    }
}