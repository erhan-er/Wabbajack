using ClubManagerBackup.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubManagerBackup.Context
{
   public class DataContext : DbContext
   {
      public DataContext(DbContextOptions<DataContext> options) : base(options)
      {

      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(@"server=LAPTOP-6G581D4A\SQLEXPRESS;database=ClubManagerDb; integrated security=true;");
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Student>().HasBaseType<User>();
         modelBuilder.Entity<Admin>().HasBaseType<User>();
         //modelBuilder.Entity<ClubBoardMember>().HasBaseType<User>();
         modelBuilder.Entity<ClubPresident>().HasBaseType<Student>();
         modelBuilder.Entity<StudentEvent>().HasBaseType<Event>();
      }

      public DbSet<Admin> Admins { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<Club> Clubs { get; set; }
      //public DbSet<ClubBoardMember> ClubBoardMembers { get; set; }
      public DbSet<ClubPresident> ClubPresidents { get; set; }
      public DbSet<Event> Events { get; set; }
      public DbSet<Notification> Notifications { get; set; }
      public DbSet<Place> Places { get; set; }
      public DbSet<Student> Students { get; set; }
      public DbSet<StudentEvent> StudentEvents { get; set; }
      public DbSet<UserToEvent> UserToEvents { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<UserToClub> UserToClubs { get; set; }
   }
}
