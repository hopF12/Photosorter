using Model.Interfaces;

namespace Model
{
    //ToDo comment this
    public class FlipViewModel : IFlipViewModel
    {
        public int SelectedIndex { get; set; }
        public IPhotoModel SelectedItem { get; set; }
    }
}