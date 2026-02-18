using System.Windows;
using System.Windows.Media;
using DustInTheWind.ClockWpf.Shapes;

namespace DustInTheWind.ChronoMatrix.Controls.Templates;

internal class HideHands : Shape
{
    protected override void DoRender(ClockDrawingContext context)
    {
        Geometry geometry = CreateGeometry(context);

        context.DrawingContext.PushTransform(new RotateTransform(210));
        context.DrawingContext.DrawGeometry(Brushes.WhiteSmoke, null, geometry);
        context.DrawingContext.Pop();
    }

    private StreamGeometry CreateGeometry(ClockDrawingContext context)
    {
        double length = 80;
        double width = 22;

        double radius = context.ClockRadius;
        double calculatedLength = radius * (length / 100.0);
        double calculatedWidth = radius * (width / 100.0);
        double halfWidth = calculatedWidth / 2.0;

        StreamGeometry geometry = new();
        using (StreamGeometryContext ctx = geometry.Open())
        {
            ctx.BeginFigure(new Point(-halfWidth, 0), true, true);

            // Left side
            ctx.LineTo(new Point(-halfWidth, -calculatedLength), false, false);

            // Top side
            ctx.LineTo(new Point(halfWidth, -calculatedLength), false, false);

            // Right side
            ctx.LineTo(new Point(halfWidth, 0), false, false);

            // Bottom concave semicircle

            Point destinationPointP = new(-halfWidth, 0);
            Size radiusSize = new(halfWidth, halfWidth);
            ctx.ArcTo(destinationPointP, radiusSize, 0, false, SweepDirection.Counterclockwise, false, false);
        }

        if (geometry.CanFreeze)
            geometry.Freeze();

        return geometry;
    }
}