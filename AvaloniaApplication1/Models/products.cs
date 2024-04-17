namespace AvaloniaApplication1.Models;

public class products
{
    public int countProd;
    public string PathImage;
    public string ProdName;
    public string ProdDescription;
    public string ProdManufacturer;
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