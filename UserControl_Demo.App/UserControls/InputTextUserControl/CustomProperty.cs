using System.Windows;

namespace UserControl_Demo.App.UserControls.InputTextUserControl;

public class CustomProperty : DependencyObject
{
    public static DependencyProperty ValueProperty;

    public CustomProperty()
    {
        ValueProperty = DependencyProperty.Register(nameof(Value), typeof(string), typeof(CustomProperty));
    }

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
}
