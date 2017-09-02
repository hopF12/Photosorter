using System.Collections.ObjectModel;
using MahApps.Metro.Controls;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    public class HamburgerHeaderViewModel : ViewModelBase
    {
        private ObservableCollection<HamburgerMenuGlyphItem> _hamburgerHeaderGlyphItems;

        public HamburgerHeaderViewModel()
        {
            _hamburgerHeaderGlyphItems = new ObservableCollection<HamburgerMenuGlyphItem>
            {
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 1"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 2"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 3"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 4"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 5"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 6"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 7"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 8"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 9"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico",Label = "Test 10"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/PhotoSorter.ico", Label = "Test 11"}
            };
        }

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