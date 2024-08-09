using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int VendorId { get; set; }
        public int AppuserId { get; set; }
        public string Note { get; set; }

}
}
