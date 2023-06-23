using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task DeleteProduct(int id);
        Task<ProductModel?> GetProduct(int id);
        Task<IEnumerable<ProductModel>> GetProducts();
        Task InsertProduct(ProductModel product);
        Task UpdateProduct(ProductModel product);
    }
}