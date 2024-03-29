USE [master]
GO
/****** Object:  Database [GuvenlikDb]    Script Date: 5.06.2022 20:46:12 ******/
CREATE DATABASE [GuvenlikDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GuvenlikDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\GuvenlikDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GuvenlikDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\GuvenlikDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GuvenlikDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GuvenlikDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GuvenlikDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GuvenlikDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GuvenlikDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GuvenlikDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GuvenlikDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [GuvenlikDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GuvenlikDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GuvenlikDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GuvenlikDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GuvenlikDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GuvenlikDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GuvenlikDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GuvenlikDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GuvenlikDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GuvenlikDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GuvenlikDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GuvenlikDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GuvenlikDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GuvenlikDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GuvenlikDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GuvenlikDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GuvenlikDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GuvenlikDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GuvenlikDb] SET  MULTI_USER 
GO
ALTER DATABASE [GuvenlikDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GuvenlikDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GuvenlikDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GuvenlikDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GuvenlikDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'GuvenlikDb', N'ON'
GO
ALTER DATABASE [GuvenlikDb] SET QUERY_STORE = OFF
GO
USE [GuvenlikDb]
GO
/****** Object:  Table [dbo].[GKatagori]    Script Date: 5.06.2022 20:46:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GKatagori](
	[KatagoriId] [int] IDENTITY(1,1) NOT NULL,
	[KatagoriAdi] [varchar](50) NULL,
 CONSTRAINT [PK_GKatagori] PRIMARY KEY CLUSTERED 
(
	[KatagoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GMusteri]    Script Date: 5.06.2022 20:46:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GMusteri](
	[MusteriId] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Telefon] [varchar](50) NULL,
	[Adres] [varchar](50) NULL,
 CONSTRAINT [PK_GMusteri] PRIMARY KEY CLUSTERED 
(
	[MusteriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GPersonel]    Script Date: 5.06.2022 20:46:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPersonel](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[PerAdSoyad] [varchar](50) NULL,
	[PerMail] [varchar](50) NULL,
	[PerTel] [varchar](50) NULL,
	[PerAdres] [varchar](50) NULL,
	[KatagoriId] [varchar](50) NULL,
 CONSTRAINT [PK_GPersonel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GSiparis]    Script Date: 5.06.2022 20:46:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GSiparis](
	[SiparisId] [int] NOT NULL,
	[MusteriId] [int] NULL,
	[PersonelId] [int] NULL,
 CONSTRAINT [PK_GSiparis] PRIMARY KEY CLUSTERED 
(
	[SiparisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GKatagori] ON 

INSERT [dbo].[GKatagori] ([KatagoriId], [KatagoriAdi]) VALUES (1, N'makyajjhhh')
INSERT [dbo].[GKatagori] ([KatagoriId], [KatagoriAdi]) VALUES (3, N'kalem')
INSERT [dbo].[GKatagori] ([KatagoriId], [KatagoriAdi]) VALUES (4, N'rujjj')
SET IDENTITY_INSERT [dbo].[GKatagori] OFF
GO
SET IDENTITY_INSERT [dbo].[GMusteri] ON 

INSERT [dbo].[GMusteri] ([MusteriId], [AdSoyad], [Mail], [Telefon], [Adres]) VALUES (1, N'behinurr', N'mail adresiddd', N'546564', N'cvcfgbfhg')
INSERT [dbo].[GMusteri] ([MusteriId], [AdSoyad], [Mail], [Telefon], [Adres]) VALUES (2, N'hammmm', N'fgf', N'gdfg', N'dgfdfgdf')
INSERT [dbo].[GMusteri] ([MusteriId], [AdSoyad], [Mail], [Telefon], [Adres]) VALUES (6, N'hamdi', N'assk', N'fsdd3423424', N'gffdgd')
INSERT [dbo].[GMusteri] ([MusteriId], [AdSoyad], [Mail], [Telefon], [Adres]) VALUES (7, N'yeniiii', N'gbfcg', N'fgfg', N'nhghjngjng')
SET IDENTITY_INSERT [dbo].[GMusteri] OFF
GO
SET IDENTITY_INSERT [dbo].[GPersonel] ON 

INSERT [dbo].[GPersonel] ([PersonelId], [PerAdSoyad], [PerMail], [PerTel], [PerAdres], [KatagoriId]) VALUES (1, N'bennnn', N'dfgdgf', N't56t', N'gfhgfhg', NULL)
INSERT [dbo].[GPersonel] ([PersonelId], [PerAdSoyad], [PerMail], [PerTel], [PerAdres], [KatagoriId]) VALUES (2, N'sen', N'fgdfg', N'dddd', N'fgvf', NULL)
INSERT [dbo].[GPersonel] ([PersonelId], [PerAdSoyad], [PerMail], [PerTel], [PerAdres], [KatagoriId]) VALUES (4, N'yennn', N'prtr', N'vxv', N'sdfdsf', NULL)
SET IDENTITY_INSERT [dbo].[GPersonel] OFF
GO
INSERT [dbo].[GSiparis] ([SiparisId], [MusteriId], [PersonelId]) VALUES (1, 1, 2)
INSERT [dbo].[GSiparis] ([SiparisId], [MusteriId], [PersonelId]) VALUES (6, 2, 3)
GO
USE [master]
GO
ALTER DATABASE [GuvenlikDb] SET  READ_WRITE 
GO
