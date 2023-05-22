using Login_SignUp.Models;

namespace Login_SignUp.Data.Services
{
    public interface IProductService
    {
        Task<Product> GetMovieByIdAsync(int id);
        
        
    }
}
