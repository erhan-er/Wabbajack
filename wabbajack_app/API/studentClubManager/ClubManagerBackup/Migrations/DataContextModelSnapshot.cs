﻿// <auto-generated />
using System;
using ClubManagerBackup.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClubManagerBackup.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClubManagerBackup.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Club", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubBudget")
                        .HasColumnType("int");

                    b.Property<string>("ClubDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClubPresidentID")
                        .HasColumnType("int");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedinLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.Property<string>("TelegramLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsappLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.ClubRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<string>("ClubRoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.ToTable("ClubRole");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ClubBoardMemberID")
                        .HasColumnType("int");

                    b.Property<int>("ClubID")
                        .HasColumnType("int");

                    b.Property<string>("ClubName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventCost")
                        .HasColumnType("int");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NotificationID")
                        .HasColumnType("int");

                    b.Property<int>("PlaceID")
                        .HasColumnType("int");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClubBoardMemberID");

                    b.HasIndex("ClubID");

                    b.HasIndex("NotificationID");

                    b.HasIndex("StudentID");

                    b.ToTable("Events");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Event");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Notification", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NotificationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("notificationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.HasIndex("UserID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Place", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Building")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventID")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClubID");

                    b.HasIndex("EventID");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.StudentEvent", b =>
                {
                    b.HasBaseType("ClubManagerBackup.Entities.Event");

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int?>("StudentID1")
                        .HasColumnType("int");

                    b.HasIndex("AdminID");

                    b.HasIndex("StudentID1");

                    b.HasDiscriminator().HasValue("StudentEvent");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Admin", b =>
                {
                    b.HasBaseType("ClubManagerBackup.Entities.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.ClubBoardMember", b =>
                {
                    b.HasBaseType("ClubManagerBackup.Entities.User");

                    b.Property<string>("RoleOfMember")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ClubBoardMember");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Student", b =>
                {
                    b.HasBaseType("ClubManagerBackup.Entities.User");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasIndex("StudentID");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.ClubPresident", b =>
                {
                    b.HasBaseType("ClubManagerBackup.Entities.ClubBoardMember");

                    b.HasDiscriminator().HasValue("ClubPresident");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Club", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Student", null)
                        .WithMany("FollowedClubs")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.ClubRole", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Club", null)
                        .WithMany("ClubRoles")
                        .HasForeignKey("ClubID");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Event", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.ClubBoardMember", null)
                        .WithMany("CreatedEvents")
                        .HasForeignKey("ClubBoardMemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubManagerBackup.Entities.Club", null)
                        .WithMany("EventsOld")
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubManagerBackup.Entities.Notification", "Notification")
                        .WithMany()
                        .HasForeignKey("NotificationID");

                    b.HasOne("ClubManagerBackup.Entities.Student", null)
                        .WithMany("AppliedEvents")
                        .HasForeignKey("StudentID");

                    b.Navigation("Notification");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Notification", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Student", null)
                        .WithMany("Invitations")
                        .HasForeignKey("StudentID");

                    b.HasOne("ClubManagerBackup.Entities.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.User", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Club", null)
                        .WithMany("StudentsClubMembers")
                        .HasForeignKey("ClubID");

                    b.HasOne("ClubManagerBackup.Entities.Event", null)
                        .WithMany("Participants")
                        .HasForeignKey("EventID");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.StudentEvent", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Admin", null)
                        .WithMany("RequestedEvents")
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubManagerBackup.Entities.Student", null)
                        .WithMany("CreatedEvents")
                        .HasForeignKey("StudentID1");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Student", b =>
                {
                    b.HasOne("ClubManagerBackup.Entities.Student", null)
                        .WithMany("Friends")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Club", b =>
                {
                    b.Navigation("ClubRoles");

                    b.Navigation("EventsOld");

                    b.Navigation("StudentsClubMembers");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Event", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.User", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Admin", b =>
                {
                    b.Navigation("RequestedEvents");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.ClubBoardMember", b =>
                {
                    b.Navigation("CreatedEvents");
                });

            modelBuilder.Entity("ClubManagerBackup.Entities.Student", b =>
                {
                    b.Navigation("AppliedEvents");

                    b.Navigation("CreatedEvents");

                    b.Navigation("FollowedClubs");

                    b.Navigation("Friends");

                    b.Navigation("Invitations");
                });
#pragma warning restore 612, 618
        }
    }
}
