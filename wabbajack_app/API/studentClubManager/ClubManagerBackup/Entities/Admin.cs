using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Admin object. Admin is a User.
   /// </summary>
   public class Admin : User
   {
      /// <summary>
      /// Constructor for admin object.
      /// </summary>
      public Admin()
      {
         RequestedEvents = new List<StudentEvent>();
      }
      /// <summary>
      /// List of requested event creation from students.
      /// </summary>
      /// <value></value>
      public List<StudentEvent> RequestedEvents { get; set; }
   }
}
