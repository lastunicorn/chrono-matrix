using System.Reflection;

namespace DustInTheWind.ChronoMatrix;

public class AboutViewModel : ViewModelBase
{
    public string Version { get; }

    public string CopyrightYear { get; }

    public AboutViewModel()
    {
        Assembly assembly = Assembly.GetEntryAssembly();
        Version = assembly?.GetName().Version?.ToString(3);

        AssemblyCopyrightAttribute copyrightAttribute = assembly?.GetCustomAttribute<AssemblyCopyrightAttribute>();
        CopyrightYear = ExtractCopyrightYear(copyrightAttribute?.Copyright);
    }

    private static string ExtractCopyrightYear(string copyright)
    {
        if (string.IsNullOrWhiteSpace(copyright))
            return DateTime.Now.Year.ToString();

        int startIndex = copyright.IndexOf("©");
        if (startIndex == -1)
            startIndex = copyright.IndexOf("(c)", StringComparison.OrdinalIgnoreCase);

        if (startIndex == -1)
            return DateTime.Now.Year.ToString();

        startIndex += startIndex == copyright.IndexOf("©") ? 1 : 3;

        string remaining = copyright.Substring(startIndex).Trim();
        string year = new string(remaining.TakeWhile(char.IsDigit).ToArray());

        return !string.IsNullOrEmpty(year) ? year : DateTime.Now.Year.ToString();
    }
}
