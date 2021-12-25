using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Event object.
   /// </summary>
   public class Event
   {
      /// <summary>
      /// Constructor for Event.
      /// </summary>
      public Event()
      {
         Participants = new List<User>();
      }
      // properties
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
      /// ID of the owner club of the event in the database.
      /// </summary>
      /// <value>ID of the owner club of the event.</value>
      public int ClubID { get; set; }
      /// <summary>
      /// Date of the event in the database.
      /// </summary>
      /// <value>Date of the event.</value>
      public DateTime Date { get; set; }
      /// <summary>
      /// ID of the category of the event in the database.
      /// </summary>
      /// <value>ID of the category of the event.</value>
      public int CategoryID { get; set; }
      /// <summary>
      /// ID of the place of the event in the database.
      /// </summary>
      /// <value>ID of the place that event takes place.</value>
      public int PlaceID { get; set; }
      /// <summary>
      /// Notificaton of the event.
      /// </summary>
      /// <value>Notification of event.</value>
      public Notification Notification { get; set; }
      /// <summary>
      /// Image url of event in the databse.
      /// </summary>
      /// <value>Image url of the event.</value>
      public string ImageURL { get; set; }
      /// <summary>
      /// Cost of the event in the database.
      /// </summary>
      /// <value>Cost of the event.</value>
      public int EventCost { get; set; }
      /// <summary>
      /// Capacity of the event in the database.
      /// </summary>
      /// <value></value>
      public int Capacity { get; set; }
      /// <summary>
      /// Participants of the event in the database.
      /// </summary>
      /// <value>Participans of the event.</value>
      public List<User> Participants { get; set; }
      /// <summary>
      /// ID of the club board member that created the event.
      /// </summary>
      /// <value>ID of the club board member that created the event.</value>
      public int ClubBoardMemberID { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public int UserId { get; set; }
   }
}
