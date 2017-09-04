using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    /// <summary>
    /// Viewmodel for mainviewmodel.
    /// </summary>
    public interface IMainViewModel : IMainModel
    {
        /// <summary>
        /// Title of window.
        /// Fotosortierer v{current Version}
        /// Current version can be set in Fotosortierer_v2 => Properties => AssemlbyInfo.cs
        /// </summary>
        string Header { get; }
    }
}