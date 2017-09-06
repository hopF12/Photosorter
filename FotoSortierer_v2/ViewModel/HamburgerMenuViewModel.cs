using System.Linq;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using MahApps.Metro.Controls;
using Model;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    //ToDo comment
    public class HamburgerMenuViewModel : ViewModelBase<HamburgerMenuModel>, IHamburgerMenuViewModel
    {
        private readonly IMessenger _messenger;
        private IObservableCollectionAdapter<HamburgerMenuGlyphItem> _hamburgerMenuGlyphItems;

        public HamburgerMenuViewModel(IMessenger messenger)
        {
            _messenger = messenger;
            _hamburgerMenuGlyphItems = new ObservableCollectionAdapter<HamburgerMenuGlyphItem>();

            messenger.Register<int>(this, "SelectedIndex", index => { SelectedIndex = index; });
            messenger.Register<IObservableCollectionAdapter<IPhotoViewModel>>(this, "ImportFinished", (photos) =>
            {
                var glyphItem = photos.Select(p => new HamburgerMenuGlyphItem() { Glyph = p.Path });
                HamburgerMenuGlyphItems.AddRange(glyphItem);
            });
        }

        /// <inheritdoc />
        public bool IsHamburgerMenuPaneOpen
        {
            get => Model.IsHamburgerMenuPaneOpen;
            set
            {
                if (Model.IsHamburgerMenuPaneOpen == value) return;
                Model.IsHamburgerMenuPaneOpen = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public IObservableCollectionAdapter<HamburgerMenuGlyphItem> HamburgerMenuGlyphItems
        {
            get => _hamburgerMenuGlyphItems;
            set
            {
                if (_hamburgerMenuGlyphItems == value) return;
                _hamburgerMenuGlyphItems = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public int SelectedIndex
        {
            get => Model.SelectedIndex;
            set
            {
                if (Model.SelectedIndex == value) return;
                Model.SelectedIndex = value;
                _messenger.Send(SelectedIndex, "SelectedIndex"); // Send to FlipViewModel: selected index
                OnPropertyChanged();
            }
        }
    }
}