using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamAdapters
{
    class SalesTxn
    {
        public string CustomerName { get; set; }
        public decimal OrderTotal { get; set; }
        public string CouponCode { get; set; }
        public bool IsExpressDelivery { get; set; }
    }
}
