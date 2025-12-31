namespace SunamoData.Data;

public class CheckBoxData<T>
{
    /// <summary>
    ///     EN: What should be displayed
    ///     CZ: Na to co se má zobrazit
    /// </summary>
    public T Value = default;

    /// <summary>
    ///     EN: Set to IsChecked when TwoWayTable.DataCellWrapper == AddBeforeControl.CheckBox
    ///     CZ: Set to IsChecked when TwoWayTable.DataCellWrapper == AddBeforeControl.CheckBox
    /// </summary>
    public bool? IsChecked = false;
}