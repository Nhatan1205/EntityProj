using System;
using System.Collections.Generic;
using System.Data;
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

        public List<ProductImage> GetImageProduct(int productId)
        {
            using (var context = new Window_ProjectContext())
            {
                var productImages = context.ProductImages
                    .Where(pi => pi.ProductID == productId)
                    .ToList(); // Execute query and retrieve results as a list

                return productImages;
            }
        }

        public DataTable ConvertProductImagesToDataTable(List<ProductImage> productImages)
        {
            DataTable dt = new DataTable();

            // Define columns for the DataTable
            dt.Columns.Add("ProductImageID", typeof(int));
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ImageURL", typeof(byte[]));

            // Populate the DataTable with product image data
            foreach (var productImage in productImages)
            {
                DataRow row = dt.NewRow();
                row["ProductImageID"] = productImage.ID;
                row["ProductID"] = productImage.ProductID;
                row["ImageURL"] = productImage.Image;
                dt.Rows.Add(row);
            }

            return dt;
        }



    }
}
