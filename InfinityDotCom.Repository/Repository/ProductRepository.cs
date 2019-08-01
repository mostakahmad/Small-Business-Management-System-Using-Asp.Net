using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class ProductRepository
    {
        InfinityDBContext db = new InfinityDBContext();

        public bool Add(Product product)
        {
            int isAdd = 0;

            db.products.Add(product);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return true;
            return false;
        }

        public List<Product> GetAll()
        {
            return db.products.ToList();
        }

        public bool Delete(int id)
        {
            int isDelete = 0;
            Product product = new Product();

            product = db.products.FirstOrDefault(c => c.ID == id);
            if (product != null)
            {
                db.products.Remove(product);
                isDelete = db.SaveChanges();
            }
            if (isDelete > 0)
                return true;
            return false;
        }

        public Product GetByID(int id)
        {
            Product product = new Product();

            product = db.products.FirstOrDefault(c => c.ID == id);
            return product;
        }
        public bool Update(Product product)
        {
            int isUpdate = 0;
            Product aProduct = new Product();

            aProduct = db.products.FirstOrDefault(c => c.ID == product.ID);
            if (aProduct != null)
            {
                aProduct.ProductCode = product.ProductCode;
                aProduct.ProductName = product.ProductName;
                aProduct.CategoryID = product.CategoryID;
                aProduct.ProductROL = product.ProductROL;
                aProduct.ProductDescription = product.ProductDescription;
                isUpdate = db.SaveChanges();
            }
            if (isUpdate > 0)
                return true;
            return false;
        }
    }
}
