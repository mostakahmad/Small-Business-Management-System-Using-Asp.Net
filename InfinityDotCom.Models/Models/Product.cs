using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductROL { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
