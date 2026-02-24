using System.Windows;
using System.Windows.Controls;

namespace DustInTheWind.ChronoMatrix;

public class OverlayPanel : Panel
{
    protected override Size MeasureOverride(Size availableSize)
    {
        Size maxChildSize = new();

        foreach (UIElement child in InternalChildren)
        {
            Thickness margin = GetMargin(child);
            
            Size childAvailableSize = new(
                Math.Max(0, availableSize.Width - margin.Left - margin.Right),
                Math.Max(0, availableSize.Height - margin.Top - margin.Bottom));
            
            child.Measure(childAvailableSize);
            
            Size childSizeWithMargin = new(
                child.DesiredSize.Width + margin.Left + margin.Right,
                child.DesiredSize.Height + margin.Top + margin.Bottom);
            
            maxChildSize.Width = Math.Max(maxChildSize.Width, childSizeWithMargin.Width);
            maxChildSize.Height = Math.Max(maxChildSize.Height, childSizeWithMargin.Height);
        }

        return maxChildSize;
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        foreach (UIElement child in InternalChildren)
        {
            HorizontalAlignment horizontalAlignment = GetHorizontalAlignment(child);
            VerticalAlignment verticalAlignment = GetVerticalAlignment(child);
            
            Thickness margin = GetMargin(child);
            Size desiredSizeWithoutMargin = child.DesiredSize;
            
            double childWidth;
            double childHeight;
            double x;
            double y;
            
            if (horizontalAlignment == HorizontalAlignment.Stretch)
            {
                childWidth = Math.Max(0, finalSize.Width - margin.Left - margin.Right);
                x = margin.Left;
            }
            else
            {
                childWidth = desiredSizeWithoutMargin.Width;
                
                x = horizontalAlignment switch
                {
                    HorizontalAlignment.Left => margin.Left,
                    HorizontalAlignment.Center => (finalSize.Width - childWidth) / 2,
                    HorizontalAlignment.Right => finalSize.Width - childWidth - margin.Right,
                    _ => margin.Left
                };
            }
            
            if (verticalAlignment == VerticalAlignment.Stretch)
            {
                childHeight = Math.Max(0, finalSize.Height - margin.Top - margin.Bottom);
                y = margin.Top;
            }
            else
            {
                childHeight = desiredSizeWithoutMargin.Height;
                
                y = verticalAlignment switch
                {
                    VerticalAlignment.Top => margin.Top,
                    VerticalAlignment.Center => (finalSize.Height - childHeight) / 2,
                    VerticalAlignment.Bottom => finalSize.Height - childHeight - margin.Bottom,
                    _ => margin.Top
                };
            }
            
            child.Arrange(new Rect(x, y, childWidth, childHeight));
        }

        return finalSize;
    }

    private static HorizontalAlignment GetHorizontalAlignment(UIElement element)
    {
        if (element is FrameworkElement frameworkElement)
            return frameworkElement.HorizontalAlignment;
        
        return HorizontalAlignment.Stretch;
    }

    private static VerticalAlignment GetVerticalAlignment(UIElement element)
    {
        if (element is FrameworkElement frameworkElement)
            return frameworkElement.VerticalAlignment;
        
        return VerticalAlignment.Stretch;
    }

    private static Thickness GetMargin(UIElement element)
    {
        if (element is FrameworkElement frameworkElement)
            return frameworkElement.Margin;
        
        return new Thickness(0);
    }
}
