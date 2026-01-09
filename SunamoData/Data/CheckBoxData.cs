// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents data for a checkbox control with a value and checked state.
/// </summary>
/// <typeparam name="T">The type of value to display.</typeparam>
public class CheckBoxData<T>
{
    /// <summary>
    /// Gets or sets the value that should be displayed.
    /// </summary>
    public T Value { get; set; } = default!;

    /// <summary>
    /// Gets or sets whether the checkbox is checked.
    /// Set to IsChecked when TwoWayTable.DataCellWrapper == AddBeforeControl.CheckBox.
    /// </summary>
    public bool? IsChecked { get; set; } = false;
}