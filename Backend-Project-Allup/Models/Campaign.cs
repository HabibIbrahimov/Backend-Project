using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public int Discount { get; set; }
        public List<Product> Products { get; set; }
    }
}
