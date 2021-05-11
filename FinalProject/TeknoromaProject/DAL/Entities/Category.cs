using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class Category:BaseEntity
    {
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        
        public virtual List<SubCategory> SubCategories { get; set; }


    }
}
