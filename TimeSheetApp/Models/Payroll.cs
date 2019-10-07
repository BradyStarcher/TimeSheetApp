using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Payroll
    {
        public int ID { get; set; }

        //[DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [ForeignKey(nameof(User))]
        public User Employee { get; set; }

        public string Address { get; set; }
    }
}
