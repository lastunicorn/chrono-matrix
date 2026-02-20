using System.Windows;
using System.Windows.Controls;
using DustInTheWind.ClockWpf.Movements;
using DustInTheWind.ClockWpf.Templates;

namespace DustInTheWind.ChronoMatrix.Controls;

public class Digit23 : Control
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
        typeof(Digit23),
        new PropertyMetadata(null));

    public ClockTemplate ClockTemplate
    {
        get => (ClockTemplate)GetValue(ClockTemplateProperty);
        set => SetValue(ClockTemplateProperty, value);
    }

    #endregion

    #region MovementA Dependency Property

    private static readonly DependencyPropertyKey MovementAPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementA),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementAProperty = MovementAPropertyKey.DependencyProperty;

    public StaticMovement MovementA
    {
        get => (StaticMovement)GetValue(MovementAProperty);
        private set => SetValue(MovementAPropertyKey, value);
    }

    #endregion

    #region MovementB Dependency Property

    private static readonly DependencyPropertyKey MovementBPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementB),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementBProperty = MovementBPropertyKey.DependencyProperty;

    public StaticMovement MovementB
    {
        get => (StaticMovement)GetValue(MovementBProperty);
        private set => SetValue(MovementBPropertyKey, value);
    }

    #endregion

    #region MovementC Dependency Property

    private static readonly DependencyPropertyKey MovementCPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementC),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementCProperty = MovementCPropertyKey.DependencyProperty;

    public StaticMovement MovementC
    {
        get => (StaticMovement)GetValue(MovementCProperty);
        private set => SetValue(MovementCPropertyKey, value);
    }

    #endregion

    #region MovementD Dependency Property

    private static readonly DependencyPropertyKey MovementDPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementD),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementDProperty = MovementDPropertyKey.DependencyProperty;

    public StaticMovement MovementD
    {
        get => (StaticMovement)GetValue(MovementDProperty);
        private set => SetValue(MovementDPropertyKey, value);
    }

    #endregion

    #region MovementE Dependency Property

    private static readonly DependencyPropertyKey MovementEPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementE),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementEProperty = MovementEPropertyKey.DependencyProperty;

    public StaticMovement MovementE
    {
        get => (StaticMovement)GetValue(MovementEProperty);
        private set => SetValue(MovementEPropertyKey, value);
    }

    #endregion

    #region MovementF Dependency Property

    private static readonly DependencyPropertyKey MovementFPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(MovementF),
        typeof(StaticMovement),
        typeof(Digit23),
        new PropertyMetadata(null));

    public static readonly DependencyProperty MovementFProperty = MovementFPropertyKey.DependencyProperty;

    public StaticMovement MovementF
    {
        get => (StaticMovement)GetValue(MovementFProperty);
        private set => SetValue(MovementFPropertyKey, value);
    }

    #endregion

    #region Value Dependency Property

    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        nameof(Value),
        typeof(byte),
        typeof(Digit23),
        new PropertyMetadata((byte)0, HandleValueChanged));

    private static void HandleValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Digit23 digit)
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

    #region TransitionSpeed Dependency Property

    public static readonly DependencyProperty TransitionSpeedProperty = DependencyProperty.Register(
        nameof(TransitionSpeed),
        typeof(double),
        typeof(Digit23),
        new PropertyMetadata(4000.0, HandleTransitionSpeedChanged));

    private static void HandleTransitionSpeedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not Digit23 digit)
            return;

        digit.UpdateTransitionSpeeds();
    }

    public double TransitionSpeed
    {
        get => (double)GetValue(TransitionSpeedProperty);
        set => SetValue(TransitionSpeedProperty, value);
    }

    #endregion

    static Digit23()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Digit23), new FrameworkPropertyMetadata(typeof(Digit23)));
    }

    public Digit23()
    {
        MovementA = new StaticMovement();
        MovementB = new StaticMovement();
        MovementC = new StaticMovement();
        MovementD = new StaticMovement();
        MovementE = new StaticMovement();
        MovementF = new StaticMovement();

        UpdateMovements(0);
        UpdateTransitionSpeeds();
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

    private void UpdateTransitionSpeeds()
    {
        MovementA.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementB.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementC.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementD.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementE.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementF.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
    }
}
