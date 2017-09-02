namespace Model.Interfaces
{
    public interface IFlipViewModel
    {
        int SelectedIndex { get; set; }
        IPhotoModel SelectedItem { get; set; }
    }
}