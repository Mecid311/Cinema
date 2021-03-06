USE [Cinema]
GO
/****** Object:  Schema [Membership]    Script Date: 17.01.2021 20:39:19 ******/
CREATE SCHEMA [Membership]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.01.2021 20:39:19 ******/
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
/****** Object:  Table [dbo].[Bankclients]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bankclients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[CartNumber] [decimal](18, 2) NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
	[Cvc] [nvarchar](max) NOT NULL,
	[Money] [real] NOT NULL,
 CONSTRAINT [PK_Bankclients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bankcustoms]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bankcustoms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[CartNumber] [decimal](18, 2) NOT NULL,
	[Date] [nvarchar](max) NOT NULL,
	[Cvc] [nvarchar](max) NOT NULL,
	[Money] [real] NOT NULL,
 CONSTRAINT [PK_Bankcustoms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BtheSes]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BtheSes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Video_Photo] [nvarchar](max) NULL,
	[MoviedetailId] [int] NOT NULL,
 CONSTRAINT [PK_BtheSes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Casts]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Casts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](max) NULL,
	[Rolename] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Casts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Location] [nvarchar](max) NULL,
	[Number1] [nvarchar](max) NULL,
	[Number2] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactuses]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Comment] [nvarchar](max) NULL,
	[Answer] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contactuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Directors]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Directors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Extras]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Extras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Packet] [nvarchar](max) NULL,
	[Cost] [nvarchar](max) NULL,
	[Desc] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Extras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formats]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Formats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Languages] [nvarchar](max) NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mcasts]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mcasts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MoviedetailId] [int] NOT NULL,
	[CastId] [int] NOT NULL,
 CONSTRAINT [PK_Mcasts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mcats]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mcats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[MoviedetailId] [int] NOT NULL,
 CONSTRAINT [PK_Mcats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mformats]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mformats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MoviedetailId] [int] NOT NULL,
	[FormatId] [int] NOT NULL,
 CONSTRAINT [PK_Mformats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moviedetails]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moviedetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Startdate] [datetime2](7) NOT NULL,
	[Enddate] [datetime2](7) NOT NULL,
	[Trailer] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[TitleImage] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[Desc] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[Time] [nvarchar](max) NULL,
	[Agelimit] [nvarchar](max) NULL,
	[Subtitles] [nvarchar](max) NULL,
	[LanguageId] [int] NOT NULL,
	[DirectorId] [int] NOT NULL,
 CONSTRAINT [PK_Moviedetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partners]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partners](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Partners] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seats]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Row] [nvarchar](max) NULL,
	[Column] [int] NOT NULL,
	[No] [nvarchar](max) NULL,
 CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socialmedias]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socialmedias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Socialmedias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Totalamount] [nvarchar](max) NULL,
	[Clientcode] [nvarchar](max) NULL,
	[ExtraId] [int] NOT NULL,
	[MoviedetailId] [int] NOT NULL,
	[SeatId] [int] NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[RoleClaims]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[Roles]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[UserClaims]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[UserLogins]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[UserRoles]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[UserRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Membership].[Users]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Membership].[UserTokens]    Script Date: 17.01.2021 20:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Membership].[UserTokens](
	[UserId] [int] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210114093711_init', N'3.1.10')
GO
SET IDENTITY_INSERT [dbo].[BtheSes] ON 

INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (1, N'BtheS-980a50e4-5909-468a-836f-6f3d857f8a8d.jpg', 1)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (2, N'BtheS-af859852-6a3e-4eb2-8fd1-393c78ae5542.jpg', 1)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (3, N'BtheS-4b0d2e3c-2c64-4583-a469-93723f83c362.jpg', 1)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (4, N'BtheS-c882650a-f0c2-4131-bdd1-cce8693d1ffd.jpg', 1)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (5, N'BtheS-37af5979-7c1b-49d6-9e35-8b4ff5fdea91.jpg', 2)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (6, N'BtheS-5830bee0-d81d-490f-b099-63b837553d7b.jpg', 2)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (7, N'BtheS-56b69156-970b-4517-a888-a647c423f004.jpg', 2)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (8, N'BtheS-76c1a5bd-b9e8-4742-bb96-97d81d2f16a3.jpg', 3)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (9, N'BtheS-9030831b-323b-42c9-ba45-2d2c1d24b9d2.jpg', 3)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (10, N'BtheS-96a14751-0f8c-4728-b290-53476bd10222.jpg', 3)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (12, N'BtheS-786f5ecf-2e70-49f1-8dd2-71f023637e32.jpg', 5)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (13, N'BtheS-7e5e0a72-20ec-492b-9d86-b12138b22f85.jpg', 5)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (14, N'BtheS-980a50e4-5909-468a-836f-6f3d857f8a8d.jpg', 6)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (15, N'BtheS-af859852-6a3e-4eb2-8fd1-393c78ae5542.jpg', 6)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (16, N'BtheS-4b0d2e3c-2c64-4583-a469-93723f83c362.jpg', 6)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (17, N'BtheS-c882650a-f0c2-4131-bdd1-cce8693d1ffd.jpg', 6)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (18, N'BtheS-76c1a5bd-b9e8-4742-bb96-97d81d2f16a3.jpg', 7)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (19, N'BtheS-9030831b-323b-42c9-ba45-2d2c1d24b9d2.jpg', 7)
INSERT [dbo].[BtheSes] ([Id], [Video_Photo], [MoviedetailId]) VALUES (20, N'BtheS-96a14751-0f8c-4728-b290-53476bd10222.jpg', 7)
SET IDENTITY_INSERT [dbo].[BtheSes] OFF
GO
SET IDENTITY_INSERT [dbo].[Casts] ON 

INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (1, N'Ceyhun Babayev', N'İlknur', N'cast-f7f8e669-95e8-438c-b024-3f0a6b0ed812.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (2, N'İlkin Abdullayev', N'Seymur', N'cast-01487c67-51fa-4832-9dd8-9990494710fd.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (3, N'Günel Hesenova', N'Nuray', N'cast-0937ea87-56a1-4985-9518-93f5cd205d90.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (4, N'Aytac Qasımova', N'Firuzə', N'cast-7302d9d9-ee2e-466a-94dc-eeb3aaf18df3.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (5, N'Nərmin Hacıyeva', N'Fəridə', N'cast-c6599366-489f-49eb-bc54-e43b8f862a6a.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (6, N'Aynur Quliyeva', N'Elnarə', N'cast-2ad05286-32c2-4e85-8f5c-2b1dea781ab8.jpg')
INSERT [dbo].[Casts] ([Id], [Fullname], [Rolename], [Image]) VALUES (7, N'Fidan Ələkbərova', N'Günay', N'cast-accdf88b-58a2-45a8-8d9b-7022becf7687.jpg')
SET IDENTITY_INSERT [dbo].[Casts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Action')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Drama')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Romantic')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Comedy')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Location], [Number1], [Number2], [Link], [Mail]) VALUES (1, N'601 - Ram Nagar , IndiaOmex City 245 , America', N'+994505011377', N'+994559198668', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.428490145666!2d49.85175681531934!3d40.37719496596716!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d079efb5163%3A0xc20aa51a5f0b5e01!2sCode%20Academy!5e0!3m2!1str!2s!4v1604518851404!5m2!1str!2s', N'majidan@code.edu.az')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Contactuses] ON 

INSERT [dbo].[Contactuses] ([Id], [Name], [Mail], [Comment], [Answer]) VALUES (1, N'Mecid Necefov', N'necefovmecid@gmail.com', N'Comment', N'<p>Yes</p>')
SET IDENTITY_INSERT [dbo].[Contactuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Directors] ON 

INSERT [dbo].[Directors] ([Id], [Name]) VALUES (1, N'İlkin Həsənov')
INSERT [dbo].[Directors] ([Id], [Name]) VALUES (2, N'Gülşən Hacıyeva')
SET IDENTITY_INSERT [dbo].[Directors] OFF
GO
SET IDENTITY_INSERT [dbo].[Extras] ON 

INSERT [dbo].[Extras] ([Id], [Packet], [Cost], [Desc], [Image]) VALUES (1, N'Single Packet', N'5', N'1 hamburger,1 fanta', N'extra-bb9d5514-5f75-4b94-a7a2-7be8911ab871.png')
INSERT [dbo].[Extras] ([Id], [Packet], [Cost], [Desc], [Image]) VALUES (2, N'Group Paket', N'10', N'4 çizburger ,4 kola', N'extra-5879dd28-9dbc-480e-9218-bab52b14319f.png')
SET IDENTITY_INSERT [dbo].[Extras] OFF
GO
SET IDENTITY_INSERT [dbo].[Formats] ON 

INSERT [dbo].[Formats] ([Id], [Name]) VALUES (1, N'2D')
INSERT [dbo].[Formats] ([Id], [Name]) VALUES (2, N'3D')
INSERT [dbo].[Formats] ([Id], [Name]) VALUES (3, N'5D')
SET IDENTITY_INSERT [dbo].[Formats] OFF
GO
SET IDENTITY_INSERT [dbo].[Languages] ON 

INSERT [dbo].[Languages] ([Id], [Languages]) VALUES (1, N'Azərbaycan')
INSERT [dbo].[Languages] ([Id], [Languages]) VALUES (2, N'Türk')
SET IDENTITY_INSERT [dbo].[Languages] OFF
GO
SET IDENTITY_INSERT [dbo].[Mcasts] ON 

INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (1, 1, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (2, 1, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (3, 1, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (4, 1, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (5, 1, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (6, 1, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (7, 1, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (8, 2, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (9, 2, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (10, 2, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (11, 2, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (12, 2, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (13, 2, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (14, 2, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (15, 2, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (16, 3, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (17, 1, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (18, 1, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (19, 1, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (20, 1, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (21, 1, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (22, 1, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (23, 1, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (25, 5, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (26, 5, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (27, 5, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (28, 5, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (29, 5, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (30, 5, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (31, 5, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (32, 6, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (33, 6, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (34, 6, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (35, 6, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (36, 6, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (37, 6, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (38, 6, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (39, 6, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (40, 7, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (41, 7, 1)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (42, 7, 2)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (43, 7, 5)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (44, 7, 7)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (45, 7, 3)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (46, 7, 6)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (47, 7, 4)
INSERT [dbo].[Mcasts] ([Id], [MoviedetailId], [CastId]) VALUES (48, 7, 5)
SET IDENTITY_INSERT [dbo].[Mcasts] OFF
GO
SET IDENTITY_INSERT [dbo].[Mcats] ON 

INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (1, 1, 1)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (2, 3, 1)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (3, 4, 2)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (4, 1, 3)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (6, 1, 5)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (7, 2, 6)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (8, 1, 7)
INSERT [dbo].[Mcats] ([Id], [CategoryId], [MoviedetailId]) VALUES (9, 3, 7)
SET IDENTITY_INSERT [dbo].[Mcats] OFF
GO
SET IDENTITY_INSERT [dbo].[Mformats] ON 

INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (1, 1, 1)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (2, 1, 2)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (3, 2, 2)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (4, 3, 3)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (5, 3, 2)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (7, 5, 2)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (8, 6, 3)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (9, 7, 2)
INSERT [dbo].[Mformats] ([Id], [MoviedetailId], [FormatId]) VALUES (10, 7, 1)
SET IDENTITY_INSERT [dbo].[Mformats] OFF
GO
SET IDENTITY_INSERT [dbo].[Moviedetails] ON 

INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (1, N'Zirveye Giden Yol', CAST(N'2021-01-17T15:30:00.0000000' AS DateTime2), CAST(N'2022-02-15T15:30:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/2LqzF5WauAw', N'movie-22ae3e17-35af-49f0-b623-e5711a6fe0ef.jpg', N'movie-98fc9120-3295-4346-a7c4-eac71c12a67a.jpg', N'15 ', N'Stephen Myers, Vali Mike Morris’in seçim kampanyalarında başkan yardımcısı olarak çalışmaktadır. Vali Morris Başkanlık seçimlerinde Demokrat Parti’den adaylığını kazanma şansını zorlarken, Ohio’da tam bir siyasi mücadele yaşanmaktadır. Rakip adayın kampanya başkanı, Stephen’a onların ekibine katılmasını teklif eder. Stephen patronunu bu tekliften haberdar etme gafletinde bulunur. Stephen’ın bu usulsüz davranışı ortaya çıkarken, o da durumu lehine çevirebilmek için Vali Morris’in siyasi kariyerini tehlikeye sokacak kişisel bir sırrını açık etmek üzere harekete geçer.', N'Azerbaycan', N'1saat', N'18+', N'AZE', 1, 1)
INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (2, N'Beceriksiz Katil', CAST(N'2021-01-17T16:48:00.0000000' AS DateTime2), CAST(N'2021-02-18T01:48:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/sQh7fr53Xy0', N'movie-1a235480-4fa6-4ab7-844a-3ab87a3bbb5f.jpg', N'movie-ca647718-4db0-4118-b58a-2dc27a78cb82.jpg', N'12 ', N'Fakat bunca zaman şans hiç yüzlerine gülmemiştir. Sarı, erken yaşta ailesini kaybetmiş, zar zor bir üniversite bitirmiş hemen sonra iki aydır tanıdığı ve hayatımın aşkı dediği biriyle evlenmiştir. Evlendikten hemen sonra gelin, düğünde takılan takılar ve o güne kadar birikmiş ne var ne yoksa sırra kadem basmıştır. Şener ise sadece uzmanlık alanı olan “borç batağından çıkma” konusunda her zaman olduğu gibi arkadaşına tam destek göstermiştir. Borçlarından kurtulmak için Şener, Sarı’ya kumar oynamayı teklif etmiştir. Başta her şey şaşırılacak derecede güzel gider. Fakat bu durum uzun sürmez.', N'Azerbaycan', N'1saat', N'18+', N'AZE', 2, 2)
INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (3, N'Son Vurgun', CAST(N'2021-01-17T14:58:00.0000000' AS DateTime2), CAST(N'2021-02-21T14:58:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/o2v002Q3wRs', N'movie-23519836-132b-477a-98a8-0af346926fc4.jpg', N'movie-f7bf2ffb-6184-469b-8a7b-2b65312b60f9.jpg', N'15 ', N'Terkedilmiş bir depoda soygunu planlarlar. Ancak Emily’ye (Brewster) duydukları “ilgi” iki kardeş arasında gerilimi yükseltir. Plan şudur: Soygunun olacağı gün, James şehrin karşı tarafında birçok araba çalacak ve onlara patlayıcı yerleştirecektir.  Yine şehrin karşın kıyısında birkaç anarşist grup tutarak, şehirde kaos yaratmalarını isterler. Örneğin, hayvanat bahçesinden hayvanların salıverilmesi, diğer bankalara saldırı düzenlemek gibi.  Sugar (Akon) polislerle müthiş bir kovalamacaya girerken, Brooklyn’de bombalar ardı ardına patlamaya başlar. Frankie ve çetesi, yüzlerine taktıkları maskelerle bankaya girerler ve “gerçek” soygun başlar. Ancak civardaki polislerin ilgisi bankaya yoğunlaşınca, silahlı çatışma başlar. Çete bankada sıkışıp kalmıştır…', N'Azerbaycan', N'1saat', N'18+', N'AZE', 1, 1)
INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (5, N' Interstellar', CAST(N'2021-01-31T13:45:00.0000000' AS DateTime2), CAST(N'2021-02-28T13:45:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/2LqzF5WauAw', N'movie-ff59be5f-1645-4db6-b5ff-4c214fdbef26.jpg', N'movie-34d01e44-f15d-4ba9-a2c2-03fa5b66245b.jpg', N'15', N'Interstellar is a 2014 American-British epic science fiction film directed and produced by Christopher Nolan. It stars Matthew McConaughey, Anne Hathaway, Jessica Chastain, Bill Irwin, Ellen Burstyn, John Lithgow, Michael Caine, and Matt Damon. Set in a dystopian future where humanity is struggling to survive, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for mankind.', N'Azerbaycan', N'1saat', N'18+', N'AZE', 2, 2)
INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (6, N'365 Gun', CAST(N'2021-01-27T14:58:00.0000000' AS DateTime2), CAST(N'2021-02-21T14:58:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/o2v002Q3wRs', N'movie-23519836-132b-477a-98a8-0af346926fc4.jpg', N'movie-f7bf2ffb-6184-469b-8a7b-2b65312b60f9.jpg', N'15 ', N'Terkedilmiş bir depoda soygunu planlarlar. Ancak Emily’ye (Brewster) duydukları “ilgi” iki kardeş arasında gerilimi yükseltir. Plan şudur: Soygunun olacağı gün, James şehrin karşı tarafında birçok araba çalacak ve onlara patlayıcı yerleştirecektir.  Yine şehrin karşın kıyısında birkaç anarşist grup tutarak, şehirde kaos yaratmalarını isterler. Örneğin, hayvanat bahçesinden hayvanların salıverilmesi, diğer bankalara saldırı düzenlemek gibi.  Sugar (Akon) polislerle müthiş bir kovalamacaya girerken, Brooklyn’de bombalar ardı ardına patlamaya başlar. Frankie ve çetesi, yüzlerine taktıkları maskelerle bankaya girerler ve “gerçek” soygun başlar. Ancak civardaki polislerin ilgisi bankaya yoğunlaşınca, silahlı çatışma başlar. Çete bankada sıkışıp kalmıştır…', N'Azerbaycan', N'1saat', N'18+', N'AZE', 1, 1)
INSERT [dbo].[Moviedetails] ([Id], [Name], [Startdate], [Enddate], [Trailer], [Image], [TitleImage], [Price], [Desc], [Country], [Time], [Agelimit], [Subtitles], [LanguageId], [DirectorId]) VALUES (7, N'Driving', CAST(N'2021-01-18T16:48:00.0000000' AS DateTime2), CAST(N'2021-02-18T01:48:00.0000000' AS DateTime2), N'https://www.youtube.com/embed/sQh7fr53Xy0', N'movie-1a235480-4fa6-4ab7-844a-3ab87a3bbb5f.jpg', N'movie-ca647718-4db0-4118-b58a-2dc27a78cb82.jpg', N'12 ', N'Fakat bunca zaman şans hiç yüzlerine gülmemiştir. Sarı, erken yaşta ailesini kaybetmiş, zar zor bir üniversite bitirmiş hemen sonra iki aydır tanıdığı ve hayatımın aşkı dediği biriyle evlenmiştir. Evlendikten hemen sonra gelin, düğünde takılan takılar ve o güne kadar birikmiş ne var ne yoksa sırra kadem basmıştır. Şener ise sadece uzmanlık alanı olan “borç batağından çıkma” konusunda her zaman olduğu gibi arkadaşına tam destek göstermiştir. Borçlarından kurtulmak için Şener, Sarı’ya kumar oynamayı teklif etmiştir. Başta her şey şaşırılacak derecede güzel gider. Fakat bu durum uzun sürmez.', N'Azerbaycan', N'1saat', N'18+', N'AZE', 2, 2)
SET IDENTITY_INSERT [dbo].[Moviedetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (1, N' Kapital Bank', N'part-b54ecec8-b8b2-4656-96c5-103e90f9259c.png')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (2, N'Netflix Türkiye', N'part-f897862c-970a-4309-9d9e-1e8044b53d32.jpg')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (3, N'Formula-1', N'part-0b279548-aba5-4aac-807e-c0ddb295a7c6.jpg')
INSERT [dbo].[Partners] ([Id], [Name], [Logo]) VALUES (4, N'Paşa Bank', N'part-118516c5-a496-4e29-9d0a-0640500e11e8.jpg')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[Seats] ON 

INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (1, N'C', 1, N'c24')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (2, N'C', 1, N'c25')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (3, N'C', 1, N'c26')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (4, N'C', 1, N'c27')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (5, N'C', 1, N'c28')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (6, N'C', 2, N'c29')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (7, N'C', 2, N'c30')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (8, N'C', 2, N'c31')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (9, N'C', 2, N'c32')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (10, N'C', 2, N'c33')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (11, N'C', 2, N'c34')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (12, N'C', 2, N'c35')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (13, N'C', 2, N'c36')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (14, N'C', 2, N'c37')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (15, N'C', 2, N'c38')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (16, N'C', 2, N'c39')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (17, N'C', 2, N'c40')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (18, N'C', 2, N'c41')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (19, N'C', 3, N'c42')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (20, N'C', 3, N'c43')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (21, N'C', 3, N'c44')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (22, N'C', 3, N'c45')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (23, N'C', 3, N'c46')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (24, N'B', 1, N'c47')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (25, N'B', 1, N'c48')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (26, N'B', 1, N'c49')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (27, N'B', 1, N'c50')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (28, N'B', 1, N'c51')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (29, N'B', 2, N'c52')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (30, N'B', 2, N'c53')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (31, N'B', 2, N'c54')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (32, N'B', 2, N'c55')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (33, N'B', 2, N'c56')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (34, N'B', 2, N'c57')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (35, N'B', 2, N'c58')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (36, N'B', 2, N'c59')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (37, N'B', 2, N'c60')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (38, N'B', 2, N'c61')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (39, N'B', 2, N'c62')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (40, N'B', 2, N'c63')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (41, N'B', 2, N'c64')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (42, N'B', 3, N'c65')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (43, N'B', 3, N'c66')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (44, N'B', 3, N'c67')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (45, N'B', 3, N'c68')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (46, N'B', 3, N'c69')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (47, N'A', 1, N'c70')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (48, N'A', 1, N'c71')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (49, N'A', 1, N'c72')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (50, N'A', 1, N'c73')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (51, N'A', 1, N'c74')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (52, N'A', 2, N'c75')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (53, N'A', 2, N'c76')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (54, N'A', 2, N'c77')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (55, N'A', 2, N'c78')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (56, N'A', 2, N'c79')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (57, N'A', 2, N'c80')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (58, N'A', 2, N'c81')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (59, N'A', 2, N'c82')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (60, N'A', 2, N'c83')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (61, N'A', 2, N'c84')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (62, N'A', 2, N'c85')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (63, N'A', 2, N'c86')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (64, N'A', 2, N'c87')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (65, N'A', 3, N'c88')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (66, N'A', 3, N'c89')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (67, N'A', 3, N'c90')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (68, N'A', 3, N'c91')
INSERT [dbo].[Seats] ([Id], [Row], [Column], [No]) VALUES (69, N'A', 3, N'c92')
SET IDENTITY_INSERT [dbo].[Seats] OFF
GO
SET IDENTITY_INSERT [dbo].[Socialmedias] ON 

INSERT [dbo].[Socialmedias] ([Id], [Name], [Link], [Logo]) VALUES (1, N'Facebook', N'https://www.facebook.com/', N'fab fa-facebook')
INSERT [dbo].[Socialmedias] ([Id], [Name], [Link], [Logo]) VALUES (2, N'Instagram', N'https://www.instagram.com/', N'fab fa-instagram')
SET IDENTITY_INSERT [dbo].[Socialmedias] OFF
GO
SET IDENTITY_INSERT [dbo].[Tickets] ON 

INSERT [dbo].[Tickets] ([Id], [Totalamount], [Clientcode], [ExtraId], [MoviedetailId], [SeatId]) VALUES (1, N'20', N'1', 1, 1, 11)
INSERT [dbo].[Tickets] ([Id], [Totalamount], [Clientcode], [ExtraId], [MoviedetailId], [SeatId]) VALUES (2, N'20', N'19032', 1, 1, 15)
INSERT [dbo].[Tickets] ([Id], [Totalamount], [Clientcode], [ExtraId], [MoviedetailId], [SeatId]) VALUES (3, N'22', N'13149', 2, 2, 36)
INSERT [dbo].[Tickets] ([Id], [Totalamount], [Clientcode], [ExtraId], [MoviedetailId], [SeatId]) VALUES (4, N'25', N'15773', 2, 3, 39)
SET IDENTITY_INSERT [dbo].[Tickets] OFF
GO
SET IDENTITY_INSERT [Membership].[Roles] ON 

INSERT [Membership].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (1, N'SuperAdmin', N'SUPERADMIN', N'cb371dfe-3e5c-4dcd-b08d-a001a9556e66')
SET IDENTITY_INSERT [Membership].[Roles] OFF
GO
SET IDENTITY_INSERT [Membership].[Users] ON 

INSERT [Membership].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (1, N'mecid', N'MECID', N'majidan@code.edu.az', N'MAJIDAN@CODE.EDU.AZ', 0, N'AQAAAAEAACcQAAAAEI3idfixEoz5zLMsqrWPMTr7vvqFl7iUN7R4//nQYXYbn2lzjm4jt9VK4dkyrm9bFA==', N'MS52IQNIHUUVXPCQH5EQHJP2R4OCBPLK', N'eb4b250e-6708-4bf6-8004-73c5a0414c11', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [Membership].[Users] OFF
GO
ALTER TABLE [dbo].[BtheSes]  WITH CHECK ADD  CONSTRAINT [FK_BtheSes_Moviedetails_MoviedetailId] FOREIGN KEY([MoviedetailId])
REFERENCES [dbo].[Moviedetails] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BtheSes] CHECK CONSTRAINT [FK_BtheSes_Moviedetails_MoviedetailId]
GO
ALTER TABLE [dbo].[Mcasts]  WITH CHECK ADD  CONSTRAINT [FK_Mcasts_Casts_CastId] FOREIGN KEY([CastId])
REFERENCES [dbo].[Casts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mcasts] CHECK CONSTRAINT [FK_Mcasts_Casts_CastId]
GO
ALTER TABLE [dbo].[Mcasts]  WITH CHECK ADD  CONSTRAINT [FK_Mcasts_Moviedetails_MoviedetailId] FOREIGN KEY([MoviedetailId])
REFERENCES [dbo].[Moviedetails] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mcasts] CHECK CONSTRAINT [FK_Mcasts_Moviedetails_MoviedetailId]
GO
ALTER TABLE [dbo].[Mcats]  WITH CHECK ADD  CONSTRAINT [FK_Mcats_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mcats] CHECK CONSTRAINT [FK_Mcats_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Mcats]  WITH CHECK ADD  CONSTRAINT [FK_Mcats_Moviedetails_MoviedetailId] FOREIGN KEY([MoviedetailId])
REFERENCES [dbo].[Moviedetails] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mcats] CHECK CONSTRAINT [FK_Mcats_Moviedetails_MoviedetailId]
GO
ALTER TABLE [dbo].[Mformats]  WITH CHECK ADD  CONSTRAINT [FK_Mformats_Formats_FormatId] FOREIGN KEY([FormatId])
REFERENCES [dbo].[Formats] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mformats] CHECK CONSTRAINT [FK_Mformats_Formats_FormatId]
GO
ALTER TABLE [dbo].[Mformats]  WITH CHECK ADD  CONSTRAINT [FK_Mformats_Moviedetails_MoviedetailId] FOREIGN KEY([MoviedetailId])
REFERENCES [dbo].[Moviedetails] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mformats] CHECK CONSTRAINT [FK_Mformats_Moviedetails_MoviedetailId]
GO
ALTER TABLE [dbo].[Moviedetails]  WITH CHECK ADD  CONSTRAINT [FK_Moviedetails_Directors_DirectorId] FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directors] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Moviedetails] CHECK CONSTRAINT [FK_Moviedetails_Directors_DirectorId]
GO
ALTER TABLE [dbo].[Moviedetails]  WITH CHECK ADD  CONSTRAINT [FK_Moviedetails_Languages_LanguageId] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Moviedetails] CHECK CONSTRAINT [FK_Moviedetails_Languages_LanguageId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Extras_ExtraId] FOREIGN KEY([ExtraId])
REFERENCES [dbo].[Extras] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Extras_ExtraId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Moviedetails_MoviedetailId] FOREIGN KEY([MoviedetailId])
REFERENCES [dbo].[Moviedetails] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Moviedetails_MoviedetailId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_Seats_SeatId] FOREIGN KEY([SeatId])
REFERENCES [dbo].[Seats] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_Seats_SeatId]
GO
ALTER TABLE [Membership].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Membership].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [Membership].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Membership].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [Membership].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Membership].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [Membership].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Membership].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [Membership].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Membership].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [Membership].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Membership].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Membership].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
