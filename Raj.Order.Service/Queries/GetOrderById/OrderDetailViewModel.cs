using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Queries.GetOrderById
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }

        public string Remark { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime OrderConfirmationDate { get; set; }


    }
}
