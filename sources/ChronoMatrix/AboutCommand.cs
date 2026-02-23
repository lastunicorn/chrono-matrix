using System.Windows;
using System.Windows.Input;

namespace DustInTheWind.ChronoMatrix;

public class AboutCommand : ICommand
{
    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        AboutWindow aboutWindow = new()
        {
            Owner = Application.Current.MainWindow,
            DataContext = new AboutViewModel()
        };

        aboutWindow.ShowDialog();
    }
}
