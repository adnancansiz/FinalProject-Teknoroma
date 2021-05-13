using DAL.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        [Display(Name = "#")]
        public int MasterId { get; set; }


        [Display(Name = "Durum")]
        public Status Status { get; set; } = Status.Active;


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

    }
}
