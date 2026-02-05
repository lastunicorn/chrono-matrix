using System.Windows;
using System.Windows.Controls;
using DustInTheWind.ClockWpf.Templates;
using DustInTheWind.ClockWpf.TimeProviders;

namespace DustInTheWind.Clocks;

public class Digit : Control
{
    private static readonly TimeSpan UU = new(00, 00, 00);
    private static readonly TimeSpan UD = new(00, 30, 00);
    private static readonly TimeSpan DD = new(06, 30, 00);

    private static readonly TimeSpan LU = new(00, 45, 00);
    private static readonly TimeSpan RU = new(00, 15, 00);
    private static readonly TimeSpan RD = new(03, 30, 00);
    private static readonly TimeSpan LD = new(09, 30, 00);

    private static readonly TimeSpan RR = new(03, 15, 00);
    private static readonly TimeSpan LL = new(09, 45, 00);

    private static readonly TimeSpan OFF = new(07, 35, 00);

    #region ClockTemplate Dependency Property

    public static readonly DependencyProperty ClockTemplateProperty = DependencyProperty.Register(
        nameof(ClockTemplate),
        typeof(ClockTemplate),
        typeof(Digit),
        new PropertyMetadata(null));

    public ClockTemplate ClockTemplate
    {
        get => (ClockTemplate)GetValue(ClockTemplateProperty);
        set => SetValue(ClockTemplateProperty, value);
    }

    #endregion

    #region TimeProviderA Dependency Property

    public static readonly DependencyProperty TimeProviderAProperty = DependencyProperty.Register(
        nameof(TimeProviderA),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderA
    {
        get => (StaticTimeProvider)GetValue(TimeProviderAProperty);
        private set => SetValue(TimeProviderAProperty, value);
    }

    #endregion

    #region TimeProviderB Dependency Property

    public static readonly DependencyProperty TimeProviderBProperty = DependencyProperty.Register(
        nameof(TimeProviderB),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderB
    {
        get => (StaticTimeProvider)GetValue(TimeProviderBProperty);
        private set => SetValue(TimeProviderBProperty, value);
    }

    #endregion

    #region TimeProviderC Dependency Property

    public static readonly DependencyProperty TimeProviderCProperty = DependencyProperty.Register(
        nameof(TimeProviderC),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderC
    {
        get => (StaticTimeProvider)GetValue(TimeProviderCProperty);
        private set => SetValue(TimeProviderCProperty, value);
    }

    #endregion

    #region TimeProviderD Dependency Property

    public static readonly DependencyProperty TimeProviderDProperty = DependencyProperty.Register(
        nameof(TimeProviderD),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderD
    {
        get => (StaticTimeProvider)GetValue(TimeProviderDProperty);
        private set => SetValue(TimeProviderDProperty, value);
    }

    #endregion

    #region TimeProviderE Dependency Property

    public static readonly DependencyProperty TimeProviderEProperty = DependencyProperty.Register(
        nameof(TimeProviderE),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderE
    {
        get => (StaticTimeProvider)GetValue(TimeProviderEProperty);
        private set => SetValue(TimeProviderEProperty, value);
    }

    #endregion

    #region TimeProviderF Dependency Property

    public static readonly DependencyProperty TimeProviderFProperty = DependencyProperty.Register(
        nameof(TimeProviderF),
        typeof(StaticTimeProvider),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderF
    {
        get => (StaticTimeProvider)GetValue(TimeProviderFProperty);
        private set => SetValue(TimeProviderFProperty, value);
    }

    #endregion

    #region Value Dependency Property

    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        nameof(Value),
        typeof(byte),
        typeof(Digit),
        new PropertyMetadata((byte)0, HandleValueChanged));

    private static void HandleValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Digit digit)
        {
            if (e.NewValue is byte b)
                digit.UpdateTimeProviders(b);
        }
    }

    public byte Value
    {
        get => (byte)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    #endregion

    static Digit()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Digit), new FrameworkPropertyMetadata(typeof(Digit)));
    }

    public Digit()
    {
        TimeProviderA = new StaticTimeProvider();
        TimeProviderB = new StaticTimeProvider();
        TimeProviderC = new StaticTimeProvider();
        TimeProviderD = new StaticTimeProvider();
        TimeProviderE = new StaticTimeProvider();
        TimeProviderF = new StaticTimeProvider();

        UpdateTimeProviders(0);
    }

    private void UpdateTimeProviders(byte b)
    {
        switch (b)
        {
            default:
            case 0:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = UD;
                TimeProviderD.Time = UD;
                TimeProviderE.Time = RU;
                TimeProviderF.Time = LU;
                break;

            case 1:
                TimeProviderA.Time = OFF;
                TimeProviderB.Time = DD;
                TimeProviderC.Time = OFF;
                TimeProviderD.Time = UD;
                TimeProviderE.Time = OFF;
                TimeProviderF.Time = UU;
                break;

            case 2:
                TimeProviderA.Time = RR;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = RD;
                TimeProviderD.Time = LU;
                TimeProviderE.Time = RU;
                TimeProviderF.Time = LL;
                break;

            case 3:
                TimeProviderA.Time = RR;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = RR;
                TimeProviderD.Time = UD;
                TimeProviderE.Time = RR;
                TimeProviderF.Time = LU;
                break;

            case 4:
                TimeProviderA.Time = DD;
                TimeProviderB.Time = DD;
                TimeProviderC.Time = RU;
                TimeProviderD.Time = LD;
                TimeProviderE.Time = OFF;
                TimeProviderF.Time = UU;
                break;

            case 5:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LL;
                TimeProviderC.Time = RU;
                TimeProviderD.Time = LD;
                TimeProviderE.Time = RR;
                TimeProviderF.Time = LU;
                break;

            case 6:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LL;
                TimeProviderC.Time = UD;
                TimeProviderD.Time = LD;
                TimeProviderE.Time = RU;
                TimeProviderF.Time = LU;
                break;

            case 7:
                TimeProviderA.Time = RR;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = OFF;
                TimeProviderD.Time = UD;
                TimeProviderE.Time = OFF;
                TimeProviderF.Time = UU;
                break;

            case 8:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = RD;
                TimeProviderD.Time = LD;
                TimeProviderE.Time = RU;
                TimeProviderF.Time = LU;
                break;

            case 9:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = RU;
                TimeProviderD.Time = UD;
                TimeProviderE.Time = RR;
                TimeProviderF.Time = LU;
                break;
        }
    }
}
