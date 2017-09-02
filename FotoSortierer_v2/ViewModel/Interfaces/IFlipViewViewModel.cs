using System.Collections.ObjectModel;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <summary>
    /// Viewmodel for flipview.
    /// </summary>
    public interface IFlipViewViewModel : IFlipViewModel
    {
        /// <summary>
        /// List of all imported images.
        /// </summary>
        ObservableCollection<IPhotoModel> Images { get; set; }
    }
}