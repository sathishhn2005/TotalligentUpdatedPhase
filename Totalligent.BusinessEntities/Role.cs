using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Totalligent.BusinessEntities
{
    public class Role
    {
        private int roleId = 0;
        private string description = string.Empty;

        public int RoleId { get => roleId; set => roleId = value; }
        public string Description { get => description; set => description = value; }
        

    }
}