using System.Windows.Media;
using DustInTheWind.ClockWpf.Shapes;
using DustInTheWind.ClockWpf.Templates;

namespace DustInTheWind.Clocks.Templates;

internal class CustomTemplate : ClockTemplate
{
    protected override IEnumerable<Shape> CreateShapes()
    {
        FlatBackground background = new()
        {
            Name = "Background",
            FillBrush = Brushes.WhiteSmoke,
            StrokeThickness = 10,
            StrokeBrush = Brushes.LightGray
        };
        yield return background;

        CapsuleHand hourHand = new()
        {
            Name = "Hour Hand",
            TimeComponent = TimeComponent.Hour,
            Length = 65,
            Width = 18,
            TailLength = 9,
            StrokeThickness = 0,
            FillBrush = Brushes.Black,
            IntegralValue = true
        };
        yield return hourHand;

        CapsuleHand minuteHand = new()
        {
            Name = "Minute Hand",
            TimeComponent = TimeComponent.Minute,
            Length = 80,
            Width = 18,
            TailLength = 9,
            StrokeThickness = 0,
            FillBrush = Brushes.Black,
            IntegralValue = true
        };
        yield return minuteHand;

        yield return new HideHands
        {
            Name = "Scotch"
        };
    }
}
