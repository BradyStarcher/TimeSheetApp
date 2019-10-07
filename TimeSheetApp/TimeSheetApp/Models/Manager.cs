using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Manager : User
    {
        public int Ssn { get; set; }

        public string Address { get; set; }
    }
}
