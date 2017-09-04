using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class FlipViewModel : IFlipViewModel
    {
        ///<inheritdoc />
        public int SelectedIndex { get; set; }
        ///<inheritdoc />
        public IPhotoModel SelectedItem { get; set; }
    }
}