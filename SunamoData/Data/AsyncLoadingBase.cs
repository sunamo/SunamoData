namespace SunamoData.Data;

/// <summary>
/// Base class for asynchronous loading operations with progress tracking.
/// </summary>
/// <typeparam name="T">The type of items being loaded.</typeparam>
/// <typeparam name="TProgressBar">The type of progress bar control.</typeparam>
public class AsyncLoadingBase<T, TProgressBar>
{
    /// <summary>
    /// Gets or sets the progress bar control.
    /// </summary>
    public TProgressBar ProgressBar { get; set; } = default!;

    /// <summary>
    /// Gets or sets the count of processed items.
    /// </summary>
    public long ProcessedCount { get; set; } = 0;

    /// <summary>
    /// Gets or sets the action to execute after an item is loaded.
    /// </summary>
    public Action<T> StatusAfterLoad { get; set; } = default!;
}