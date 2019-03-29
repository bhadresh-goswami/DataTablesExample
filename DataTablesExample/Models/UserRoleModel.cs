using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTablesExample.Models
{
    public class UserRoleModel
    {
        public int UserRoleId { get; set; }
        public int refUserId { get; set; }
        public int refRoleId { get; set; }
    }
}