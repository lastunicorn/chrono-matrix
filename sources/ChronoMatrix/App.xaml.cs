using System.IO;
using System.Windows;
using DustInTheWind.ChronoMatrix.Ports.SettingsAccess;

namespace DustInTheWind.ChronoMatrix
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            string appSettingsFilePath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
            ISettings settings = new Settings(appSettingsFilePath);

            MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(settings)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
