using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class SupplierRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(Supplier supplier)
        {
            int isAdd = 0;

            db.suppliers.Add(supplier);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }
        public List<Supplier> GetAll()
        {
            return db.suppliers.ToList();
        }
        public bool Delete(int id)
        {
            int isDelete = 0;
            Supplier supplier = new Supplier();

            supplier = db.suppliers.FirstOrDefault(c => c.ID == id);
            if (supplier != null)
            {
                db.suppliers.Remove(supplier);
                isDelete = db.SaveChanges();
            }
            if (isDelete > 0)
                return true;
            return false;
        }
        public Supplier GetByID(int id)
        {
            Supplier supplier = new Supplier();

            supplier = db.suppliers.FirstOrDefault(c => c.ID == id);
            return supplier;
        }
        public bool Update(Supplier supplier)
        {
            int isUpdate = 0;
            Supplier aSupplier = new Supplier();

            aSupplier = db.suppliers.FirstOrDefault(c => c.ID == supplier.ID);
            if (aSupplier != null)
            {
                aSupplier.SupplierCode = supplier.SupplierCode;
                aSupplier.SupplierName = supplier.SupplierName;
                aSupplier.SupplierAddress = supplier.SupplierAddress;
                aSupplier.SupplierEmail = supplier.SupplierEmail;
                aSupplier.SupplierContact = supplier.SupplierContact;
                aSupplier.SupplierContactPerson = supplier.SupplierContactPerson;
                isUpdate = db.SaveChanges();
            }
            if (isUpdate > 0)
                return true;
            return false;
        }
    }
}
