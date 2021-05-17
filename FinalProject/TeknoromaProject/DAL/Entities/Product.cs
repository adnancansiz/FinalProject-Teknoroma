using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class Product:BaseEntity
    {
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        [Display(Name = "Stok Bilgisi")]
        public int UnıtsInStock { get; set; }

        [Display(Name = "Tutar")]
        [Column(TypeName ="money")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Barkod Numarası")]
        public string BarcodeNumber { get; set; }

        public string ImageName { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }


        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual List<SupplierExpense> SupplierExpenses { get; set; }


    }
}
