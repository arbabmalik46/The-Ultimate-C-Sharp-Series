using System;

namespace InterfacesByMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shippingProcess = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlaced = DateTime.Now,TotalPrice=100f };
            shippingProcess.Process(order);
        }
    }
}
