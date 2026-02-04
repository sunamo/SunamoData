namespace SunamoData.Data;

/// <summary>
/// Represents a search result from Google Maps containing business information.
/// </summary>
public class GoogleMapsSearchResult
{
    /// <summary>
    /// Gets or sets the business address.
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    public string Mail { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the business name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the opening hours information.
    /// </summary>
    public string OpeningHours { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the formatted phone number (human-readable).
    /// </summary>
    public string PhoneNice { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the rating (0.0 to 5.0).
    /// </summary>
    public float Rating { get; set; }

    /// <summary>
    /// Gets or sets the number of ratings.
    /// </summary>
    public int RatingCount { get; set; }

    /// <summary>
    /// Gets or sets whether a reservation is required.
    /// </summary>
    public bool ReservationRequired { get; set; } = false;

    /// <summary>
    /// Gets or sets the type of business (e.g., "Restaurant", "Hotel").
    /// </summary>
    public string TypeOfBusiness { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Google Maps URI.
    /// </summary>
    public string Uri { get; set; } = string.Empty;
}