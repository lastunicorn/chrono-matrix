using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

public class Settings : ISettings
{
    private readonly IConfiguration configuration;
    private readonly string configurationFilePath;

    private Lazy<JsonSerializerOptions> jsonOptions = new(() =>
    {
        return new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 1
        };
    });


    public bool ShowSeconds
    {
        get => configuration.GetValue("ShowSeconds", defaultValue: false);
        set => SaveSetting("ShowSeconds", value);
    }

    public bool BlinkingColons
    {
        get => configuration.GetValue("BlinkingColons", defaultValue: true);
        set => SaveSetting("BlinkingColons", value);
    }

    public event EventHandler SettingsChanged;

    public Settings(string configurationFilePath)
    {
        if (configurationFilePath == null)
            throw new ArgumentNullException(nameof(configurationFilePath));

        this.configurationFilePath = configurationFilePath;

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

    private void SaveSetting(string key, object value)
    {
        Dictionary<string, object> existingSettings = [];

        if (File.Exists(configurationFilePath))
        {
            string jsonContent = File.ReadAllText(configurationFilePath);

            if (!string.IsNullOrWhiteSpace(jsonContent))
            {
                Dictionary<string, object> parsedSettings = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonContent);

                if (parsedSettings != null)
                    existingSettings = parsedSettings;
            }
        }

        existingSettings[key] = value;

        string updatedJson = JsonSerializer.Serialize(existingSettings, jsonOptions.Value);
        File.WriteAllText(configurationFilePath, updatedJson);
    }
}
