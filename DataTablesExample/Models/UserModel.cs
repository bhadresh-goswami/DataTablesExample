using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTablesExample.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<RoleModel> Roles { get; set; }

    }
}