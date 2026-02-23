namespace DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

public interface ISettings
{
    bool ShowSeconds { get; }

    bool BlinkingColons { get; }
    
    event EventHandler SettingsChanged;
}
