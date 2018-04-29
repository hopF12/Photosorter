namespace Model.Interfaces
{
    /// <summary>
    /// Model for a Progressbar.
    /// </summary>
    public interface IProgressbarModel
    {
        /// <summary>
        /// Gets or sets the progressbar maximum value.
        /// </summary>
        /// <value>
        /// The progressbar maximum value.
        /// </value>
        int ProgressbarMaxValue { get; set; }

        /// <summary>
        /// Gets or sets the progressbar value.
        /// </summary>
        /// <value>
        /// The progressbar value.
        /// </value>
        int ProgressbarValue { get; set; }

        /// <summary>
        /// Gets or sets the progressbar text.
        /// </summary>
        /// <value>
        /// The progressbar text.
        /// </value>
        string ProgressbarText { get; set; }
    }
}