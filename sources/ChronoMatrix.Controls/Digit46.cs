using System.Windows;
using System.Windows.Controls;
using DustInTheWind.ClockWpf.Movements;
using DustInTheWind.ClockWpf.Templates;

namespace DustInTheWind.ChronoMatrix.Controls;

public class Digit46 : Control
{
    private static readonly TimeSpan UU = new(00, 00, 00);
    private static readonly TimeSpan UD = new(06, 00, 00);
    private static readonly TimeSpan DD = new(06, 30, 00);

    private static readonly TimeSpan LU = new(09, 00, 00);
    private static readonly TimeSpan RU = new(03, 00, 00);
    private static readonly TimeSpan RD = new(06, 15, 00);
    private static readonly TimeSpan LD = new(09, 30, 00);

    private static readonly TimeSpan RR = new(03, 15, 00);
    private static readonly TimeSpan LR = new(09, 15, 00);
    private static readonly TimeSpan LL = new(09, 45, 00);

    private static readonly TimeSpan OFF = new(07, 35, 00);

    #region ClockTemplate Dependency Property

    public static readonly DependencyProperty ClockTemplateProperty = DependencyProperty.Register(
        nameof(ClockTemplate),
        typeof(ClockTemplate),
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementF
    {
        get => (StaticMovement)GetValue(MovementFProperty);
        private set => SetValue(MovementFProperty, value);
    }

    #endregion

    #region MovementG Dependency Property

    public static readonly DependencyProperty MovementGProperty = DependencyProperty.Register(
        nameof(MovementG),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementG
    {
        get => (StaticMovement)GetValue(MovementGProperty);
        private set => SetValue(MovementGProperty, value);
    }

    #endregion

    #region MovementH Dependency Property

    public static readonly DependencyProperty MovementHProperty = DependencyProperty.Register(
        nameof(MovementH),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementH
    {
        get => (StaticMovement)GetValue(MovementHProperty);
        private set => SetValue(MovementHProperty, value);
    }

    #endregion

    #region MovementI Dependency Property

    public static readonly DependencyProperty MovementIProperty = DependencyProperty.Register(
        nameof(MovementI),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementI
    {
        get => (StaticMovement)GetValue(MovementIProperty);
        private set => SetValue(MovementIProperty, value);
    }

    #endregion

    #region MovementJ Dependency Property

    public static readonly DependencyProperty MovementJProperty = DependencyProperty.Register(
        nameof(MovementJ),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementJ
    {
        get => (StaticMovement)GetValue(MovementJProperty);
        private set => SetValue(MovementJProperty, value);
    }

    #endregion

    #region MovementK Dependency Property

    public static readonly DependencyProperty MovementKProperty = DependencyProperty.Register(
        nameof(MovementK),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementK
    {
        get => (StaticMovement)GetValue(MovementKProperty);
        private set => SetValue(MovementKProperty, value);
    }

    #endregion

    #region MovementL Dependency Property

    public static readonly DependencyProperty MovementLProperty = DependencyProperty.Register(
        nameof(MovementL),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementL
    {
        get => (StaticMovement)GetValue(MovementLProperty);
        private set => SetValue(MovementLProperty, value);
    }

    #endregion

    #region MovementM Dependency Property

    public static readonly DependencyProperty MovementMProperty = DependencyProperty.Register(
        nameof(MovementM),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementM
    {
        get => (StaticMovement)GetValue(MovementMProperty);
        private set => SetValue(MovementMProperty, value);
    }

    #endregion

    #region MovementN Dependency Property

    public static readonly DependencyProperty MovementNProperty = DependencyProperty.Register(
        nameof(MovementN),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementN
    {
        get => (StaticMovement)GetValue(MovementNProperty);
        private set => SetValue(MovementNProperty, value);
    }

    #endregion

    #region MovementO Dependency Property

    public static readonly DependencyProperty MovementOProperty = DependencyProperty.Register(
        nameof(MovementO),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementO
    {
        get => (StaticMovement)GetValue(MovementOProperty);
        private set => SetValue(MovementOProperty, value);
    }

    #endregion

    #region MovementP Dependency Property

    public static readonly DependencyProperty MovementPProperty = DependencyProperty.Register(
        nameof(MovementP),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementP
    {
        get => (StaticMovement)GetValue(MovementPProperty);
        private set => SetValue(MovementPProperty, value);
    }

    #endregion

    #region MovementQ Dependency Property

    public static readonly DependencyProperty MovementQProperty = DependencyProperty.Register(
        nameof(MovementQ),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementQ
    {
        get => (StaticMovement)GetValue(MovementQProperty);
        private set => SetValue(MovementQProperty, value);
    }

    #endregion

    #region MovementR Dependency Property

    public static readonly DependencyProperty MovementRProperty = DependencyProperty.Register(
        nameof(MovementR),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementR
    {
        get => (StaticMovement)GetValue(MovementRProperty);
        private set => SetValue(MovementRProperty, value);
    }

    #endregion

    #region MovementS Dependency Property

    public static readonly DependencyProperty MovementSProperty = DependencyProperty.Register(
        nameof(MovementS),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementS
    {
        get => (StaticMovement)GetValue(MovementSProperty);
        private set => SetValue(MovementSProperty, value);
    }

    #endregion

    #region MovementT Dependency Property

    public static readonly DependencyProperty MovementTProperty = DependencyProperty.Register(
        nameof(MovementT),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementT
    {
        get => (StaticMovement)GetValue(MovementTProperty);
        private set => SetValue(MovementTProperty, value);
    }

    #endregion

    #region MovementU Dependency Property

    public static readonly DependencyProperty MovementUProperty = DependencyProperty.Register(
        nameof(MovementU),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementU
    {
        get => (StaticMovement)GetValue(MovementUProperty);
        private set => SetValue(MovementUProperty, value);
    }

    #endregion

    #region MovementV Dependency Property

    public static readonly DependencyProperty MovementVProperty = DependencyProperty.Register(
        nameof(MovementV),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementV
    {
        get => (StaticMovement)GetValue(MovementVProperty);
        private set => SetValue(MovementVProperty, value);
    }

    #endregion

    #region MovementW Dependency Property

    public static readonly DependencyProperty MovementWProperty = DependencyProperty.Register(
        nameof(MovementW),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementW
    {
        get => (StaticMovement)GetValue(MovementWProperty);
        private set => SetValue(MovementWProperty, value);
    }

    #endregion

    #region MovementX Dependency Property

    public static readonly DependencyProperty MovementXProperty = DependencyProperty.Register(
        nameof(MovementX),
        typeof(StaticMovement),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticMovement MovementX
    {
        get => (StaticMovement)GetValue(MovementXProperty);
        private set => SetValue(MovementXProperty, value);
    }

    #endregion

    #region Value Dependency Property

    public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
        nameof(Value),
        typeof(byte),
        typeof(Digit46),
        new PropertyMetadata((byte)0, HandleValueChanged));

    private static void HandleValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is Digit46 digit)
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
        typeof(Digit46),
        new PropertyMetadata(4000.0, HandleTransitionSpeedChanged));

    private static void HandleTransitionSpeedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not Digit46 digit)
            return;

        digit.UpdateTransitionSpeeds();
    }

    public double TransitionSpeed
    {
        get => (double)GetValue(TransitionSpeedProperty);
        set => SetValue(TransitionSpeedProperty, value);
    }

    #endregion

    static Digit46()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Digit46), new FrameworkPropertyMetadata(typeof(Digit46)));
    }

    public Digit46()
    {
        MovementA = new StaticMovement();
        MovementB = new StaticMovement();
        MovementC = new StaticMovement();
        MovementD = new StaticMovement();
        MovementE = new StaticMovement();
        MovementF = new StaticMovement();
        MovementG = new StaticMovement();
        MovementH = new StaticMovement();
        MovementI = new StaticMovement();
        MovementJ = new StaticMovement();
        MovementK = new StaticMovement();
        MovementL = new StaticMovement();
        MovementM = new StaticMovement();
        MovementN = new StaticMovement();
        MovementO = new StaticMovement();
        MovementP = new StaticMovement();
        MovementQ = new StaticMovement();
        MovementR = new StaticMovement();
        MovementS = new StaticMovement();
        MovementT = new StaticMovement();
        MovementU = new StaticMovement();
        MovementV = new StaticMovement();
        MovementW = new StaticMovement();
        MovementX = new StaticMovement();

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
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = RD;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = UD;
                MovementJ.Time = UD;
                MovementK.Time = UD;
                MovementL.Time = UD;

                MovementM.Time = UD;
                MovementN.Time = UD;
                MovementO.Time = UD;
                MovementP.Time = UD;

                MovementQ.Time = UD;
                MovementR.Time = RU;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 1:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LD;
                MovementD.Time = OFF;

                MovementE.Time = RU;
                MovementF.Time = LD;
                MovementG.Time = UD;
                MovementH.Time = OFF;

                MovementI.Time = OFF;
                MovementJ.Time = UD;
                MovementK.Time = UD;
                MovementL.Time = OFF;

                MovementM.Time = OFF;
                MovementN.Time = UD;
                MovementO.Time = UD;
                MovementP.Time = OFF;

                MovementQ.Time = RD;
                MovementR.Time = LU;
                MovementS.Time = RU;
                MovementT.Time = LD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 2:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = RU;
                MovementF.Time = LR;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = RD;
                MovementJ.Time = LR;
                MovementK.Time = LU;
                MovementL.Time = UD;

                MovementM.Time = UD;
                MovementN.Time = RD;
                MovementO.Time = LR;
                MovementP.Time = LU;

                MovementQ.Time = UD;
                MovementR.Time = RU;
                MovementS.Time = LR;
                MovementT.Time = LD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 3:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = RU;
                MovementF.Time = LR;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = OFF;
                MovementJ.Time = RD;
                MovementK.Time = LU;
                MovementL.Time = UD;

                MovementM.Time = OFF;
                MovementN.Time = RU;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = RD;
                MovementR.Time = LR;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 4:
                MovementA.Time = RD;
                MovementB.Time = LD;
                MovementC.Time = RD;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = UD;
                MovementG.Time = UD;
                MovementH.Time = UD;

                MovementI.Time = UD;
                MovementJ.Time = RU;
                MovementK.Time = LU;
                MovementL.Time = UD;

                MovementM.Time = RU;
                MovementN.Time = LR;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = OFF;
                MovementR.Time = OFF;
                MovementS.Time = UD;
                MovementT.Time = UD;

                MovementU.Time = OFF;
                MovementV.Time = OFF;
                MovementW.Time = RU;
                MovementX.Time = LU;
                break;

            case 5:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = RD;
                MovementG.Time = LR;
                MovementH.Time = LU;

                MovementI.Time = UD;
                MovementJ.Time = RU;
                MovementK.Time = LR;
                MovementL.Time = LD;

                MovementM.Time = RU;
                MovementN.Time = LR;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = RD;
                MovementR.Time = LR;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 6:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = RD;
                MovementG.Time = LR;
                MovementH.Time = LU;

                MovementI.Time = UD;
                MovementJ.Time = RU;
                MovementK.Time = LR;
                MovementL.Time = LD;

                MovementM.Time = UD;
                MovementN.Time = RD;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = UD;
                MovementR.Time = RU;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 7:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = RU;
                MovementF.Time = LR;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = OFF;
                MovementJ.Time = OFF;
                MovementK.Time = UD;
                MovementL.Time = UD;

                MovementM.Time = OFF;
                MovementN.Time = OFF;
                MovementO.Time = UD;
                MovementP.Time = UD;

                MovementQ.Time = OFF;
                MovementR.Time = OFF;
                MovementS.Time = UD;
                MovementT.Time = UD;

                MovementU.Time = OFF;
                MovementV.Time = OFF;
                MovementW.Time = RU;
                MovementX.Time = LU;
                break;

            case 8:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = RD;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = UD;
                MovementJ.Time = RU;
                MovementK.Time = LU;
                MovementL.Time = UD;

                MovementM.Time = UD;
                MovementN.Time = RD;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = UD;
                MovementR.Time = RU;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
                break;

            case 9:
                MovementA.Time = RD;
                MovementB.Time = LR;
                MovementC.Time = LR;
                MovementD.Time = LD;

                MovementE.Time = UD;
                MovementF.Time = RD;
                MovementG.Time = LD;
                MovementH.Time = UD;

                MovementI.Time = UD;
                MovementJ.Time = RU;
                MovementK.Time = LU;
                MovementL.Time = UD;

                MovementM.Time = RU;
                MovementN.Time = LR;
                MovementO.Time = LD;
                MovementP.Time = UD;

                MovementQ.Time = RD;
                MovementR.Time = LR;
                MovementS.Time = LU;
                MovementT.Time = UD;

                MovementU.Time = RU;
                MovementV.Time = LR;
                MovementW.Time = LR;
                MovementX.Time = LU;
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
        MovementG.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementH.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementI.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementJ.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementK.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementL.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementM.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementN.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementO.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementP.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementQ.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementR.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementS.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementT.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementU.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementV.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementW.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
        MovementX.TransitionSpeed = TransitionSpeed + Random.Shared.Next(1000);
    }
}
