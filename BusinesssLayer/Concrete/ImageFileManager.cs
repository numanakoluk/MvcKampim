using BusinesssLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imageDal;

        public ImageFileManager(IImageFileDal ımageDal)
        {
            _imageDal = ımageDal;
        }

        public List<ImageFile> GetList()
        {
           return _imageDal.List();
        }
    }
}
