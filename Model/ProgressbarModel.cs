using Model.Interfaces;

namespace Model
{
    /// <inheritdoc />
    public class ProgressbarModel : IProgressbarModel
    {
        /// <inheritdoc />
        public int ProgressbarMaxValue { get; set; }

        /// <inheritdoc />
        public int ProgressbarValue { get; set; }

        /// <inheritdoc />
        public string ProgressbarText { get; set; }

        public bool IsSomethingRunning => ProgressbarValue < ProgressbarMaxValue;
    }
}