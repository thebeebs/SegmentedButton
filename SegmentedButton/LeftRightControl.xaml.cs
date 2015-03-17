
namespace SegmentedButton
{
    using System;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

  public sealed partial class LeftRightControl : UserControl
  {
    public LeftRightControl()
    {
      this.InitializeComponent();
    }

    public event EventHandler<int> OptionChanged;

    public static DependencyProperty LeftContentProperty =
      DependencyProperty.Register("LeftContent",
        typeof(object), typeof(LeftRightControl), null);

    public static DependencyProperty RightContentProperty =
      DependencyProperty.Register("RightContent",
        typeof(object), typeof(LeftRightControl), null);

    public static DependencyProperty OverlayContentProperty =
      DependencyProperty.Register("OverlayContent",
        typeof(object), typeof(LeftRightControl), null);

    public static DependencyProperty OverlayColumnProperty =
      DependencyProperty.Register("OverlayColumn",
        typeof(int), typeof(LeftRightControl), null);

    public object LeftContent
    {
      get
      {
        return (base.GetValue(LeftContentProperty));
      }
      set
      {
        base.SetValue(LeftContentProperty, value);
      }
    }
    public object RightContent
    {
      get
      {
        return (base.GetValue(RightContentProperty));
      }
      set
      {
        base.SetValue(RightContentProperty, value);
      }
    }
    public int OverlayColumn
    {
      get
      {
        return ((int)base.GetValue(OverlayColumnProperty));
      }
      set
      {
        base.SetValue(OverlayColumnProperty, value);
      }
    }
    public object OverlayContent
    {
      get
      {
        return (base.GetValue(OverlayContentProperty));
      }
      set
      {
        base.SetValue(OverlayContentProperty, value);
      }
    }
    void OnLeftClick(object sender, RoutedEventArgs e)
    {
      this.OverlayColumn = 0;
      if (OptionChanged != null)
      {
          OptionChanged(this, 0);
      }
    }
    void OnRightClick(object sender, RoutedEventArgs e)
    {
      this.OverlayColumn = 1;
      if (OptionChanged != null) { 
        OptionChanged(this, 1);
      }
    }
  }
}
