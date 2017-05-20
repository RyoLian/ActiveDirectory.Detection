using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class LDAP
    {
        public EnumLocationID LocationID { get; set; }
        public string LDAPPath { get; set; }

        public bool IsExist { get; set; }
    }
}
