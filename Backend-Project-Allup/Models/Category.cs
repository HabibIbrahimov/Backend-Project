using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "dont empty")]
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public bool IsFeature { get; set; }
        public string PhotoUrl { get; set; }
        public Category MainCategory { get; set; }
        public List<Category> SubCategory { get; set; }
        public List<CategoryBrand> CategoryBrand { get; set; }

    }
}
