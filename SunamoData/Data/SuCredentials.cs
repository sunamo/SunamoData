namespace SunamoData.Data;

/// <summary>
/// Represents authentication credentials with either login/password or token.
/// </summary>
public class SuCredentials
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SuCredentials"/> class with a token.
    /// </summary>
    /// <param name="token">The authentication token.</param>
    public SuCredentials(string token)
    {
        Token = token;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SuCredentials"/> class with login and password.
    /// </summary>
    /// <param name="login">The login username.</param>
    /// <param name="password">The password.</param>
    public SuCredentials(string login, string password)
    {
        Login = login;
        Password = password;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SuCredentials"/> class.
    /// </summary>
    public SuCredentials()
    {
    }

    /// <summary>
    /// Gets or sets the login username.
    /// </summary>
    public string Login { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the authentication token.
    /// </summary>
    public string Token { get; set; } = string.Empty;
}
