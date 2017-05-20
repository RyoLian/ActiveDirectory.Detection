using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    static class Establish
    {
        private static List<LDAP> s_LDAPs { get; set; }
        static Establish()
        {
            if (s_LDAPs == null)
            {
                s_LDAPs = new List<LDAP>()
                {
                    new LDAP { LocationID=EnumLocationID.P,LDAPPath="LDAP://DC=Taipei" },
                    new LDAP { LocationID=EnumLocationID.U,LDAPPath="LDAP://DC=Taoyuan"},
                    new LDAP { LocationID=EnumLocationID.H,LDAPPath="LDAP://DC=Miaoli"}
                };

            }
        }

        public static IEnumerable<LDAP> GetLDAPs()
        {
            return s_LDAPs;
        }

    }
}
