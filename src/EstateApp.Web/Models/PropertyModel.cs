namespace EstateApp.Web.Models
{
   public class PropertyModel
   {
      public string Title { get; set; } //BEDROOM FLAT IN OTA
      public string ImageUrl { get; set; }
      public double Price { get; set; }
      public string Description { get; set; }
      public int NumberOfRooms { get; set; }
      public int NumberOfBaths { get; set; }
      public int NumberOfToilets { get; set; }
      public string Address { get; set; }
      public string ContactPhoneNumber { get; set; }
   }
}