namespace AvaloniaApplication1.Models;

public class products
{
    public int countProd;
    public string PathImage { get; set; };
    public string ProdName { get; set; }
    public string ProdDescription { get; set; }
    public int ProdPrice { get; set; }
    public string ProdManufacturer { get; set; }
    public bool InStock = true;

    public products(int countProd, string pathImage, string prodName, string prodDescription, string prodManufacturer)
    {
        this.countProd = countProd;
        PathImage = pathImage;
        ProdName = prodName;
        ProdDescription = prodDescription;
        ProdManufacturer = prodManufacturer;
    }
    
    //прописать сюда метод, который будет обновлять InStock в зависимости от количества продуктов на складе (типа если >= 0, то ставить false в InStock) 
    
}