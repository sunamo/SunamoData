// variables names: ok
namespace SunamoData.Data;

/// <summary>
/// Represents login credentials with a username and password.
/// </summary>
public class LoginData
{
    /// <summary>
    /// Gets or sets the login username.
    /// </summary>
    public string Login { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string Password { get; set; } = string.Empty;
}