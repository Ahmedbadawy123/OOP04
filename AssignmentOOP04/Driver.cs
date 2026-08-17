using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP04
{
    internal class Driver
    {
        public string DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(string driverid, string fullname, string phonenumber)
        {
            DriverId = driverid;
            FullName = fullname;
            PhoneNumber = phonenumber;
        }
    }
}
