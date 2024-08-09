using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class PurchaseDetail
    {
        public int purchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
}
