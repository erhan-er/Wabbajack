USE [master]
GO
/****** Object:  Database [ClubManagerDb]    Script Date: 22/11/2021 01:04:47 ******/
CREATE DATABASE [ClubManagerDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClubManagerDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ClubManagerDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClubManagerDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ClubManagerDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ClubManagerDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClubManagerDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClubManagerDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClubManagerDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClubManagerDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClubManagerDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClubManagerDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClubManagerDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ClubManagerDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClubManagerDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClubManagerDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClubManagerDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClubManagerDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClubManagerDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClubManagerDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClubManagerDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClubManagerDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ClubManagerDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClubManagerDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClubManagerDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClubManagerDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClubManagerDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClubManagerDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ClubManagerDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClubManagerDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClubManagerDb] SET  MULTI_USER 
GO
ALTER DATABASE [ClubManagerDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClubManagerDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClubManagerDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClubManagerDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClubManagerDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClubManagerDb] SET QUERY_STORE = OFF
GO
USE [ClubManagerDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClubRole]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClubRole](
	[ClubRoleID] [int] IDENTITY(1,1) NOT NULL,
	[ClubRoleName] [nvarchar](max) NULL,
	[ClubID] [int] NULL,
 CONSTRAINT [PK_ClubRole] PRIMARY KEY CLUSTERED 
(
	[ClubRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ClubDescription] [nvarchar](max) NULL,
	[SocialMediaAccountID] [int] NULL,
	[ClubPresidentID] [int] NULL,
	[ClubBudget] [int] NOT NULL,
	[SearchClubSearchID] [int] NULL,
	[StudentID] [int] NULL,
	[StudentID1] [int] NULL,
	[StudentID2] [int] NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ClubID] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[CategoryID] [int] NULL,
	[PlaceID] [int] NULL,
	[NotificationID] [int] NULL,
	[ImageURL] [nvarchar](max) NULL,
	[EventCost] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
	[ClubBoardMemberID] [int] NULL,
	[UserID] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[SearchEventSearchID] [int] NULL,
	[SearchEventSearchID1] [int] NULL,
	[StudentID] [int] NULL,
	[AdminID] [int] NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventStudent]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventStudent](
	[OldEventsID] [int] NOT NULL,
	[ParticipantsID] [int] NOT NULL,
 CONSTRAINT [PK_EventStudent] PRIMARY KEY CLUSTERED 
(
	[OldEventsID] ASC,
	[ParticipantsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[NotificationName] [nvarchar](max) NULL,
	[notificationDescription] [nvarchar](max) NULL,
	[StudentID] [int] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Notifications] PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Places]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[PlaceID] [int] IDENTITY(1,1) NOT NULL,
	[Building] [nvarchar](max) NULL,
	[Room] [nvarchar](max) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[PlaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Searches]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Searches](
	[SearchID] [int] IDENTITY(1,1) NOT NULL,
	[SearchBar] [nvarchar](max) NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Searches] PRIMARY KEY CLUSTERED 
(
	[SearchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocialMediaAccounts]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocialMediaAccounts](
	[SocialMediaAccountID] [int] IDENTITY(1,1) NOT NULL,
	[WhatsappLink] [nvarchar](max) NULL,
	[TwitterLink] [nvarchar](max) NULL,
	[FacebookLink] [nvarchar](max) NULL,
	[TelegramLink] [nvarchar](max) NULL,
	[LinkedInLink] [nvarchar](max) NULL,
 CONSTRAINT [PK_SocialMediaAccounts] PRIMARY KEY CLUSTERED 
(
	[SocialMediaAccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 22/11/2021 01:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[ClubID] [int] NULL,
	[ClubID1] [int] NULL,
	[ClubID2] [int] NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[RoleOfMember] [nvarchar](max) NULL,
	[Role] [nvarchar](max) NULL,
	[AdminID] [int] NULL,
	[SearchStudentSearchID] [int] NULL,
	[StudentID] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ClubRole_ClubID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_ClubRole_ClubID] ON [dbo].[ClubRole]
(
	[ClubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_ClubPresidentID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_ClubPresidentID] ON [dbo].[Clubs]
(
	[ClubPresidentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_SearchClubSearchID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_SearchClubSearchID] ON [dbo].[Clubs]
(
	[SearchClubSearchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_SocialMediaAccountID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_SocialMediaAccountID] ON [dbo].[Clubs]
(
	[SocialMediaAccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_StudentID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_StudentID] ON [dbo].[Clubs]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_StudentID1]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_StudentID1] ON [dbo].[Clubs]
(
	[StudentID1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Clubs_StudentID2]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Clubs_StudentID2] ON [dbo].[Clubs]
(
	[StudentID2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_AdminID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_AdminID] ON [dbo].[Events]
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_CategoryID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_CategoryID] ON [dbo].[Events]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_ClubBoardMemberID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_ClubBoardMemberID] ON [dbo].[Events]
(
	[ClubBoardMemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_ClubID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_ClubID] ON [dbo].[Events]
(
	[ClubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_NotificationID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_NotificationID] ON [dbo].[Events]
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_PlaceID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_PlaceID] ON [dbo].[Events]
(
	[PlaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_SearchEventSearchID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_SearchEventSearchID] ON [dbo].[Events]
(
	[SearchEventSearchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_SearchEventSearchID1]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_SearchEventSearchID1] ON [dbo].[Events]
(
	[SearchEventSearchID1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_StudentID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Events_StudentID] ON [dbo].[Events]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventStudent_ParticipantsID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_EventStudent_ParticipantsID] ON [dbo].[EventStudent]
(
	[ParticipantsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Notifications_StudentID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Notifications_StudentID] ON [dbo].[Notifications]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Notifications_UserID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Notifications_UserID] ON [dbo].[Notifications]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_AdminID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_AdminID] ON [dbo].[Users]
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_ClubID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_ClubID] ON [dbo].[Users]
(
	[ClubID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_ClubID1]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_ClubID1] ON [dbo].[Users]
(
	[ClubID1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_ClubID2]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_ClubID2] ON [dbo].[Users]
(
	[ClubID2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_SearchStudentSearchID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_SearchStudentSearchID] ON [dbo].[Users]
(
	[SearchStudentSearchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_StudentID]    Script Date: 22/11/2021 01:04:47 ******/
CREATE NONCLUSTERED INDEX [IX_Users_StudentID] ON [dbo].[Users]
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ClubRole]  WITH CHECK ADD  CONSTRAINT [FK_ClubRole_Clubs_ClubID] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Clubs] ([ID])
GO
ALTER TABLE [dbo].[ClubRole] CHECK CONSTRAINT [FK_ClubRole_Clubs_ClubID]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_Searches_SearchClubSearchID] FOREIGN KEY([SearchClubSearchID])
REFERENCES [dbo].[Searches] ([SearchID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_Searches_SearchClubSearchID]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_SocialMediaAccounts_SocialMediaAccountID] FOREIGN KEY([SocialMediaAccountID])
REFERENCES [dbo].[SocialMediaAccounts] ([SocialMediaAccountID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_SocialMediaAccounts_SocialMediaAccountID]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_Users_ClubPresidentID] FOREIGN KEY([ClubPresidentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_Users_ClubPresidentID]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_Users_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_Users_StudentID]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_Users_StudentID1] FOREIGN KEY([StudentID1])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_Users_StudentID1]
GO
ALTER TABLE [dbo].[Clubs]  WITH CHECK ADD  CONSTRAINT [FK_Clubs_Users_StudentID2] FOREIGN KEY([StudentID2])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Clubs] CHECK CONSTRAINT [FK_Clubs_Users_StudentID2]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Categories_CategoryID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Clubs_ClubID] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Clubs] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Clubs_ClubID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Notifications_NotificationID] FOREIGN KEY([NotificationID])
REFERENCES [dbo].[Notifications] ([NotificationID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Notifications_NotificationID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Places_PlaceID] FOREIGN KEY([PlaceID])
REFERENCES [dbo].[Places] ([PlaceID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Places_PlaceID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Searches_SearchEventSearchID] FOREIGN KEY([SearchEventSearchID])
REFERENCES [dbo].[Searches] ([SearchID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Searches_SearchEventSearchID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Searches_SearchEventSearchID1] FOREIGN KEY([SearchEventSearchID1])
REFERENCES [dbo].[Searches] ([SearchID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Searches_SearchEventSearchID1]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Users_AdminID] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Users_AdminID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Users_ClubBoardMemberID] FOREIGN KEY([ClubBoardMemberID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Users_ClubBoardMemberID]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Users_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Users_StudentID]
GO
ALTER TABLE [dbo].[EventStudent]  WITH CHECK ADD  CONSTRAINT [FK_EventStudent_Events_OldEventsID] FOREIGN KEY([OldEventsID])
REFERENCES [dbo].[Events] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventStudent] CHECK CONSTRAINT [FK_EventStudent_Events_OldEventsID]
GO
ALTER TABLE [dbo].[EventStudent]  WITH CHECK ADD  CONSTRAINT [FK_EventStudent_Users_ParticipantsID] FOREIGN KEY([ParticipantsID])
REFERENCES [dbo].[Users] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EventStudent] CHECK CONSTRAINT [FK_EventStudent_Users_ParticipantsID]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Users_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Users_StudentID]
GO
ALTER TABLE [dbo].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK_Notifications_Users_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Notifications] CHECK CONSTRAINT [FK_Notifications_Users_UserID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Clubs_ClubID] FOREIGN KEY([ClubID])
REFERENCES [dbo].[Clubs] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Clubs_ClubID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Clubs_ClubID1] FOREIGN KEY([ClubID1])
REFERENCES [dbo].[Clubs] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Clubs_ClubID1]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Clubs_ClubID2] FOREIGN KEY([ClubID2])
REFERENCES [dbo].[Clubs] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Clubs_ClubID2]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Searches_SearchStudentSearchID] FOREIGN KEY([SearchStudentSearchID])
REFERENCES [dbo].[Searches] ([SearchID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Searches_SearchStudentSearchID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_AdminID] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users_AdminID]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users_StudentID]
GO
USE [master]
GO
ALTER DATABASE [ClubManagerDb] SET  READ_WRITE 
GO
