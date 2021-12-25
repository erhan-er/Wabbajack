using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// User object.
   /// </summary>
   public class User
   {
      /// <summary>
      /// Constructor for User.
      /// </summary>
      public User()
      {
         Notifications = new List<Notification>();
      }
      // properties
      /// <summary>
      /// ID of the user in the database.
      /// </summary>
      /// <value>ID of the user.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the user in the database.
      /// </summary>
      /// <value>Name of the user.</value>
      public string Name { get; set; }
      /// <summary>
      /// Mail of the user in the database.
      /// </summary>
      /// <value>Mail of the user.</value>
      public string Mail { get; set; }
      /// <summary>
      /// Hashed ppassword of the user in the database.
      /// </summary>
      /// <value>Hashed password of the user.</value>
      public byte[] PasswordHash { get; set; }
      /// <summary>
      /// Salted password of the user in the database.
      /// </summary>
      /// <value>Salted password of the user.</value>
      public byte[] PasswordSalt { get; set; }
      /// <summary>
      /// Department of the user in the database. 
      /// </summary>
      /// <value>Department of the user.</value>
      public string Department { get; set; }
      /// <summary>
      /// Discriminator of the user to show user type.
      /// </summary>
      /// <value>Discriminator of the user.</value>
      public string Discriminator { get; set; }
      /// <summary>
      /// Notifications of the user.
      /// </summary>
      /// <value>Notifications of the user.</value>
      public List<Notification> Notifications { get; set; }
   }
}
