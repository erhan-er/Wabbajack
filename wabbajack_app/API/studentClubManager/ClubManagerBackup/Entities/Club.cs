using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Club object.
   /// </summary>
   public class Club
   {
      /// <summary>
      /// Constructor for club object.
      /// </summary>
      public Club()
      {
         StudentsClubMembers = new List<User>();
         //StudentsClubFollowers = new List<User>();
         //StudentsJoinRequests = new List<User>();
         EventsOld = new List<Event>();
         ClubRoles = new List<ClubRole>();
      }
      /// <summary>
      /// ID of the club in the database.
      /// </summary>
      /// <value>ID of the club.</value>
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
      /// Members of the club in the database.
      /// </summary>
      /// <value>Members of the club.</value>
      public List<User> StudentsClubMembers { get; set; }
      /*
      /// <summary>
      /// Followers of the club in the database.
      /// </summary>
      /// <value>Followers of the club.</value>
      
      public List<User> StudentsClubFollowers { get; set; }
      /// <summary>
      /// Join requests of the club in the database.
      /// </summary>
      /// <value>Join requests of the club.</value>
      public List<User> StudentsJoinRequests { get; set; }
      /// <summary>
      /// Upcoming events of the club in the database.
      /// </summary>
      /// <value></value>
      public List<Event> EventsUpcoming { get; set; }
      */
      /// <summary>
      /// Old events of the club in the database.
      /// </summary>
      /// <value>Old events of the club.</value>
      public List<Event> EventsOld { get; set; }

      /// <summary>
      /// ID of the president of the club in the database.
      /// </summary>
      /// <value>ID of the club president.</value>
      public int ClubPresidentID { get; set; }
      /// <summary>
      /// Image URL of the club.
      /// </summary>
      /// <value>Image URL of the club.</value>
      public string ImageURL { get; set; }
      /// <summary>
      /// Budget of the club in the database.
      /// </summary>
      /// <value></value>
      public int ClubBudget { get; set; }
      /// <summary>
      /// Club roles of the club.
      /// </summary>
      /// <value>Club roles.</value>
      public List<ClubRole> ClubRoles { get; set; }

      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string WhatsappLink { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string InstagramLink { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string FacebookLink { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string TelegramLink { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string LinkedinLink { get; set; }
      /// <summary>
      /// 
      /// </summary>
      /// <value></value>
      public string TwitterLink { get; set; }
   }
}
