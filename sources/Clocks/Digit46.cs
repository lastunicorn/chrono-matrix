using System;
using System.Windows;
using System.Windows.Controls;
using DustInTheWind.ClockWpf.Templates;
using DustInTheWind.ClockWpf.TimeProviders;

namespace DustInTheWind.Clocks;

public class Digit46 : Control
{
    private static readonly TimeSpan UU = new(00, 00, 00);
    private static readonly TimeSpan UD = new(00, 30, 00);
    private static readonly TimeSpan DD = new(06, 30, 00);

    private static readonly TimeSpan LU = new(00, 45, 00);
    private static readonly TimeSpan RU = new(00, 15, 00);
    private static readonly TimeSpan RD = new(03, 30, 00);
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

    #region TimeProviderA Dependency Property

    public static readonly DependencyProperty TimeProviderAProperty = DependencyProperty.Register(
        nameof(TimeProviderA),
        typeof(StaticTimeProvider),
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
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
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderF
    {
        get => (StaticTimeProvider)GetValue(TimeProviderFProperty);
        private set => SetValue(TimeProviderFProperty, value);
    }

    #endregion

    #region TimeProviderG Dependency Property

    public static readonly DependencyProperty TimeProviderGProperty = DependencyProperty.Register(
        nameof(TimeProviderG),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderG
    {
        get => (StaticTimeProvider)GetValue(TimeProviderGProperty);
        private set => SetValue(TimeProviderGProperty, value);
    }

    #endregion

    #region TimeProviderH Dependency Property

    public static readonly DependencyProperty TimeProviderHProperty = DependencyProperty.Register(
        nameof(TimeProviderH),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderH
    {
        get => (StaticTimeProvider)GetValue(TimeProviderHProperty);
        private set => SetValue(TimeProviderHProperty, value);
    }

    #endregion

    #region TimeProviderI Dependency Property

    public static readonly DependencyProperty TimeProviderIProperty = DependencyProperty.Register(
        nameof(TimeProviderI),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderI
    {
        get => (StaticTimeProvider)GetValue(TimeProviderIProperty);
        private set => SetValue(TimeProviderIProperty, value);
    }

    #endregion

    #region TimeProviderJ Dependency Property

    public static readonly DependencyProperty TimeProviderJProperty = DependencyProperty.Register(
        nameof(TimeProviderJ),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderJ
    {
        get => (StaticTimeProvider)GetValue(TimeProviderJProperty);
        private set => SetValue(TimeProviderJProperty, value);
    }

    #endregion

    #region TimeProviderK Dependency Property

    public static readonly DependencyProperty TimeProviderKProperty = DependencyProperty.Register(
        nameof(TimeProviderK),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderK
    {
        get => (StaticTimeProvider)GetValue(TimeProviderKProperty);
        private set => SetValue(TimeProviderKProperty, value);
    }

    #endregion

    #region TimeProviderL Dependency Property

    public static readonly DependencyProperty TimeProviderLProperty = DependencyProperty.Register(
        nameof(TimeProviderL),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderL
    {
        get => (StaticTimeProvider)GetValue(TimeProviderLProperty);
        private set => SetValue(TimeProviderLProperty, value);
    }

    #endregion

    #region TimeProviderM Dependency Property

    public static readonly DependencyProperty TimeProviderMProperty = DependencyProperty.Register(
        nameof(TimeProviderM),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderM
    {
        get => (StaticTimeProvider)GetValue(TimeProviderMProperty);
        private set => SetValue(TimeProviderMProperty, value);
    }

    #endregion

    #region TimeProviderN Dependency Property

    public static readonly DependencyProperty TimeProviderNProperty = DependencyProperty.Register(
        nameof(TimeProviderN),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderN
    {
        get => (StaticTimeProvider)GetValue(TimeProviderNProperty);
        private set => SetValue(TimeProviderNProperty, value);
    }

    #endregion

    #region TimeProviderO Dependency Property

    public static readonly DependencyProperty TimeProviderOProperty = DependencyProperty.Register(
        nameof(TimeProviderO),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderO
    {
        get => (StaticTimeProvider)GetValue(TimeProviderOProperty);
        private set => SetValue(TimeProviderOProperty, value);
    }

    #endregion

    #region TimeProviderP Dependency Property

    public static readonly DependencyProperty TimeProviderPProperty = DependencyProperty.Register(
        nameof(TimeProviderP),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderP
    {
        get => (StaticTimeProvider)GetValue(TimeProviderPProperty);
        private set => SetValue(TimeProviderPProperty, value);
    }

    #endregion

    #region TimeProviderQ Dependency Property

    public static readonly DependencyProperty TimeProviderQProperty = DependencyProperty.Register(
        nameof(TimeProviderQ),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderQ
    {
        get => (StaticTimeProvider)GetValue(TimeProviderQProperty);
        private set => SetValue(TimeProviderQProperty, value);
    }

    #endregion

    #region TimeProviderR Dependency Property

    public static readonly DependencyProperty TimeProviderRProperty = DependencyProperty.Register(
        nameof(TimeProviderR),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderR
    {
        get => (StaticTimeProvider)GetValue(TimeProviderRProperty);
        private set => SetValue(TimeProviderRProperty, value);
    }

    #endregion

    #region TimeProviderS Dependency Property

    public static readonly DependencyProperty TimeProviderSProperty = DependencyProperty.Register(
        nameof(TimeProviderS),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderS
    {
        get => (StaticTimeProvider)GetValue(TimeProviderSProperty);
        private set => SetValue(TimeProviderSProperty, value);
    }

    #endregion

    #region TimeProviderT Dependency Property

    public static readonly DependencyProperty TimeProviderTProperty = DependencyProperty.Register(
        nameof(TimeProviderT),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderT
    {
        get => (StaticTimeProvider)GetValue(TimeProviderTProperty);
        private set => SetValue(TimeProviderTProperty, value);
    }

    #endregion

    #region TimeProviderU Dependency Property

    public static readonly DependencyProperty TimeProviderUProperty = DependencyProperty.Register(
        nameof(TimeProviderU),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderU
    {
        get => (StaticTimeProvider)GetValue(TimeProviderUProperty);
        private set => SetValue(TimeProviderUProperty, value);
    }

    #endregion

    #region TimeProviderV Dependency Property

    public static readonly DependencyProperty TimeProviderVProperty = DependencyProperty.Register(
        nameof(TimeProviderV),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderV
    {
        get => (StaticTimeProvider)GetValue(TimeProviderVProperty);
        private set => SetValue(TimeProviderVProperty, value);
    }

    #endregion

    #region TimeProviderW Dependency Property

    public static readonly DependencyProperty TimeProviderWProperty = DependencyProperty.Register(
        nameof(TimeProviderW),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderW
    {
        get => (StaticTimeProvider)GetValue(TimeProviderWProperty);
        private set => SetValue(TimeProviderWProperty, value);
    }

    #endregion

    #region TimeProviderX Dependency Property

    public static readonly DependencyProperty TimeProviderXProperty = DependencyProperty.Register(
        nameof(TimeProviderX),
        typeof(StaticTimeProvider),
        typeof(Digit46),
        new PropertyMetadata(null));

    public StaticTimeProvider TimeProviderX
    {
        get => (StaticTimeProvider)GetValue(TimeProviderXProperty);
        private set => SetValue(TimeProviderXProperty, value);
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
                digit.UpdateTimeProviders(b);
        }
    }

    public byte Value
    {
        get => (byte)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    #endregion

    static Digit46()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(Digit46), new FrameworkPropertyMetadata(typeof(Digit46)));
    }

    public Digit46()
    {
        TimeProviderA = new StaticTimeProvider();
        TimeProviderB = new StaticTimeProvider();
        TimeProviderC = new StaticTimeProvider();
        TimeProviderD = new StaticTimeProvider();
        TimeProviderE = new StaticTimeProvider();
        TimeProviderF = new StaticTimeProvider();
        TimeProviderG = new StaticTimeProvider();
        TimeProviderH = new StaticTimeProvider();
        TimeProviderI = new StaticTimeProvider();
        TimeProviderJ = new StaticTimeProvider();
        TimeProviderK = new StaticTimeProvider();
        TimeProviderL = new StaticTimeProvider();
        TimeProviderM = new StaticTimeProvider();
        TimeProviderN = new StaticTimeProvider();
        TimeProviderO = new StaticTimeProvider();
        TimeProviderP = new StaticTimeProvider();
        TimeProviderQ = new StaticTimeProvider();
        TimeProviderR = new StaticTimeProvider();
        TimeProviderS = new StaticTimeProvider();
        TimeProviderT = new StaticTimeProvider();
        TimeProviderU = new StaticTimeProvider();
        TimeProviderV = new StaticTimeProvider();
        TimeProviderW = new StaticTimeProvider();
        TimeProviderX = new StaticTimeProvider();

        UpdateTimeProviders(0);
    }

    private void UpdateTimeProviders(byte b)
    {
        switch (b)
        {
            default:
            case 0:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = RD;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = UD;
                TimeProviderK.Time = UD;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = UD;
                TimeProviderN.Time = UD;
                TimeProviderO.Time = UD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = UD;
                TimeProviderR.Time = RU;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 1:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LD;
                TimeProviderD.Time = OFF;

                TimeProviderE.Time = RU;
                TimeProviderF.Time = LD;
                TimeProviderG.Time = UD;
                TimeProviderH.Time = OFF;

                TimeProviderI.Time = OFF;
                TimeProviderJ.Time = UD;
                TimeProviderK.Time = UD;
                TimeProviderL.Time = OFF;

                TimeProviderM.Time = OFF;
                TimeProviderN.Time = UD;
                TimeProviderO.Time = UD;
                TimeProviderP.Time = OFF;

                TimeProviderQ.Time = RD;
                TimeProviderR.Time = LU;
                TimeProviderS.Time = RU;
                TimeProviderT.Time = LD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 2:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = RU;
                TimeProviderF.Time = LR;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = RD;
                TimeProviderJ.Time = LR;
                TimeProviderK.Time = LU;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = UD;
                TimeProviderN.Time = RD;
                TimeProviderO.Time = LR;
                TimeProviderP.Time = LU;

                TimeProviderQ.Time = UD;
                TimeProviderR.Time = RU;
                TimeProviderS.Time = LR;
                TimeProviderT.Time = LD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 3:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = RU;
                TimeProviderF.Time = LR;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = OFF;
                TimeProviderJ.Time = RD;
                TimeProviderK.Time = LU;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = OFF;
                TimeProviderN.Time = RU;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = RD;
                TimeProviderR.Time = LR;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 4:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LD;
                TimeProviderC.Time = RD;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = UD;
                TimeProviderG.Time = UD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = RU;
                TimeProviderK.Time = LU;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = RU;
                TimeProviderN.Time = LR;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = OFF;
                TimeProviderR.Time = OFF;
                TimeProviderS.Time = UD;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = OFF;
                TimeProviderV.Time = OFF;
                TimeProviderW.Time = RU;
                TimeProviderX.Time = LU;
                break;

            case 5:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = RD;
                TimeProviderG.Time = LR;
                TimeProviderH.Time = LU;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = RU;
                TimeProviderK.Time = LR;
                TimeProviderL.Time = LD;

                TimeProviderM.Time = RU;
                TimeProviderN.Time = LR;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = RD;
                TimeProviderR.Time = LR;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 6:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = RD;
                TimeProviderG.Time = LR;
                TimeProviderH.Time = LU;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = RU;
                TimeProviderK.Time = LR;
                TimeProviderL.Time = LD;

                TimeProviderM.Time = UD;
                TimeProviderN.Time = RD;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = UD;
                TimeProviderR.Time = RU;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 7:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = RU;
                TimeProviderF.Time = LR;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = OFF;
                TimeProviderJ.Time = OFF;
                TimeProviderK.Time = UD;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = OFF;
                TimeProviderN.Time = OFF;
                TimeProviderO.Time = UD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = OFF;
                TimeProviderR.Time = OFF;
                TimeProviderS.Time = UD;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = OFF;
                TimeProviderV.Time = OFF;
                TimeProviderW.Time = RU;
                TimeProviderX.Time = LU;
                break;

            case 8:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = RD;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = RU;
                TimeProviderK.Time = LU;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = UD;
                TimeProviderN.Time = RD;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = UD;
                TimeProviderR.Time = RU;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;

            case 9:
                TimeProviderA.Time = RD;
                TimeProviderB.Time = LR;
                TimeProviderC.Time = LR;
                TimeProviderD.Time = LD;

                TimeProviderE.Time = UD;
                TimeProviderF.Time = RD;
                TimeProviderG.Time = LD;
                TimeProviderH.Time = UD;

                TimeProviderI.Time = UD;
                TimeProviderJ.Time = RU;
                TimeProviderK.Time = LU;
                TimeProviderL.Time = UD;

                TimeProviderM.Time = RU;
                TimeProviderN.Time = LR;
                TimeProviderO.Time = LD;
                TimeProviderP.Time = UD;

                TimeProviderQ.Time = RD;
                TimeProviderR.Time = LR;
                TimeProviderS.Time = LU;
                TimeProviderT.Time = UD;

                TimeProviderU.Time = RU;
                TimeProviderV.Time = LR;
                TimeProviderW.Time = LR;
                TimeProviderX.Time = LU;
                break;
        }
    }
}
