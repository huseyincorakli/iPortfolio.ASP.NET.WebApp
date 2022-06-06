using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface ITestimonialService
    {
        List<Testimonial> GetList();
        void TestimonialAdd(Testimonial p);
        Testimonial GetById(int id);
        void TestimonialDelete(Testimonial p);
        void TestimonialUpdate(Testimonial p);
    }
}
