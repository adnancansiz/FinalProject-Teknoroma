using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Supplier:BaseEntity
    {
        [Display(Name = "Şirket Adı")]
        public string CompanyName { get; set; }

        [Display(Name = "İletişim Adı")]
        public string ContactName { get; set; }

        [Display(Name = "Mail Adresi")]
        public string Email { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }


        public virtual List<Product> Products { get; set; }

    }
}
