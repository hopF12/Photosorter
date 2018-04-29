using Model.Interfaces;

namespace FotoSortierer_v2.ViewModel.Interfaces
{
    public interface IProgressbarViewModel : IProgressbarModel, IIsSomethingRunning
    {
        /// <summary>
        /// Initializes the specified text.
        /// </summary>
        /// <param name="text">The text that should be displayed.</param>
        /// <param name="maxValue">The maximum value.</param>
        void Init(string text, int maxValue);

        /// <summary>
        /// Finishes the progressbar.
        /// </summary>
        void Finish();
    }
}