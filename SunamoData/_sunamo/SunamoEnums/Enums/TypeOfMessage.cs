namespace SunamoData._sunamo.SunamoEnums.Enums;

/// <summary>
///     Error/Warning are in tbLastErrorOrWarning, other in tbLastOtherMessage
///     Must be here because of cl which is withoutDep
/// </summary>
internal enum TypeOfMessage
{
    /// <summary>
    ///     tbLastErrorOrWarning
    /// </summary>
    Error,

    /// <summary>
    ///     tbLastErrorOrWarning
    /// </summary>
    Warning,
    Information,

    /// <summary>
    ///     Returned if from text cant determine value
    /// </summary>
    Ordinal,
    Appeal,
    Success
}