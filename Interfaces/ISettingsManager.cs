namespace SunamoData.Interfaces;
using SunamoData.Data;

public interface ISettingsManager<FrameworkElement, DependencyProperty>
{
    void AddFromSavedElements(TUList<FrameworkElement, DependencyProperty> list);
    void LoadSettings(FrameworkElement sender, TUList<FrameworkElement, DependencyProperty> savedElements);
    void SaveSettings(FrameworkElement sender, TUList<FrameworkElement, DependencyProperty> savedElements);
}