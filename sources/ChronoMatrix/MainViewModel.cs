using System.Reflection;

namespace DustInTheWind.ChronoMatrix;

public class MainViewModel : ViewModelBase
{
    public string Version { get; private set; }

    public MainViewModel()
    {
        Version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3);
    }
}
