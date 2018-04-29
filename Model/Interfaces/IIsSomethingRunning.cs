namespace Model.Interfaces
{
    /// <summary>
    /// Interface for indicating whether the UI interactions should be blocked or not.
    /// </summary>
    public interface IIsSomethingRunning
    {
        /// <summary>
        /// Indicates whether something is running in background and most UI interactions should be blocked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if something is running in background thread and most UI interactions should be blocked; otherwise, <c>false</c>.
        /// </value>
        bool IsSomethingRunning { get; }
    }
}