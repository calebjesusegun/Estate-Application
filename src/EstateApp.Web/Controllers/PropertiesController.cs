using System;
using System.Threading.Tasks;
using EstateApp.Web.Interfaces;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EstateApp.Web.Controllers {
   [Authorize]
   public class PropertiesController : Controller {
      private readonly IPropertyService _propertyService;
      public PropertiesController (IPropertyService propertyService) {
         _propertyService = propertyService;
      }

      [HttpGet]
      public IActionResult Index () {
         var properties = _propertyService.GetAllProperties ();
         return View (properties);
      }

      [HttpGet]
      public IActionResult Add () {
         return View ();
      }

      [HttpPost]
      public async Task<IActionResult> Add (PropertyModel model) {
         if (!ModelState.IsValid) return View ();
         try {
            await _propertyService.AddProperty (model);
            return RedirectToAction (nameof (Index));

         } catch (Exception e) {
            ModelState.AddModelError ("", e.Message);
            //throw new InvalidOperationException (message: AddErrors (result), null);
            return View ();
         }
      }

      // private string AddErrors (IdentityResult result) {
      //    StringBuilder sb = new StringBuilder ();
      //    foreach (var error in result.Errors) {
      //       sb.Append (error.Description + " ");
      //    }
      //    return sb.ToString ();
      // }
   }
}

// "AuthenticationConnection": "Server=sqlserver;Database=EstateAppDb;User=sa;Password=Dev@12345;",
// "ApplicationConnection": "Server=sqlserver;Database=EstateAppDb;User=sa;Password=Dev@12345;"