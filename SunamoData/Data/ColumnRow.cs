// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents a column and row position in a grid or table.
/// </summary>
public class ColumnRow
{
    /// <summary>
    /// Gets or sets the column index.
    /// </summary>
    public int Column { get; set; } = 0;

    /// <summary>
    /// Gets or sets the row index.
    /// </summary>
    public int Row { get; set; } = 0;
}