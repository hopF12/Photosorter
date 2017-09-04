using Model.Interfaces;

namespace Model
{
    public class FlipViewModel : IFlipViewModel
    {
        public int SelectedIndex { get; set; }
        public IPhotoModel SelectedItem { get; set; }
    }
}