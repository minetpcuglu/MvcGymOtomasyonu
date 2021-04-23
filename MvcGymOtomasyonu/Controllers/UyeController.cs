using MvcGymOtomasyonu.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGymOtomasyonu.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        SporDbEntities db = new SporDbEntities();
        public ActionResult Index()
        {
            // GET: Musteri
          
           
                var degerler = db.TblUye.ToList();
                return View(degerler);
         
        }
    }
}