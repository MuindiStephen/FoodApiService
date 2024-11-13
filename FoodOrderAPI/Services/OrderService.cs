using FoodOrderAPI.Models;
using FoodOrderAPI.Repository;

namespace FoodOrderAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IFoodRepository _foodRepository;
        public OrderService(IFoodRepository foodRepository)

        {
            _foodRepository = foodRepository;
        }



        public void CancelOrder(int orderId)
        {
            try
            {
                var existingOrder = _foodRepository.FetchSpecificOrderDetails(orderId);
                if (existingOrder == null)
                {
                    throw new Exception("Order not found!!");
                }
                _foodRepository.DeleteOrder(orderId);
            }
            catch
            {
                throw;
            }
        }

        public void ModifyFoodQuantityInOrder(int orderId, int quantity)
        {
            try
            {
                var existingOrder = _foodRepository.FetchSpecificOrderDetails(orderId);
                if (existingOrder == null)
                {
                    throw new Exception("Order not found!!");
                }
                _foodRepository.UpdateFoodQuantityInOrder(orderId, quantity);
            }
            catch
            {
                throw;
            }
        }

        public void ModifyOrder(Order order)
        {
            try
            {
                var existingOrder = _foodRepository.FetchSpecificOrderDetails(order.OrderId);
                if (existingOrder == null)
                {
                    throw new Exception("Order not found!!");
                }
                _foodRepository.UpdateOrder(order);
            }
            catch
            {
                throw;
            }
        }

        public void PlaceOrder(Order order)
        {
            try
            {
                var existingOrder = _foodRepository.FetchSpecificOrderDetails(order.OrderId);
                if (existingOrder != null)
                {
                    throw new Exception("Order already Exist!!");
                }
                _foodRepository.InsertOrder(order);
            }
            catch
            {
                throw new Exception("No db to save");
            }
        }

        public List<Order> RetrieveAllOrdersForCustomer()
        {
            try
            {
                return _foodRepository.FetchAllOrdersForCustomer();
            }
            catch
            {
                throw;
            }
        }

        public Order RetrieveSpecificOrderDetails(int orderId)
        {
            try
            {
                return _foodRepository.FetchSpecificOrderDetails(orderId);
            }
            catch
            {
                throw;
            }
        }
    }
}
