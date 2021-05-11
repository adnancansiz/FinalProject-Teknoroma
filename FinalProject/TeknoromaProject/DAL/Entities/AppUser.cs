using DAL.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public Status Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }
        [Column(TypeName = "money")]
        public decimal Bonus { get; set; }


        public List<Order> Orders { get; set; }
        public List<Issue> Issues { get; set; }
        public List<Expense> Expenses { get; set; }


    }
}
