using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Modoels
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public int SaleId { get; set; }
        public int ItemId { get; set; }
        public string ItemDesciption { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }
}
