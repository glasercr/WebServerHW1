using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeGlaserHW1
{
    public class FormInfo
    {
        public PaymentInfo paymentInfo { get; set; }

        public PizzaInfo pizzaInfo { get; set; }

        public CustomerInfo customerInfo { get; set; }

        public double totalCost { get; set; }

        public int orderNumber { get; set; }
    }
}
