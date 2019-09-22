using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class HR : Manager
    {
        [ForeignKey(nameof(Division))]
        public Division Assign { get; set; }

        [ForeignKey(nameof(Payroll))]
        public Payroll PrintPayroll { get; set; }
    }
}
