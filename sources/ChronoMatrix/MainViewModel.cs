using System.Reflection;

namespace DustInTheWind.ChronoMatrix;

public class MainViewModel : ViewModelBase
{
    public string Version { get; }

    public ExitAppCommand ExitAppCommand { get; }

    public bool AreColonsBlinking
    {
        get => field;
        set
        {
            if (field == value)
                return;

            field = value;
            OnPropertyChanged();
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
        }
    }

    public MainViewModel()
    {
        Version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3);
        ExitAppCommand = new ExitAppCommand();

        AreColonsBlinking = true;
        ShowSeconds = false;
    }
}
