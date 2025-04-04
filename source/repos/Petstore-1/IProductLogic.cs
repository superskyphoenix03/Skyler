// IProductLogic.cs
using System.Collections.Generic;

namespace Store
{
    public interface IProductLogic
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        List<string> GetOnlyInStockProducts();
        decimal GetTotalPriceOfInventory();
        DogLeash GetDogLeashByName(string name);
    }
}
