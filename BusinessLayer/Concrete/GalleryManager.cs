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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void GalleryAdd(Gallery p)
        {
            _galleryDal.Insert(p);
        }

        public void GalleryDelete(Gallery p)
        {
            _galleryDal.Delete(p);
        }

        public void GalleryUpdate(Gallery p)
        {
            _galleryDal.Update(p);
        }

        public Gallery GetById(int id)
        {
            return _galleryDal.Get(x => x.Id == id);
        }

        public List<Gallery> GetList()
        {
            return _galleryDal.List();
        }
    }
}
