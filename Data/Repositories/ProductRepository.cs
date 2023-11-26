using Products_Is42_2023.Data.Context;
using Products_Is42_2023.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_Is42_2023.Data.Repositories
{
    class ProductRepository
    {
        StoreContext db;

        public ProductRepository()
        {
            db = new StoreContext();
        }

        public async Task<int> AddProduct(Product product)
        {
            db.Product.Add(product);
            return await db.SaveChangesAsync();
        }

        public void DeleteProduct(Product productId)
        {
            Product product = db.Product.Find(productId);
            if (product != null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
            }
        }

        public void UpdateProduct(Product updatedProduct)
        {
            Product product = db.Product.Find(updatedProduct.Id);
            if(product != null)
            {
                db.Product.Update(product);
                db.SaveChanges();
            }

        }

        public IEnumerable<Product> FindProducts(string txtSearch) => db.Product
            .Where(pr=>
            pr.Title.ToLower().StartsWith(txtSearch.ToLower()) ||
            pr.Description.ToLower().StartsWith(txtSearch.ToLower()));
    }
}
