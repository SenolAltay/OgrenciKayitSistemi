USE [master]
GO
/****** Object:  Database [DB_OgrenciKayitSistemi]    Script Date: 24.02.2023 23:19:36 ******/
CREATE DATABASE [DB_OgrenciKayitSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_OgrenciKayitSistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_OgrenciKayitSistemi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_OgrenciKayitSistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_OgrenciKayitSistemi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_OgrenciKayitSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET QUERY_STORE = OFF
GO
USE [DB_OgrenciKayitSistemi]
GO
/****** Object:  Table [dbo].[Tbl_Dersler]    Script Date: 24.02.2023 23:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Dersler](
	[dersID] [tinyint] IDENTITY(1,1) NOT NULL,
	[dersAd] [nchar](30) NULL,
 CONSTRAINT [PK_Tbl_Dersler] PRIMARY KEY CLUSTERED 
(
	[dersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kulupler]    Script Date: 24.02.2023 23:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kulupler](
	[kulupID] [tinyint] IDENTITY(1,1) NOT NULL,
	[kulupAd] [varchar](30) NULL,
 CONSTRAINT [PK_Tbl_Kulupler] PRIMARY KEY CLUSTERED 
(
	[kulupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Notlar]    Script Date: 24.02.2023 23:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Notlar](
	[notID] [int] IDENTITY(1,1) NOT NULL,
	[dersID] [tinyint] NULL,
	[ogrID] [int] NULL,
	[sınav1] [tinyint] NULL,
	[sınav2] [tinyint] NULL,
	[sınav3] [tinyint] NULL,
	[proje] [tinyint] NULL,
	[ortalama] [decimal](5, 2) NULL,
	[durum] [bit] NULL,
 CONSTRAINT [PK_Tbl_Notlar] PRIMARY KEY CLUSTERED 
(
	[notID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ogrenciler]    Script Date: 24.02.2023 23:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ogrenciler](
	[ogrID] [int] IDENTITY(1,1) NOT NULL,
	[ogrAd] [varchar](30) NULL,
	[ogrSoyad] [varchar](30) NULL,
	[ogrKulup] [tinyint] NULL,
	[ogrCinsiyet] [varchar](5) NULL,
 CONSTRAINT [PK_Tbl_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ogretmenler]    Script Date: 24.02.2023 23:19:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ogretmenler](
	[ogrtID] [tinyint] IDENTITY(1,1) NOT NULL,
	[ogrtBrans] [tinyint] NULL,
	[ogrtAdSoyad] [nchar](50) NULL,
 CONSTRAINT [PK_Tbl_Ogretmenler] PRIMARY KEY CLUSTERED 
(
	[ogrtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Notlar_Tbl_Dersler] FOREIGN KEY([dersID])
REFERENCES [dbo].[Tbl_Dersler] ([dersID])
GO
ALTER TABLE [dbo].[Tbl_Notlar] CHECK CONSTRAINT [FK_Tbl_Notlar_Tbl_Dersler]
GO
ALTER TABLE [dbo].[Tbl_Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Notlar_Tbl_Ogrenciler] FOREIGN KEY([ogrID])
REFERENCES [dbo].[Tbl_Ogrenciler] ([ogrID])
GO
ALTER TABLE [dbo].[Tbl_Notlar] CHECK CONSTRAINT [FK_Tbl_Notlar_Tbl_Ogrenciler]
GO
ALTER TABLE [dbo].[Tbl_Ogrenciler]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Ogrenciler_Tbl_Kulupler] FOREIGN KEY([ogrKulup])
REFERENCES [dbo].[Tbl_Kulupler] ([kulupID])
GO
ALTER TABLE [dbo].[Tbl_Ogrenciler] CHECK CONSTRAINT [FK_Tbl_Ogrenciler_Tbl_Kulupler]
GO
ALTER TABLE [dbo].[Tbl_Ogretmenler]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Ogretmenler_Tbl_Dersler] FOREIGN KEY([ogrtBrans])
REFERENCES [dbo].[Tbl_Dersler] ([dersID])
GO
ALTER TABLE [dbo].[Tbl_Ogretmenler] CHECK CONSTRAINT [FK_Tbl_Ogretmenler_Tbl_Dersler]
GO
USE [master]
GO
ALTER DATABASE [DB_OgrenciKayitSistemi] SET  READ_WRITE 
GO
