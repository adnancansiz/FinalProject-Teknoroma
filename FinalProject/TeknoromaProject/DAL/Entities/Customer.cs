using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Customer:BaseEntity
    {
        [Display(Name = "T.C. Kimlik Numarası")]
        public string TC { get; set; }

        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }

        [Display(Name = "Mail Adresi")]
        public string EmailAddress { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }

        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
    }
}
