using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class Adjustment
    {
        public int AdjustmentId { get; set; }
        public DateTime AdjustmentDate { get; set; }
        public string RefNumber { get; set; }
        public int AppuserId { get; set; }
        public string Note { get; set; }
    }
}
