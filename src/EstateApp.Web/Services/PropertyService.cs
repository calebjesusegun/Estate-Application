using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EstateApp.Data.DatabaseContexts.ApplicationDbContext;
using EstateApp.Data.Entities;
using EstateApp.Web.Interfaces;
using EstateApp.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace EstateApp.Web.Services {
   public class PropertyService : IPropertyService {

      private readonly ApplicationDbContext _dbContext;

      public PropertyService (ApplicationDbContext dbContext) {
         _dbContext = dbContext;
      }

      public IEnumerable<Property> GetAllProperties () {
         return _dbContext.Properties;
      }

      public async Task AddProperty (PropertyModel model) {
         if (model is null) throw new ArgumentNullException (message: "Invalid Details Provided", null);

         var property = new Property {
            Id = Guid.NewGuid ().ToString (),
            Title = model.Title,
            ImageUrl = model.ImageUrl,
            Price = model.Price,
            Description = model.Description,
            NumberOfRooms = model.NumberOfRooms,
            NumberOfBaths = model.NumberOfBaths,
            NumberOfToilets = model.NumberOfToilets,
            Address = model.Address,
            ContactPhoneNumber = model.ContactPhoneNumber
         };

         var result = await _dbContext.AddAsync (property);
         // if (!result.Succeeded) {
         //    throw new InvalidOperationException (message: AddErrors (result), null);
         // }
         await _dbContext.SaveChangesAsync ();

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