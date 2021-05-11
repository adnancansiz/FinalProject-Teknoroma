using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class SubCategory:BaseEntity
    {
        [Display(Name = "Kategori Adı")]
        public string SubCategoryName { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
