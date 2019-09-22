using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Manager : User
    {
        public bool ApprovalTimeSheetStatus { get; set; }

        [ForeignKey(nameof(Division))]
        public Division Division { get; set; }
    }
}
