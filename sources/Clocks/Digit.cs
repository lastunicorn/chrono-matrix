using System.Windows;
using System.Windows.Controls;
using DustInTheWind.ClockWpf.Movements;
using DustInTheWind.ClockWpf.Templates;
using static System.TimeZoneInfo;

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

    #region MovementA Dependency Property

    public static readonly DependencyProperty MovementAProperty = DependencyProperty.Register(
        nameof(MovementA),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementA
    {
        get => (StaticMovement)GetValue(MovementAProperty);
        private set => SetValue(MovementAProperty, value);
    }

    #endregion

    #region MovementB Dependency Property

    public static readonly DependencyProperty MovementBProperty = DependencyProperty.Register(
        nameof(MovementB),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementB
    {
        get => (StaticMovement)GetValue(MovementBProperty);
        private set => SetValue(MovementBProperty, value);
    }

    #endregion

    #region MovementC Dependency Property

    public static readonly DependencyProperty MovementCProperty = DependencyProperty.Register(
        nameof(MovementC),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementC
    {
        get => (StaticMovement)GetValue(MovementCProperty);
        private set => SetValue(MovementCProperty, value);
    }

    #endregion

    #region MovementD Dependency Property

    public static readonly DependencyProperty MovementDProperty = DependencyProperty.Register(
        nameof(MovementD),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementD
    {
        get => (StaticMovement)GetValue(MovementDProperty);
        private set => SetValue(MovementDProperty, value);
    }

    #endregion

    #region MovementE Dependency Property

    public static readonly DependencyProperty MovementEProperty = DependencyProperty.Register(
        nameof(MovementE),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementE
    {
        get => (StaticMovement)GetValue(MovementEProperty);
        private set => SetValue(MovementEProperty, value);
    }

    #endregion

    #region MovementF Dependency Property

    public static readonly DependencyProperty MovementFProperty = DependencyProperty.Register(
        nameof(MovementF),
        typeof(StaticMovement),
        typeof(Digit),
        new PropertyMetadata(null));

    public StaticMovement MovementF
    {
        get => (StaticMovement)GetValue(MovementFProperty);
        private set => SetValue(MovementFProperty, value);
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
                digit.UpdateMovements(b);
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
        MovementA = new StaticMovement();
        MovementB = new StaticMovement();
        MovementC = new StaticMovement();
        MovementD = new StaticMovement();
        MovementE = new StaticMovement();
        MovementF = new StaticMovement();

        UpdateMovements(0);

        TimeSpan transitionTime = TimeSpan.FromSeconds(2);

        MovementA.TransitionInterval = transitionTime;
        MovementB.TransitionInterval = transitionTime;
        MovementC.TransitionInterval = transitionTime;
        MovementD.TransitionInterval = transitionTime;
        MovementE.TransitionInterval = transitionTime;
        MovementF.TransitionInterval = transitionTime;
    }

    private void UpdateMovements(byte b)
    {
        switch (b)
        {
            default:
            case 0:
                MovementA.Time = RD;
                MovementB.Time = LD;
                MovementC.Time = UD;
                MovementD.Time = UD;
                MovementE.Time = RU;
                MovementF.Time = LU;
                break;

            case 1:
                MovementA.Time = OFF;
                MovementB.Time = DD;
                MovementC.Time = OFF;
                MovementD.Time = UD;
                MovementE.Time = OFF;
                MovementF.Time = UU;
                break;

            case 2:
                MovementA.Time = RR;
                MovementB.Time = LD;
                MovementC.Time = RD;
                MovementD.Time = LU;
                MovementE.Time = RU;
                MovementF.Time = LL;
                break;

            case 3:
                MovementA.Time = RR;
                MovementB.Time = LD;
                MovementC.Time = RR;
                MovementD.Time = UD;
                MovementE.Time = RR;
                MovementF.Time = LU;
                break;

            case 4:
                MovementA.Time = DD;
                MovementB.Time = DD;
                MovementC.Time = RU;
                MovementD.Time = LD;
                MovementE.Time = OFF;
                MovementF.Time = UU;
                break;

            case 5:
                MovementA.Time = RD;
                MovementB.Time = LL;
                MovementC.Time = RU;
                MovementD.Time = LD;
                MovementE.Time = RR;
                MovementF.Time = LU;
                break;

            case 6:
                MovementA.Time = RD;
                MovementB.Time = LL;
                MovementC.Time = UD;
                MovementD.Time = LD;
                MovementE.Time = RU;
                MovementF.Time = LU;
                break;

            case 7:
                MovementA.Time = RR;
                MovementB.Time = LD;
                MovementC.Time = OFF;
                MovementD.Time = UD;
                MovementE.Time = OFF;
                MovementF.Time = UU;
                break;

            case 8:
                MovementA.Time = RD;
                MovementB.Time = LD;
                MovementC.Time = RD;
                MovementD.Time = LD;
                MovementE.Time = RU;
                MovementF.Time = LU;
                break;

            case 9:
                MovementA.Time = RD;
                MovementB.Time = LD;
                MovementC.Time = RU;
                MovementD.Time = UD;
                MovementE.Time = RR;
                MovementF.Time = LU;
                break;
        }
    }
}
