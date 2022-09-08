using System.ComponentModel;
using System.Windows;

namespace UserControl_Demo.App.Windows.MainWindow;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private string _nameP;

    public string NameP
    {
        get => _nameP;
        set
        {
            if (value == _nameP)
            {
                return;
            }

            _nameP = value;
            OnPropertyChanged(nameof(NameP));
        }
    }

    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            if (value == _age)
            {
                return;
            }

            _age = value;
            OnPropertyChanged(nameof(Age));
        }
    }

    public MainWindow()
    {
        InitializeComponent();

        InputName.LabelName = nameof(NameP);
        InputName.ValueElement = NameP;

        InputAge.LabelName = nameof(Age);
        InputAge.ValueElement = Age.ToString();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void ButtonReset_OnClick(object sender, RoutedEventArgs e)
    {
        NameP = string.Empty;
        Age = 0;
    }

    private void ButtonSubmit_OnClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"{NameP}, {Age}");
    }
}
