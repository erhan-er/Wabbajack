using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Notification object.
   /// </summary>
   public class Notification
   {
      /// <summary>
      /// ID of the notification in the database.
      /// </summary>
      /// <value>ID of the notification</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the notification in the database.
      /// </summary>
      /// <value>Name of the notification.</value>
      public string NotificationName { get; set; }
      /// <summary>
      /// Description of the notification in the database.
      /// </summary>
      /// <value>Description of the notification.</value>
      public string notificationDescription { get; set; }
   }
}
