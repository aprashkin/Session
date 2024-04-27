using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication1.Views;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void Add_Product(object? sender, RoutedEventArgs e)
    {
        AddProducrWindow addProducrWindow = new AddProducrWindow();
        addProducrWindow.DataContext = DataContext;
        addProducrWindow.Show();
        this.Close();
    }
}