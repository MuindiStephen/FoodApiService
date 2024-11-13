using FoodOrderAPI.Models;

namespace FoodOrderAPI.Repository
{
    public class FoodRepository : IFoodRepository
    {

        private static List<Order> orders = new List<Order>(); // persist order list in this app lifetime

        public void DeleteOrder(int orderId)
        {
            Order orderToDelete = orders.First(order => order.OrderId == orderId);
            if (orderToDelete != null)
            {
                orders.Remove(orderToDelete);
            }
        }

        public List<Order> FetchAllOrdersForCustomer()
        {
            return orders;
        }

        public Order FetchSpecificOrderDetails(int orderId)
        {
            return orders.FirstOrDefault(order => order.OrderId == orderId);
            //return orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void InsertOrder(Order order)
        {
            orders.Add(order);
        }

        public void UpdateFoodQuantityInOrder(int orderId, int quantity)
        {
            Order orderToUpdate = orders.First(order => order.OrderId == orderId);

            if (orderToUpdate != null)
            {
                orderToUpdate.Quantity = quantity;
            }
        }

        public void UpdateOrder(Order order)
        {
            Order orderToUpdate = orders.First(order => order.OrderId == order.OrderId);
            if (orderToUpdate != null)
            {
                orderToUpdate = order;
            }
        }
    }
}
