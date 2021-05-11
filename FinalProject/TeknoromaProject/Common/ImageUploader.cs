using DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    public class ImageUploader
    {
        public static async void ProductImageUploader(Product product)
        {
            try
            {
                string fileName = product.ProductName.Replace(" ", "");
                string extention = Path.GetExtension(product.ImageFile.FileName);
                product.ImageName= fileName = fileName + extention;
                string path = "wwwroot/img/Product/" + fileName;
                using (var fileStream= new FileStream(path,FileMode.Create))
                {
                    await product.ImageFile.CopyToAsync(fileStream);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
