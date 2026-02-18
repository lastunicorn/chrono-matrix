using System.Windows;
using System.Windows.Controls;

namespace DustInTheWind.ChronoMatrix;

public class ShyControl : ContentControl
{
    static ShyControl()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ShyControl), new FrameworkPropertyMetadata(typeof(ShyControl)));
    }
}
