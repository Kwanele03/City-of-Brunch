using Login_SignUp.Data.Base;
using Login_SignUp.Models;

namespace Login_SignUp.Data.Service
{
    public interface IProductService : IEntityBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(int ProductId);
        Task AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(int ProductId, Product newProduct);
        void DeleteProduct(int ProductId);
    }
}
