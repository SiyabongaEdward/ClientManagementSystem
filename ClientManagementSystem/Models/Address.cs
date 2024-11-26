using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementSystem.Models
{
    public class Address
    {

        public int AddressID { get; set; }
        public int ClientID { get; set; }
        public string Residentialddress { get; set; }
        public string Workddress { get; set; }
        public string Postalddress { get; set; }

    }
}
