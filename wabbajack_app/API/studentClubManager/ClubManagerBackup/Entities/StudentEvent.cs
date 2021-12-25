using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// StudentEvent object. StudentEvent is Event.
   /// </summary>
   public class StudentEvent : Event
   {
      /// <summary>
      /// ID of the Admin that approval is gone.
      /// </summary>
      /// <value>ID of the Admin that approval is gone.</value>
      public int AdminID { get; set; }
      /// <summary>
      /// Approval of the student event.
      /// </summary>
      /// <value>Approval of the student event.</value>
      public bool IsApproved { get; set; }
   }
}
