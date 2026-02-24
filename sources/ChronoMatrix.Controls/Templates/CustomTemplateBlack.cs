using System.Windows.Media;
using DustInTheWind.ClockWpf.Shapes;
using DustInTheWind.ClockWpf.Templates;

namespace DustInTheWind.ChronoMatrix.Controls.Templates;

internal class CustomTemplateBlack : ClockTemplate
{
    protected override IEnumerable<Shape> CreateShapes()
    {
        SolidColorBrush borderBrush = new(Color.FromRgb(0x30, 0x30, 0x30));

        if (borderBrush.CanFreeze)
            borderBrush.Freeze();

        FlatBackground background = new()
        {
            Name = "Background",
            FillBrush = Brushes.Black,
            StrokeThickness = 10,
            StrokeBrush = borderBrush
        };
        yield return background;

        BarHand hourHand = new()
        {
            Name = "Hour Hand",
            TimeComponent = TimeComponent.Hour,
            Length = 65,
            Width = 22,
            TailLength = 9,
            StrokeThickness = 0,
            FillBrush = Brushes.White,
            IntegralValue = true
        };
        yield return hourHand;

        BarHand minuteHand = new()
        {
            Name = "Minute Hand",
            TimeComponent = TimeComponent.Minute,
            Length = 80,
            Width = 22,
            TailLength = 9,
            StrokeThickness = 0,
            FillBrush = Brushes.White,
            IntegralValue = true
        };
        yield return minuteHand;
    }
}
