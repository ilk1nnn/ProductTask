using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }


        public override string ToString()
        {
            return ContactName;
        }

    }
}
