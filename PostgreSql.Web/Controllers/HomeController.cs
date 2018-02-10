using PostgreSql.Data;
using PostgreSql.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostgreSql.Web.Controllers
{
    public class HomeController : Controller
    {
        EgitimContext _db = new EgitimContext();
        
        public ActionResult Index()
        {
            Kullanici kul = new Kullanici();
            kul.AdSoyad = "Ali DOĞAN";
            kul.KullaniciAdi = "alidogankim";
            _db.Kullanici.Add(kul);
            _db.SaveChanges();
            return View();
        }
    }
}