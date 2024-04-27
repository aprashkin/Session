using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views;

public partial class auth : Window
{
    public auth()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void btn_guest(object? sender, RoutedEventArgs e)
    {
        new users("guest", "guest", false);
        Window1 window1 = new Window1();
        window1.DataContext = DataContext;
        window1.Show();
        this.Close();
         
    }
}