using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly Data.ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)

        {

            _db = db;

        }


        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductTypes productTypes)
        {

            if (ModelState.IsValid)
            {
                _db.Add(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View();

        }


    }


}