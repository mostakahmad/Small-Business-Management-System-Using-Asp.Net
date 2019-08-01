using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public int Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }
        public List<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }
        public bool Delete(int id)
        {
            return _supplierRepository.Delete(id);
        }
        public Supplier GetByID(int id)
        {
            return _supplierRepository.GetByID(id);
        }
        public bool Update(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }
    }
}
