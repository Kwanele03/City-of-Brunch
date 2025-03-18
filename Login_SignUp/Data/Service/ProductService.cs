using Login_SignUp.Data.Base;
using Login_SignUp.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_SignUp.Data.Service
{
    public class ProductService : EntityBaseRepository<Product>, IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }
        public async Task<Product> GetProductByIdAsync(int Id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(n => n.Id == Id);
            return result;
        }

        public async Task<Product> UpdateProductAsync(int ProductId, Product newProduct)
        {
            _context.Update(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }
        public void DeleteProduct(int ProductId)
        {
            throw new NotImplementedException();
        }
    }
}

