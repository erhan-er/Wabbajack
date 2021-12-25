using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Student Event
   /// </summary>
   public class StudentEventDto
   {
      /// <summary>
      /// ID of the student event in the database.
      /// </summary>
      /// <value>ID of the student event.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the student event in the database.
      /// </summary>
      /// <value>Name of the student event.</value>
      public string Name { get; set; }
      /// <summary>
      /// Description of the student event in the database.
      /// </summary>
      /// <value>Description of the student event.s</value>
      public string Description { get; set; }
      /// <summary>
      /// Cost of the student event in the database.
      /// </summary>
      /// <value>Cost of the student event.</value>
      public int EventCost { get; set; }
      public DateTime Date { get; set; }
      /// <summary>
      /// Capacity of the student event in the database.
      /// </summary>
      /// <value>Capacity of the student event.</value>
      public int Capacity { get; set; }
      /// <summary>
      /// ID of the student event owner.
      /// </summary>
      /// <value>ID of the owner student.</value>
      public int UserID { get; set; }

      /// /// <summary>
      /// Image URL of the event in the database.
      /// </summary>
      /// <value>Image URL of the event.</value>
      public string ImageURL { get; set; }
      /// <summary>
      /// Approval of Admin users.
      /// </summary>
      /// <value>Approval of Admin users.</value>
      public bool IsApproved { get; set; } = false;
      /// <summary>
      /// Discriminator to show this is StudentEvent.
      /// </summary>
      public string Discriminator = "StudentEvent";
   }
}
