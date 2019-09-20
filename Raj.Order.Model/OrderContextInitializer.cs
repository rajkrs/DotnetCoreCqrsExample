using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Ef
{
    public class OrderContextInitializer
    {
        private readonly Dictionary<int, Order> Orders = new Dictionary<int, Order>();
        public static void Initialize(OrderContext context)
        {
            var initializer = new OrderContextInitializer();
            context.Database.EnsureCreated();
            //context.Database.Migrate();
            initializer.SeedOrdes(context);
        }


        private void SeedOrdes(OrderContext context)
        {
            var orders = new[]
            {
                new Order { Remark = "First order", Status = true},
                new Order { Remark = "2nd order", Status = true},
                new Order { Remark = "3rd order", Status = true},
                new Order { Remark = "4th order", Status = true}

            };

            context.Orders.AddRange(orders);

            context.SaveChanges();
        }


    }
}
