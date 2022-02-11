using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo  { get; set; }
       
        public double Price { get; set; }
        public double ExTax { get; set; }
      
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public bool Featured { get; set; }
        public int BrandId { get; set; }
        public int CampaignId { get; set; }
        public int CategoryId { get; set; }

    }
}
