using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using AvaloniaApplication1.Models;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.Views;

public partial class AddProducrWindow : Window
{
    bool result;
    bool prodStock;
    private MainWindowViewModel viewModel;
    private Bitmap _bitmap;
    public AddProducrWindow()
    {
        InitializeComponent();
    }
    
    private async void AddImageButton_Click(object sender, RoutedEventArgs e)
    {
        var fileDialog = new OpenFileDialog
        {
            AllowMultiple = false,
            Title = "Выберите изображение",
            Directory = "C:\\Users\\prdb\\RiderProjects\\session\\AvaloniaApplication1\\Assets",
            Filters = new List<FileDialogFilter>
            {
                new FileDialogFilter { Name = "Images", Extensions = { "jpg", "png", "jpeg", "ico" } }
            }
        };

        var result = await fileDialog.ShowAsync(this);

        if (result != null && result.Length > 0)
        {
            var imagePath= result[0];
            var bitmap = new Bitmap(imagePath);
            _bitmap = bitmap;
        }
    }

    private async void add(object? sender, RoutedEventArgs e)
    {
        if (int.Parse(prodCount.Text) >= 0)
        {
            prodStock = false;
        }
        else
        {
            prodStock = true;
        }
        
        var newProduct = new products
        {
            ProdName = prodName.Text,
            ProdDescription = prodDesc.Text,
            ProdPrice = double.Parse(prodPrice.Text),
            ProdManufacturer = prodManufact.Text,
            ProdCount = int.Parse(prodCount.Text),
            ProdBitmap = _bitmap,
            InStock = prodStock
        };
        Debug.WriteLine(DataContext);
        (DataContext as MainWindowViewModel).ProductsList.Add(newProduct);
    }
}