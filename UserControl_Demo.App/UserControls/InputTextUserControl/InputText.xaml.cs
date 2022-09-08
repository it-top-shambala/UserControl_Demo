using System.ComponentModel;
using System.Windows.Controls;

namespace UserControl_Demo.App.UserControls.InputTextUserControl;

public partial class InputText : UserControl
{
    public CustomProperty ValueProperty { get; set; }
    public CustomProperty LabelProperty { get; set; }

    public InputText()
    {
        InitializeComponent();
    }
}
