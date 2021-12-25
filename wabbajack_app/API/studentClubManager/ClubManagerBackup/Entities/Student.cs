using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Entities
{
   /// <summary>
   /// Student object. Student is a User.
   /// </summary>
   [NotMapped]
   public class Student : User
   {
      /// <summary>
      /// Constructor for Student.
      /// </summary>
      public Student()
      {
         FollowedClubs = new List<Club>();
         AppliedEvents = new List<Event>();
         CreatedEvents = new List<StudentEvent>();
         Friends = new List<Student>();
         Invitations = new List<Notification>();
      }
      /// <summary>
      /// Followed clubs of student.
      /// </summary>
      /// <value>Followed clubs of student.</value>
      public List<Club> FollowedClubs { get; set; }
      /// <summary>
      /// Participated events of the student.
      /// </summary>
      /// <value>Participated events of the student.</value>
      public List<Event> AppliedEvents { get; set; }
      /// <summary>
      /// Created student events of student.
      /// </summary>
      /// <value>Created student events of student.</value>
      public List<StudentEvent> CreatedEvents { get; set; }
      /// <summary>
      /// Friends of the student.
      /// </summary>
      /// <value>Friends of the student.</value>
      public List<Student> Friends { get; set; }
      /// <summary>
      /// Invitations to events of student.
      /// </summary>
      /// <value>Invitations to events of student.</value>
      public List<Notification> Invitations { get; set; }
   }
}
