namespace DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

public interface ISettings
{
    bool ShowSeconds { get; set; }

    bool BlinkingColons { get; set; }
    
    event EventHandler SettingsChanged;
}
