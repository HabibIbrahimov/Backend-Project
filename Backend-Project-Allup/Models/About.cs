using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.Models
{
    public class About
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }

        public string Desc { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
