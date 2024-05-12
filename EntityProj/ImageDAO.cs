using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj
{
    internal class ImageDAO
    {
        public void Add(int productId, byte[] imageBytes)
        {
            using (var context = new Window_ProjectContext())
            {
                var productImage = new ProductImage
                {
                    ProductID = productId,
                    Image = imageBytes
                };

                context.ProductImages.Add(productImage);
                context.SaveChanges();
            }
        }

        public void Delete(int productId)
        {
            using (var context = new Window_ProjectContext())
            {
                var productImage = context.ProductImages.FirstOrDefault(pi => pi.ProductID == productId);
                if (productImage != null)
                {
                    context.ProductImages.Remove(productImage);
                    context.SaveChanges();
                }
            }
        }

        public byte[] GetImageProductData(int productId)
        {
            using (var context = new Window_ProjectContext())
            {
                var productImage = context.ProductImages
                    .Where(pi => pi.ProductID == productId)
                    .Select(pi => pi.Image)
                    .FirstOrDefault();

                return productImage;
            }
        }

        public IQueryable<ProductImage> GetImageProduct(int productId)
        {
            using (var context = new Window_ProjectContext())
            {
                var productImages = context.ProductImages
                    .Where(pi => pi.ProductID == productId);

                return productImages;
            }
        }

    }
}
