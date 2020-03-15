using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class UserType
    {
        private int userTypeId = 0;
        private string designation = string.Empty;

        public int UserTypeId { get => userTypeId; set => userTypeId = value; }
        public string Designation { get => designation; set => designation = value; }
    }
}
