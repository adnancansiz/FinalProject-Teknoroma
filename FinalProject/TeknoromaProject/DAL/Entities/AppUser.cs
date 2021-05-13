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

        [Display(Name = "Adı")]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        [Display(Name = ("Maaş"))]
        [Column(TypeName = "Money")]
        public decimal Salary { get; set; }
        [Column(TypeName = "money")]
        public decimal Bonus { get; set; }


        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedBy { get; set; }


        [Display(Name = "Güncelleme Tarihi")]
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedComputerName { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedBy { get; set; }


        public List<Order> Orders { get; set; }
        public List<Issue> Issues { get; set; }
        public List<Expense> Expenses { get; set; }





    }
}
