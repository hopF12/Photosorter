using FotoSortierer_v2.ViewModel.Interfaces;
using Model;
using MVVM;

namespace FotoSortierer_v2.ViewModel
{
    /// <inheritdoc cref="IProgressbarViewModel" />
    public class ProgressbarViewModel : ViewModelBase<ProgressbarModel>, IProgressbarViewModel
    {
        /// <inheritdoc />
        public int ProgressbarMaxValue
        {
            get => Model.ProgressbarMaxValue;
            set
            {
                if (Model.ProgressbarMaxValue == value) return;
                Model.ProgressbarMaxValue = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ProgressbarText));
            }
        }

        /// <inheritdoc />
        public int ProgressbarValue
        {
            get => Model.ProgressbarValue;
            set
            {
                if (Model.ProgressbarValue == value) return;
                Model.ProgressbarValue = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ProgressbarText));
            }
        }

        /// <inheritdoc />
        public string ProgressbarText
        {
            get => $"{ProgressbarValue}/{ProgressbarMaxValue} {Model.ProgressbarText}";
            set
            {
                if (Model.ProgressbarText == value) return;
                Model.ProgressbarText = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public bool IsSomethingRunning => ProgressbarValue < ProgressbarMaxValue;

        /// <inheritdoc />
        public void Init(string text, int maxValue)
        {
            ProgressbarValue = 0;
            ProgressbarMaxValue = maxValue;
            ProgressbarText = text;
        }

        /// <inheritdoc />
        public void Finish()
        {
            ProgressbarText = "Fertig";
        }
    }
}