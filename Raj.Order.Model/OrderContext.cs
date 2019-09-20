using Microsoft.EntityFrameworkCore;
using System;

namespace Raj.Order.Ef
{
    public class OrderContext : DbContext
    {


        public OrderContext(DbContextOptions options)
                    : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

    }
}
