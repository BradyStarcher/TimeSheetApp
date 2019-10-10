using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Role : IdentityRole
    {
        public Role() : base()
        {

        }

        public Role(string roleName) : base(roleName)
        {

        }

        public Role(string roleName, string description) : base(roleName)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}
