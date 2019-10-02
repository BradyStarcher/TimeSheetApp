using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class User : IdentityUser
    {
        public User() : base()
        {

        }

        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public TimeClock TimeClock { get; set; }
    }
}
