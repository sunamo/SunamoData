namespace SunamoData.Interfaces;

public interface ISettingsManager<TFrameworkElement, TDependencyProperty>
{
    void AddFromSavedElements(TUList<TFrameworkElement, TDependencyProperty> savedElements);
    void LoadSettings(TFrameworkElement sender, TUList<TFrameworkElement, TDependencyProperty> savedElements);
    void SaveSettings(TFrameworkElement sender, TUList<TFrameworkElement, TDependencyProperty> savedElements);
}