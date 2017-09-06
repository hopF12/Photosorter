using System;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using FotoSortierer_v2.Helper.Adapter;
using FotoSortierer_v2.Helper.Adapter.Interfaces;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for flipview.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockFlipViewViewModel : IFlipViewViewModel
    {
        public int SelectedIndex { get; set; }
        public IPhotoModel SelectedItem { get; set; }
        public IObservableCollectionAdapter<IPhotoViewModel> Images { get; set; }
        public ICommand NavigationCommand { get; }
    }
}