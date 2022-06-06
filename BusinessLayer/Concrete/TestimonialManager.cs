using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.Get(x => x.TestimoId == id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.List();
        }

        public void TestimonialAdd(Testimonial p)
        {
            _testimonialDal.Insert(p);
        }

        public void TestimonialDelete(Testimonial p)
        {
            _testimonialDal.Delete(p);
        }

        public void TestimonialUpdate(Testimonial p)
        {
            _testimonialDal.Update(p);
        }
    }
}
