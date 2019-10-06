using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Division
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public Manager AssignedManager { get; set; }
    }
}
