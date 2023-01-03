using DiziFilmData.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiziFimOrm.Controllers
{
    public class OyuncularKullanıcıController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OyuncularKullanıcıController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList = _db.Oyuncular.ToList();
            return View(objList);
        }
    }
}
