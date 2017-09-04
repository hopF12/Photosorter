using System;
using System.Collections.ObjectModel;
using FotoSortierer_v2.ViewModel.Interfaces;
using MahApps.Metro.Controls;
using Model;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    //ToDo comment
    public class HamburgerMenuViewModel : ViewModelBase<HamburgerMenuModel>, IHamburgerMenuViewModel
    {
        private ObservableCollection<HamburgerMenuGlyphItem> _hamburgerMenuGlyphItems;
        //ToDo comment
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
        //ToDo comment
        public ObservableCollection<HamburgerMenuGlyphItem> HamburgerMenuGlyphItems
        {
            get => _hamburgerMenuGlyphItems;
            set
            {
                if (_hamburgerMenuGlyphItems == value) return;
                _hamburgerMenuGlyphItems = value;
                OnPropertyChanged();
            }
        }
        //ToDo comment
        public int SelectedIndex
        {
            get => Model.SelectedIndex;
            set
            {
                if (Model.SelectedIndex == value) return;
                Model.SelectedIndex = value;
                OnPropertyChanged();
            }
        }
    }
}