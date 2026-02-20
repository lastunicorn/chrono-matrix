using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using DustInTheWind.ChronoMatrix.Controls.Templates;
using DustInTheWind.ClockWpf.Templates;

namespace DustInTheWind.ChronoMatrix.Controls;

public class MatrixClock23 : Control
{
    private readonly Timer timer;

    #region ClockTemplate Dependency Property

    public static readonly DependencyProperty ClockTemplateProperty = DependencyProperty.Register(
        nameof(ClockTemplate),
        typeof(ClockTemplate),
        typeof(MatrixClock23),
        new PropertyMetadata((ClockTemplate)null));

    public ClockTemplate ClockTemplate
    {
        get => (ClockTemplate)GetValue(ClockTemplateProperty);
        set => SetValue(ClockTemplateProperty, value);
    }

    #endregion

    #region Value1 Dependency Property

    internal static readonly DependencyPropertyKey Value1PropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(Value1),
        typeof(byte),
        typeof(MatrixClock23),
        new PropertyMetadata((byte)0));

    internal readonly static DependencyProperty Value1Property = Value1PropertyKey.DependencyProperty;

    public byte Value1
    {
        get => (byte)GetValue(Value1PropertyKey.DependencyProperty);
        private set => SetValue(Value1PropertyKey, value);
    }

    #endregion

    #region Value2 Dependency Property

    internal static readonly DependencyPropertyKey Value2PropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(Value2),
        typeof(byte),
        typeof(MatrixClock23),
        new PropertyMetadata((byte)0));

    internal readonly static DependencyProperty Value2Property = Value2PropertyKey.DependencyProperty;

    public byte Value2
    {
        get => (byte)GetValue(Value2PropertyKey.DependencyProperty);
        private set => SetValue(Value2PropertyKey, value);
    }

    #endregion

    #region Value3 Dependency Property

    internal static readonly DependencyPropertyKey Value3PropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(Value3),
        typeof(byte),
        typeof(MatrixClock23),
        new PropertyMetadata((byte)0));

    internal readonly static DependencyProperty Value3Property = Value3PropertyKey.DependencyProperty;

    public byte Value3
    {
        get => (byte)GetValue(Value3PropertyKey.DependencyProperty);
        private set => SetValue(Value3PropertyKey, value);
    }

    #endregion

    #region Value4 Dependency Property

    internal static readonly DependencyPropertyKey Value4PropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(Value4),
        typeof(byte),
        typeof(MatrixClock23),
        new PropertyMetadata((byte)0));

    internal readonly static DependencyProperty Value4Property = Value4PropertyKey.DependencyProperty;

    public byte Value4
    {
        get => (byte)GetValue(Value4PropertyKey.DependencyProperty);
        private set => SetValue(Value4PropertyKey, value);
    }

    #endregion

    #region ColonOn Dependency Property

    internal static readonly DependencyPropertyKey ColonOnPropertyKey = DependencyProperty.RegisterReadOnly(
        nameof(ColonOn),
        typeof(bool),
        typeof(MatrixClock23),
        new PropertyMetadata(true));

    internal readonly static DependencyProperty ColonOnProperty = ColonOnPropertyKey.DependencyProperty;

    public bool ColonOn
    {
        get => (bool)GetValue(ColonOnPropertyKey.DependencyProperty);
        private set => SetValue(ColonOnPropertyKey, value);
    }

    #endregion

    #region BlinkingColon Dependency Property

    internal static readonly DependencyProperty BlinkingColonProperty = DependencyProperty.Register(
        nameof(BlinkingColon),
        typeof(bool),
        typeof(MatrixClock23),
        new PropertyMetadata(true));

    public bool BlinkingColon
    {
        get => (bool)GetValue(BlinkingColonProperty);
        set => SetValue(BlinkingColonProperty, value);
    }

    #endregion

    static MatrixClock23()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(MatrixClock23), new FrameworkPropertyMetadata(typeof(MatrixClock23)));
    }

    private Dispatcher dispatcher;

    public MatrixClock23()
    {
        dispatcher = Dispatcher.CurrentDispatcher;

        ClockTemplate = new CustomTemplate();

        timer = new Timer(HandleTimerChanged);

        Loaded += OnLoaded;
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        dispatcher.InvokeAsync(() =>
        {
            UpdateClockValues();
            _ = timer.Change(1000, 1000);
        }, DispatcherPriority.Loaded);
    }

    private void HandleTimerChanged(object state)
    {
        dispatcher.InvokeAsync(() =>
        {
            UpdateClockValues();
        }, DispatcherPriority.Normal);
    }

    private void UpdateClockValues()
    {
        ColonOn = !BlinkingColon || !ColonOn;

        DateTime now = DateTime.Now;

        Value1 = (byte)(now.Hour / 10);
        Value2 = (byte)(now.Hour % 10);

        Value3 = (byte)(now.Minute / 10);
        Value4 = (byte)(now.Minute % 10);
    }
}
