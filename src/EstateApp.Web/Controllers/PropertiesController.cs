using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers
{
   public class PropertiesController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}