using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }

        public Product GetByID(int id)
        {
            return _productRepository.GetByID(id);
        }
        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
