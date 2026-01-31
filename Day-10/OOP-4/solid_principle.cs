using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{

    #region Order Entity
    public class Order
    {
        public int ID { get; }
        public double Amount { get; }

        public Order(int id, double amount)
        {
            ID = id;
            Amount = amount;
        }
    }
    #endregion

    #region price calculator interface
    public interface IpriceCalculator
    {
        double CalculatePrice(Order odr);
    }
    #endregion
    public interface IorderRepository
    {
        void SaveOrder(Order odr);
    }

    public interface INotificationServices
    {
        void SendNotification(string message);
    }


    public class PriceCalculator : IpriceCalculator
    {
        public double CalculatePrice(Order odr)
        {
            return odr.Amount * 500;//500Rs tax 
        }
    }

    public class OrderRepo : IorderRepository
    {
        public void SaveOrder(Order odr)
        {
            Console.WriteLine($"{odr.ID} is Saved\n");
        }
    }

   public  class EmailNotification : INotificationServices
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification From Email is:{message}");

        }
    }

   public  class SmsNotification : INotificationServices
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification From Sms is: {message}");
        }
    }

    public class OrderService
    {
        private readonly IpriceCalculator _priceCalculator;
        private readonly IorderRepository _orderRepository;
        private readonly INotificationServices _notificationService;

        public OrderService(
            IpriceCalculator priceCalculator,
            IorderRepository orderRepository,
            INotificationServices notificationService)
        {
            _priceCalculator = priceCalculator;
            _orderRepository = orderRepository;
            _notificationService = notificationService;
        }

        public void PlaceOrder(Order odr)
        {
            var finalPrice = _priceCalculator.CalculatePrice(odr);

            _orderRepository.SaveOrder(odr);

            _notificationService.SendNotification(
                $"-Order placed. Final price: {finalPrice}");
        }
    }



    internal class solid_principle
    {


        static void Main()
        {
            IpriceCalculator calculator = new PriceCalculator();
            IorderRepository repository = new OrderRepo();
            INotificationServices notification = new EmailNotification();
            INotificationServices S_notification = new SmsNotification();


            var orderService = new OrderService(
                calculator,
                repository,
                notification);

            var order = new Order(1, 1000);
            orderService.PlaceOrder(order);
        }
    }

}
    


