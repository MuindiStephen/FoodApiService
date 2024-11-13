using System.Text.Json.Serialization;

namespace FoodOrderAPI.Models
{

    /**
     * Entity model
     */
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerName { get; set; }
        public int FoodItem { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderTime { get; set; }


        //[JsonConstructor]
        //public Order(Order order)
        //{
        //    OrderId = order.OrderId;
        //    CustomerName = order.CustomerName;
        //    FoodItem = order.FoodItem;
        //    Quantity = order.Quantity;
        //    OrderTime = order.OrderTime;
        //}

        [JsonConstructor]
        public Order(int orderId, int customerName, int foodItem, int quantity, DateTime orderTime)
        {
            OrderId = orderId;
            CustomerName = customerName;
            FoodItem = foodItem;
            Quantity = quantity;
            OrderTime = orderTime;
        }
    }
}
