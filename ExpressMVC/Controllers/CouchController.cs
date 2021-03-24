using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressMVC.Models;
namespace ExpressMVC.Controllers
{
    public class CouchController : Controller
    {
       
        public IActionResult Couches()
        {
            return View();
        }
    }
}
