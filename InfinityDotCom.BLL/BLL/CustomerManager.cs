using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityDotCom.Models.Models;
using InfinityDotCom.Repository.Repository;

namespace InfinityDotCom.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public int Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }
        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }
        public Customer GetByID(int id)
        {
            return _customerRepository.GetByID(id);
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
