using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Models
{
    public class AppUserPermission
    {
        public int AppUserPermissionId { get; set; }
        public int AppUserId { get; set; }
        public string PermissionName { get; set; }
    }
}
