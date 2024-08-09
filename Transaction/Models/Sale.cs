using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Modoels
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public string RefNumber { get; set; }
        public int CustomerId { get; set; }
        public int SaleRepId { get; set; }
        public int AppUserId { get; set; }
        public string Note { get; set; }
    }
}
