using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class EmployeeAndManagerListViewModel
    {
        public Employee[] Employees { get; set; }

        public Manager[] Managers { get; set; }
    }
}
