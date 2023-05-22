using Login_SignUp.Models;

namespace Login_SignUp.Data.Services
{
    public interface IOrderServices
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
