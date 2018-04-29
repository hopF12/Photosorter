using System.Reflection;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.MockUps
{
    /// <summary>
    /// Mockviewmodel for Mainview.
    /// Should be never used, except in viewmodellocator to display sample data in designer.
    /// </summary>
    public class MockMainViewModel : IMainViewModel
    {
        public int SelectedTabIndex { get; set; }
        public IProgressbarModel Progressbar { get; set; }
        public string Header => $"Fotosortierer v{Assembly.GetExecutingAssembly().GetName().Version}";
    }
}