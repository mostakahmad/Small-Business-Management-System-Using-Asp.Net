using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.DatabaseContext.DatabaseContext;

namespace InfinityDotCom.Repository.Repository
{
    public class CustomerRepository
    {
        InfinityDBContext db = new InfinityDBContext();
        public int Add(Customer customer)
        {
            int isAdd = 0;

            db.customers.Add(customer);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return 1;
            return 0;
        }
        public List<Customer> GetAll()
        {
            return db.customers.ToList();
        }
        public bool Delete(int id)
        {
            int isDelete = 0;
            Customer customer = new Customer();

            customer = db.customers.FirstOrDefault(c => c.ID == id);
            if (customer != null)
            {
                db.customers.Remove(customer);
                isDelete = db.SaveChanges();
            }
            if (isDelete > 0)
                return true;
            return false;
        }
        public Customer GetByID(int id)
        {
            Customer customer = new Customer();

            customer = db.customers.FirstOrDefault(c => c.ID == id);
            return customer;
        }
        public bool Update(Customer customer)
        {
            int isUpdate = 0;
            Customer aCustomer = new Customer();

            aCustomer = db.customers.FirstOrDefault(c => c.ID == customer.ID);
            if (aCustomer != null)
            {
                aCustomer.CustomerCode = customer.CustomerCode;
                aCustomer.CustomerName = customer.CustomerName;
                aCustomer.CustomerAddress = customer.CustomerAddress;
                aCustomer.CustomerEmail = customer.CustomerEmail;
                aCustomer.CustomerContact = customer.CustomerContact;
                aCustomer.CustomerLP = customer.CustomerLP;
                isUpdate = db.SaveChanges();
            }
            if (isUpdate > 0)
                return true;
            return false;
        }
    }
}
