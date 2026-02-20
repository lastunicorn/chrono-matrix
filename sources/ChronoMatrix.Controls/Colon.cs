using System.Windows;
using System.Windows.Controls;

namespace DustInTheWind.ChronoMatrix.Controls;

public class Colon : Control
{
    #region IsOn DependencyProperty

    public static readonly DependencyProperty IsOnProperty = DependencyProperty.Register(
        nameof(IsOn),
        typeof(bool),
        typeof(Colon),
        new PropertyMetadata(true));

    public bool IsOn
    {
        get => (bool)GetValue(IsOnProperty);
        set => SetValue(IsOnProperty, value);
    }

    #endregion

    #region DotDiameter DependencyProperty

    public static readonly DependencyProperty DotDiameterProperty = DependencyProperty.Register(
        nameof(DotDiameter),
        typeof(double),
        typeof(Colon),
        new PropertyMetadata(70.0));

    public double DotDiameter
    {
        get => (double)GetValue(DotDiameterProperty);
        set => SetValue(DotDiameterProperty, value);
    }

    #endregion

    #region SpaceBetweenDots DependencyProperty

    public static readonly DependencyProperty SpaceBetweenDotsProperty = DependencyProperty.Register(
        nameof(SpaceBetweenDots),
        typeof(double),
        typeof(Colon),
        new PropertyMetadata(70.0, HandleSpaceBetweenDotsChanged));

    private static void HandleSpaceBetweenDotsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not Colon colon)
            return;

        if (e.NewValue is not double space)
            return;

        colon.SecondDotMargin = new Thickness(0, space, 0, 0);
    }

    public double SpaceBetweenDots
    {
        get => (double)GetValue(SpaceBetweenDotsProperty);
        set => SetValue(SpaceBetweenDotsProperty, value);
    }

    #endregion

    #region SecondDotMargin DependencyProperty

    private static readonly DependencyPropertyKey SecondDotMarginPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(SecondDotMargin),
        typeof(Thickness),
        typeof(Colon),
        new PropertyMetadata(new Thickness(0, 320, 0, 0)));

    public static readonly DependencyProperty SecondDotMarginProperty = SecondDotMarginPropertyKey.DependencyProperty;

    public Thickness SecondDotMargin
    {
        get => (Thickness)GetValue(SecondDotMarginProperty);
        private set => SetValue(SecondDotMarginPropertyKey, value);
    }

    #endregion

    static Colon()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Colon), new FrameworkPropertyMetadata(typeof(Colon)));
    }
}
