using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

public class Settings : ISettings
{
    private readonly IConfiguration configuration;

    public bool ShowSeconds => configuration.GetValue("ShowSeconds", defaultValue: false);

    public bool BlinkingColons => configuration.GetValue("BlinkingColons", defaultValue: true);

    public event EventHandler SettingsChanged;

    public Settings(string configurationFilePath)
    {
        if (configurationFilePath == null)
            throw new ArgumentNullException(nameof(configurationFilePath));

        configuration = new ConfigurationBuilder()
            .AddJsonFile(configurationFilePath, optional: true, reloadOnChange: true)
            .Build();

        MonitorConfigurationChanges();
    }

    private void MonitorConfigurationChanges()
    {
        ChangeToken.OnChange(
            () => configuration.GetReloadToken(),
            () => OnSettingsChanged()
        );
    }

    private void OnSettingsChanged()
    {
        SettingsChanged?.Invoke(this, EventArgs.Empty);
    }
}
