// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoData.Data;

public class CheckBoxData<T>
{
    /// <summary>
    ///     Na to co se má zobrazit
    /// </summary>
    public T t = default;

    /// <summary>
    ///     Set to IsChecked when TwoWayTable.DataCellWrapper == AddBeforeControl.CheckBox
    /// </summary>
    public bool? tick = false;
}