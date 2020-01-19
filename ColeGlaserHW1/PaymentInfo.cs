using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeGlaserHW1
{
    public class PaymentInfo
    {
        public int Quantity { get; set; }

        public int CouponID { get; set; }

        public string PaymentMethod { get; set; }

        public int? CCNumber { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
