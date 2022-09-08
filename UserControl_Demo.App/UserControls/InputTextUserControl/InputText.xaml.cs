using System.ComponentModel;
using System.Windows.Controls;

namespace UserControl_Demo.App.UserControls.InputTextUserControl;

public partial class InputText : UserControl, INotifyPropertyChanged
{
    private string _label;

    public string LabelName
    {
        get => _label;
        set
        {
            if (value == _label)
            {
                return;
            }

            _label = value;
            OnPropertyChanged(nameof(LabelName));
        }
    }

    private string _value;

    public string ValueElement
    {
        get => _value;
        set
        {
            if (value == _value)
            {
                return;
            }

            _value = value;
            OnPropertyChanged(nameof(ValueElement));
        }
    }

    public InputText()
    {
        InitializeComponent();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
