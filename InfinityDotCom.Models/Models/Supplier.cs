using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierContact { get; set; }
        public string SupplierContactPerson { get; set; }
    }
}
