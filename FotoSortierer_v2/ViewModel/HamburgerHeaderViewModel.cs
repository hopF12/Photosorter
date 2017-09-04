using System.Collections.ObjectModel;
using MahApps.Metro.Controls;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    //ToDo comment
    public class HamburgerHeaderViewModel : ViewModelBase
    {
        private ObservableCollection<HamburgerMenuGlyphItem> _hamburgerHeaderGlyphItems;

        public HamburgerHeaderViewModel()
        {
            _hamburgerHeaderGlyphItems = GetObservableCollectionOfHamburgerMenuGlyphItems();
        }

        private ObservableCollection<HamburgerMenuGlyphItem> GetObservableCollectionOfHamburgerMenuGlyphItems()
        {
            var hamburgerHeaderGlyphItems = new ObservableCollection<HamburgerMenuGlyphItem>();
            for (var index = 1; index < 11; index++)
            {
                hamburgerHeaderGlyphItems.Add(
                    new HamburgerMenuGlyphItem
                    {
                        Glyph = "pack://application:,,,/Icons/PhotoSorter.ico",
                        Label = $"Test {index}"
                    });
            }
            return hamburgerHeaderGlyphItems;
        }

        //ToDo comment
        public ObservableCollection<HamburgerMenuGlyphItem> HamburgerHeaderGlyphItems
        {
            get => _hamburgerHeaderGlyphItems;
            set
            {
                if (_hamburgerHeaderGlyphItems == value) return;
                _hamburgerHeaderGlyphItems = value;
                OnPropertyChanged();
            }
        }
    }
}