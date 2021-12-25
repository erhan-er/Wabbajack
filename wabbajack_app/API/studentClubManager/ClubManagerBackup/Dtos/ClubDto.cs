using System.Collections.Generic;
using ClubManagerBackup.Entities;

namespace ClubManagerBackup.Dtos
{
   /// <summary>
   /// Data transfer object of Club.
   /// </summary>
   public class ClubDto
   {
      /// <summary>
      /// ID of the club in the database.
      /// </summary>
      /// <value>ID of the Club.</value>
      public int ID { get; set; }
      /// <summary>
      /// Name of the club in the database.
      /// </summary>
      /// <value>Name of the club.</value>
      public string Name { get; set; }

      /// <summary>
      /// Description of the club in the database.
      /// </summary>
      /// <value>Description of the club.</value>
      public string ClubDescription { get; set; }
      /// <summary>
      /// ID of the club president in the database.
      /// </summary>
      /// <value>ClubPresidentID</value>
      public int ClubPresidentID { get; set; }
      /// <summary>
      /// Members of the club in the database.
      /// </summary>
      /// <value>Members of the club.</value>
      public List<User> StudentsClubMembers { get; set; }
      /// <summary>
      /// Image URL of the club.
      /// </summary>
      /// <value>Image URL of the club.</value>
      public string ImageURL { get; set; }
      /// <summary>
      /// Bugdet of the club in the database.
      /// </summary>
      /// <value>Bugdet of the club.</value>
      public int ClubBudget { get; set; }
      public string WhatsappLink { get; set; }
      public string InstagramLink { get; set; }
      public string FacebookLink { get; set; }
      public string TelegramLink { get; set; }
      public string LinkedinLink { get; set; }
      public string TwitterLink { get; set; }
   }
}