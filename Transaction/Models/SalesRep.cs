using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Modoels
{
    public class SalesRep
    {
        public int SaleRepId { get; set; }
        public string SaleRepName { get; set; }
        public string Sex { get; set; }
        public DateTime DoB { get; set; }
        public string PoB { get; set; }
        public string Address { get; set; }
        public string NationalCardNumber { get; set; }
    }
}
