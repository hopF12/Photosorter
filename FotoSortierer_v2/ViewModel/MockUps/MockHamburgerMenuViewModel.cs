using System.Collections.ObjectModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using MahApps.Metro.Controls;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for Hamburgerviewmodel.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockHamburgerMenuViewModel : IHamburgerMenuViewModel
    {
        private readonly ObservableCollection<HamburgerMenuGlyphItem> _hamburgerMenuGlyphItems;

        public MockHamburgerMenuViewModel()
        {
            _hamburgerMenuGlyphItems = new ObservableCollection<HamburgerMenuGlyphItem>
            {
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 1"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 2"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 3"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 4"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 5"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 6"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 7"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 8"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 9"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 10"},
                new HamburgerMenuGlyphItem() {Glyph = "pack://application:,,,/Icons/Folder.ico", Label = "Test 11"}
            };
        }

        public bool IsHamburgerMenuPaneOpen { get; set; }
        public int SelectedIndex { get; set; }
        public ObservableCollection<HamburgerMenuGlyphItem> HamburgerMenuGlyphItems { get; set; }
    }
}