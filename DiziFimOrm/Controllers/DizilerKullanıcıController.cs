using DiziFilmData.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiziFimOrm.Controllers
{
    public class DizilerKullanıcıController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DizilerKullanıcıController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objList = _db.Diziler.ToList();
            return View(objList);
        }
    }
}
