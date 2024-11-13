using FoodOrderAPI.Models;

namespace FoodOrderAPI.Services
{
    public interface IOrderService {

        void PlaceOrder(Order order);
        List<Order> RetrieveAllOrdersForCustomer();
        Order RetrieveSpecificOrderDetails(int orderId);
        void ModifyOrder(Order order);
        void ModifyFoodQuantityInOrder(int orderId, int quantity);
        void CancelOrder(int orderId);

    }
}
