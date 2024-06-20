using MudBlazor;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Preferences;

public interface IClientPreferenceManager : IPreferenceManager
{
    Task<MudTheme> GetCurrentThemeAsync();

    Task<bool> ToggleDarkModeAsync();

    Task ToggleDrawerAsync(bool drawer);

    Task<bool> ToggleLayoutDirectionAsync();
}