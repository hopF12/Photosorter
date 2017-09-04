using System.Reflection;
using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using MVVM;
using MVVM.Messenger;

namespace FotoSortierer_v2.ViewModel
{
    public class MainViewModel : ViewModelBase<MainModel>, IMainViewModel
    {
        public MainViewModel(IMessenger messenger)
        {
            messenger.Register<int>(this, "ImportFinished", (selectIndex) => { SelectedTabIndex = selectIndex; });
        }

        public string Header => $"Fotosortierer v{ Assembly.GetExecutingAssembly().GetName().Version }";

        public int SelectedTabIndex
        {
            get => Model.SelectedTabIndex;
            set
            {
                if (Model.SelectedTabIndex == value) return;
                Model.SelectedTabIndex = value;
                OnPropertyChanged();
            }
        }
    }
}