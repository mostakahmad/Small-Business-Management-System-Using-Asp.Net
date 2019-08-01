using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerContact { get; set; }
        public int CustomerLP { get; set; }
    }
}
