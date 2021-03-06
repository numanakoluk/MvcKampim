using BusinesssLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Kampim.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
            HeadingManager hm = new HeadingManager(new EfHeadingDal());
            WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            //Kategori Sayısı
            ViewBag.Deger1 = cm.GetList().Count();
            //Yazılım kategorisinde ki başlık sayısı
            ViewBag.Deger2 = hm.GetList().Where(x => x.CategoryID == 20).Count();
            //içinde harfi geçen yazar sayısı
            ViewBag.Deger3 = wm.GetList().Where(x => x.WriterName.Contains("a") || x.WriterName.Contains("A")).Count();
            //En fazla başlığa sahip kategori
            ViewBag.Deger4 = cm.GetList().Where(x => x.CategoryID == (hm.GetList().GroupBy(h => h.CategoryID).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k => k.CategoryName).FirstOrDefault();
            //True olan kategori sayısı
            ViewBag.Deger5 = cm.GetList().Where(x => x.CategoryStatus == true).Count(); 

            return View();
        }
    }
}