using Avalonia.Media.Imaging;

namespace AvaloniaApplication1.Models;

public class products
{
    public int ProdCount { get; set; }
    
    public Bitmap ProdBitmap { get; set; }
    public string ProdName { get; set; }
    public string ProdDescription { get; set; }
    public double ProdPrice { get; set; }
    
    public string ProdManufacturer { get; set; }

    public bool InStock;
}