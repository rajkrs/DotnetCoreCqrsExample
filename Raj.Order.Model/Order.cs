using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Ef
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Remark{ get; set; }
        public bool Status { get; set; }

    }
}
