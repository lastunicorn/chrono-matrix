using System.Reflection;
using DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

namespace DustInTheWind.ChronoMatrix;

public class MainViewModel : ViewModelBase
{
    private readonly ISettings settings;

    public string Version { get; }

    public bool AreColonsBlinking
    {
        get => field;
        set
        {
            if (field == value)
                return;

            field = value;
            OnPropertyChanged();

            if (!IsInitializing)
                settings.BlinkingColons = value;
        }
    }

    public bool ShowSeconds
    {
        get => field;
        set
        {
            if (field == value)
                return;

            field = value;
            OnPropertyChanged();

            if (!IsInitializing)
                settings.ShowSeconds = value;
        }
    }

    public ExitAppCommand ExitAppCommand { get; }

    public MainViewModel(ISettings settings)
    {
        this.settings = settings ?? throw new ArgumentNullException(nameof(settings));

        Version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3);
        ExitAppCommand = new ExitAppCommand();

        LoadSettings();

        this.settings.SettingsChanged += HandleSettingsChanged;
    }

    private void LoadSettings()
    {
        Initialize(() =>
        {
            AreColonsBlinking = settings.BlinkingColons;
            ShowSeconds = settings.ShowSeconds;
        });
    }

    private void HandleSettingsChanged(object sender, EventArgs e)
    {
        LoadSettings();
    }
}
