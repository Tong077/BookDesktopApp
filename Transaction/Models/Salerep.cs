using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class Salerep
    {
        public int SaleRepID { get; set; }
        public string SaleRepName { get; set; }
        public string Sex { get; set; }
        public DateTime Dob { get; set; }
        public string Pob { get; set; }
        public string Address { get; set; }
        public string NATIONALCARDNUMBER { get; set; }
    }
}
