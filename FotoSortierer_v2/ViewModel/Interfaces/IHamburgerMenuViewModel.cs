using System.Collections.ObjectModel;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using MahApps.Metro.Controls;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// ViewModel for hamburger menu.
    /// </summary>
    /// <seealso cref="T:Model.Interfaces.IHamburgerMenuModel" />
    public interface IHamburgerMenuViewModel : IHamburgerMenuModel
    {
        /// <summary>
        /// List of all imported images.
        /// </summary>
        IObservableCollectionAdapter<HamburgerMenuGlyphItem> HamburgerMenuGlyphItems { get; set; }
    }
}