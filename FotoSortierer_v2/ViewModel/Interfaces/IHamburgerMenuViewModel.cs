using System.Collections.ObjectModel;
using MahApps.Metro.Controls;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    public interface IHamburgerMenuViewModel : IHamburgerMenuModel
    {
        /// <summary>
        /// List of all imported images.
        /// Todo: eventually replace HamburgerMenuGlyphItem with adapter a class
        /// </summary>
        ObservableCollection<HamburgerMenuGlyphItem> HamburgerMenuGlyphItems { get; set; }
    }
}