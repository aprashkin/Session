using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

    
    public List<products> ProductsList { get; set; }

    public MainWindowViewModel()
    {
        ProductsList = new();
    }

    /*private void CountProductOnStock(int countProd)
    {
        if (countProd <= 0)
        {
            InStock = false;
            countProd = 0;
        }
    }*/
    
}


