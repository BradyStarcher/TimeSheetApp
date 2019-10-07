using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Employee : User
    {
        public int Ssn { get; set; }

        public string Address { get; set; }
    }
}
