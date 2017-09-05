using Model.Interfaces;

namespace Model
{
    ///<inheritdoc />
    public class MainModel : IMainModel
    {
        ///<inheritdoc />
        public int SelectedTabIndex { get; set; }
    }
}