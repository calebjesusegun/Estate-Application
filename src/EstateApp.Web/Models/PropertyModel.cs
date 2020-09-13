using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateApp.Web.Models {
   public class PropertyModel {
      [DisplayName ("Title")]
      [Required]
      public string Title { get; set; } //BEDROOM FLAT IN OTA

      [DisplayName ("Image Url")]

      public string ImageUrl { get; set; }

      [DisplayName ("Price")]
      [Required]
      public double Price { get; set; }

      [DisplayName ("Description")]
      [Required]
      public string Description { get; set; }

      [Range (1, 10)]
      [DisplayName ("Number Of Rooms")]
      [Required]
      public int NumberOfRooms { get; set; }

      [Range (1, 10)]
      [DisplayName ("Number Of Baths")]
      [Required]
      public int NumberOfBaths { get; set; }

      [Range (1, 10)]
      [DisplayName ("Number Of Toilets")]
      [Required]
      public int NumberOfToilets { get; set; }

      [DisplayName ("Address")]
      [Required]
      public string Address { get; set; }

      [DisplayName ("Contact Phone Number")]
      [Required]
      public string ContactPhoneNumber { get; set; }
   }
}