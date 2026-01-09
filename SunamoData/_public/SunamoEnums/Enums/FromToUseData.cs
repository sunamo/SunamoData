// variables names: ok
namespace SunamoData._public.SunamoEnums.Enums;

/// <summary>
/// Specifies how to interpret FromTo range values.
/// </summary>
public enum FromToUseData
{
    /// <summary>
    /// Interpret values as DateTime (default).
    /// </summary>
    DateTime,

    /// <summary>
    /// Interpret values as Unix timestamp (seconds since epoch).
    /// </summary>
    Unix,

    /// <summary>
    /// Interpret values as Unix timestamp for time only (no date).
    /// </summary>
    UnixJustTime,

    /// <summary>
    /// Values are plain numbers without special interpretation.
    /// </summary>
    None
}