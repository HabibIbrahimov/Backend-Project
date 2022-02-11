using Backend_Project_Allup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project_Allup.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDesc SliderDesc { get; set; }
        public List<Banner> Banners { get; set; }
        public List<BrandSlider> BrandSliders { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public Subscribe Subscribe { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<TestimonialDesc> TestimonialDesc { get; set; }
        public List<Service> services { get; set; }
        public List<Category> Categories { get; set; }
    }
}
