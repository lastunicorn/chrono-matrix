using System.Reflection;

namespace DustInTheWind.ChronoMatrix;

public class MainViewModel : ViewModelBase
{
    public string Version { get; }

    public ExitAppCommand ExitAppCommand { get; }

    public MainViewModel()
    {
        Version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3);
        ExitAppCommand = new ExitAppCommand();
    }
}
