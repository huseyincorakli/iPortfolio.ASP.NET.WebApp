using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGalleryService
    {
        List<Gallery> GetList();
        void GalleryAdd(Gallery p);
        Gallery GetById(int id);
        void GalleryDelete(Gallery p);
        void GalleryUpdate(Gallery p);
    }
}
