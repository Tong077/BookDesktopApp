using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool IsAdmin { get; set; }
    }
}
