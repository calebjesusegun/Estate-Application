using System;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers
{
   public class PropertiesController : Controller
   {
      [HttpGet]
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult Add()
      {
         return View();
      }

      public IActionResult Add(PropertyModel model)
      {
         throw new NotImplementedException();
      }
   }
}