using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Event.
   /// </summary>
   public class EventDto
   {
      /// <summary>
      /// ID of the event in the database.
      /// </summary>
      /// <value>ID of the event.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the event in the database.
      /// </summary>
      /// <value>Name of the event.</value>
      public string Name { get; set; }
      /// <summary>
      /// Description of the event in the database.
      /// </summary>
      /// <value>Description of the event.</value>
      public string Description { get; set; }
      /// <summary>
      /// ID of the place that event will be done in the database.
      /// </summary>
      /// <value>ID of the place that event takes place.</value>
      public int PlaceID { get; set; }
      /// <summary>
      /// ID of the category of event in the database.
      /// </summary>
      /// <value>ID of the event's category.</value>
      public int CategoryID { get; set; }
      /// <summary>
      /// Cost of the event in the database.
      /// </summary>
      /// <value>Cost of the event.</value>
      public int Cost { get; set; }
      /// <summary>
      /// Capacity of the event in the database.
      /// </summary>
      /// <value>Capacity of the event.</value>
      public int Capacity { get; set; }
      /// <summary>
      /// ID of the owner club of the event in the database.
      /// </summary>
      /// <value>ID of the event's owner club.</value>
      public int ClubID { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public int UserId { get; set; }
      /// <summary>
      /// Image URL of the event in the database.
      /// </summary>
      /// <value>Image URL of the event.</value>
      public string ImageURL { get; set; }

      /// <summary>
      /// Discriminator to differentiate Club and Student events.
      /// </summary>
      public string Discriminator = "Event";
   }
}
