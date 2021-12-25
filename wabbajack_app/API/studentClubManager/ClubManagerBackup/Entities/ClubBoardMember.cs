using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Club board member object.
   /// </summary>
   public class ClubBoardMember : User
   {
      /// <summary>
      /// Constructor for ClubBoardMember.
      /// </summary>
      public ClubBoardMember()
      {
         CreatedEvents = new List<Event>();
      }
      /// <summary>
      /// Role of the member in the club.
      /// </summary>
      /// <value>Role of the member.</value>
      public String RoleOfMember { get; set; }
      /// <summary>
      /// Created events of the board member.
      /// </summary>
      /// <value></value>
      public List<Event> CreatedEvents { get; set; }
   }
}
