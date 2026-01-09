// variables names: ok
namespace SunamoData.Interfaces;

/// <summary>
/// Provides methods for managing application settings for framework elements.
/// </summary>
/// <typeparam name="TFrameworkElement">The type of framework element.</typeparam>
/// <typeparam name="TDependencyProperty">The type of dependency property.</typeparam>
public interface ISettingsManager<TFrameworkElement, TDependencyProperty>
{
    /// <summary>
    /// Adds settings from previously saved elements.
    /// </summary>
    /// <param name="savedElements">The list of saved elements to add.</param>
    void AddFromSavedElements(TUList<TFrameworkElement, TDependencyProperty> savedElements);

    /// <summary>
    /// Loads settings for the specified element.
    /// </summary>
    /// <param name="sender">The element to load settings for.</param>
    /// <param name="savedElements">The list of saved elements.</param>
    void LoadSettings(TFrameworkElement sender, TUList<TFrameworkElement, TDependencyProperty> savedElements);

    /// <summary>
    /// Saves settings for the specified element.
    /// </summary>
    /// <param name="sender">The element to save settings for.</param>
    /// <param name="savedElements">The list where settings will be saved.</param>
    void SaveSettings(TFrameworkElement sender, TUList<TFrameworkElement, TDependencyProperty> savedElements);
}