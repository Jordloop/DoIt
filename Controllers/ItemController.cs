using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DoIt.Models;

namespace DoIt.Controllers
{
    public class ItemController : Controller
    {
        private DoItContext db = new DoItContext();

        public IActionResult Index()
        {
            return View();
        }

    }
}