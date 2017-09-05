using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class HamburgerMenuModel : IHamburgerMenuModel
    {
        ///<inheritdoc />
        public bool IsHamburgerMenuPaneOpen { get; set; }
        ///<inheritdoc />
        public int SelectedIndex { get; set; }
    }
}