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

    }
}
