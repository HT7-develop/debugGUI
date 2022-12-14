USE [master]
GO
/****** Object:  Database [rayco]    Script Date: 15/12/2022 18:36:12 ******/
CREATE DATABASE [rayco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [rayco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [rayco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [rayco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [rayco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [rayco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [rayco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [rayco] SET ARITHABORT OFF 
GO
ALTER DATABASE [rayco] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [rayco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [rayco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [rayco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [rayco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [rayco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [rayco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [rayco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [rayco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [rayco] SET  DISABLE_BROKER 
GO
ALTER DATABASE [rayco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [rayco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [rayco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [rayco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [rayco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [rayco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [rayco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [rayco] SET RECOVERY FULL 
GO
ALTER DATABASE [rayco] SET  MULTI_USER 
GO
ALTER DATABASE [rayco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [rayco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [rayco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [rayco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [rayco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [rayco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'rayco', N'ON'
GO
ALTER DATABASE [rayco] SET QUERY_STORE = OFF
GO
USE [rayco]
GO
/****** Object:  Table [dbo].[deeltaak]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deeltaak](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[beschrijving] [varchar](max) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[looptijd] [int] NOT NULL,
	[opvolger_id] [int] NULL,
	[projectsoort] [int] NULL,
	[gebruikte_uren] [int] NOT NULL,
	[werknemer_id] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naam] [varchar](50) NOT NULL,
	[beschrijving] [varchar](max) NULL,
	[status] [varchar](50) NOT NULL,
	[projectsoort] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectSoort]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectSoort](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](max) NOT NULL,
	[deeltaken] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tasks]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tasks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NOT NULL,
	[beschrijving] [varchar](max) NOT NULL,
	[status] [varchar](50) NOT NULL,
	[looptijd] [int] NOT NULL,
	[opvolger_id] [int] NULL,
	[project_id] [int] NULL,
	[gebruikte_uren] [int] NOT NULL,
	[werknemer_id] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teams]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 15/12/2022 18:36:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[admin] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[deeltaak] ADD  DEFAULT ('geen titel') FOR [title]
GO
ALTER TABLE [dbo].[deeltaak] ADD  DEFAULT ('niks') FOR [beschrijving]
GO
ALTER TABLE [dbo].[deeltaak] ADD  DEFAULT ('open') FOR [status]
GO
ALTER TABLE [dbo].[deeltaak] ADD  DEFAULT ((0)) FOR [looptijd]
GO
ALTER TABLE [dbo].[deeltaak] ADD  DEFAULT ((0)) FOR [gebruikte_uren]
GO
ALTER TABLE [dbo].[projects] ADD  DEFAULT ('naam') FOR [naam]
GO
ALTER TABLE [dbo].[projects] ADD  DEFAULT ('pending') FOR [status]
GO
ALTER TABLE [dbo].[tasks] ADD  DEFAULT ('geen titel') FOR [title]
GO
ALTER TABLE [dbo].[tasks] ADD  DEFAULT ('niks') FOR [beschrijving]
GO
ALTER TABLE [dbo].[tasks] ADD  DEFAULT ('open') FOR [status]
GO
ALTER TABLE [dbo].[tasks] ADD  DEFAULT ((0)) FOR [looptijd]
GO
ALTER TABLE [dbo].[tasks] ADD  DEFAULT ((0)) FOR [gebruikte_uren]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((12345)) FOR [password]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [admin]
GO
USE [master]
GO
ALTER DATABASE [rayco] SET  READ_WRITE 
GO
