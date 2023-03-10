USE [master]
GO
/****** Object:  Database [SpaceGameWorld]    Script Date: 14.09.2022 11:42:55 ******/
CREATE DATABASE [SpaceGameWorld]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SpaceGameWorld', FILENAME = N'/var/opt/mssql/data/SpaceGameWorld.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SpaceGameWorld_log', FILENAME = N'/var/opt/mssql/data/SpaceGameWorld_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SpaceGameWorld] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SpaceGameWorld].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SpaceGameWorld] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET ARITHABORT OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SpaceGameWorld] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SpaceGameWorld] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SpaceGameWorld] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SpaceGameWorld] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SpaceGameWorld] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SpaceGameWorld] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET RECOVERY FULL 
GO
ALTER DATABASE [SpaceGameWorld] SET  MULTI_USER 
GO
ALTER DATABASE [SpaceGameWorld] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SpaceGameWorld] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SpaceGameWorld] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SpaceGameWorld] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SpaceGameWorld] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SpaceGameWorld] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SpaceGameWorld] SET QUERY_STORE = OFF
GO
USE [SpaceGameWorld]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14.09.2022 11:42:55 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Login] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](300) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[ApiKey] [nvarchar](50) NOT NULL,
	[MaxRL] [int] NOT NULL,
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActionUser]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionUser](
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ActionUser] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeveloperInTeam]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeveloperInTeam](
	[LoginUser] [nvarchar](50) NOT NULL,
	[TeamName] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[TokenTeam] [nvarchar](max) NOT NULL,
	[TimeSpanTokenEnd] [int] NOT NULL,
 CONSTRAINT [PK_DeveloperInTeam] PRIMARY KEY CLUSTERED 
(
	[LoginUser] ASC,
	[TeamName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisasterWorld]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisasterWorld](
	[Name] [nvarchar](50) NOT NULL,
	[Body] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Disaster] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drone]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drone](
	[ShortName] [nchar](3) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MoveAction] [int] NOT NULL,
	[DroneRoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Drone_1] PRIMARY KEY CLUSTERED 
(
	[ShortName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DroneRole]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DroneRole](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](300) NULL,
 CONSTRAINT [PK_DroneRole] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DroneSkillsSet]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DroneSkillsSet](
	[ShortNameDrone] [nchar](3) NOT NULL,
	[EfficiencyActionName] [nvarchar](50) NOT NULL,
	[Timestamp] [int] NULL,
 CONSTRAINT [PK_DroneSkillsSet] PRIMARY KEY CLUSTERED 
(
	[ShortNameDrone] ASC,
	[EfficiencyActionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EfficiencyAction]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EfficiencyAction](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ValueAction] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_DroneFeature_1] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventNew]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventNew](
	[CodeNumber] [nvarchar](50) NOT NULL,
	[Body] [nvarchar](50) NOT NULL,
	[DisasterWorldName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[CodeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameObject]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameObject](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TypeObject] [nvarchar](50) NOT NULL,
	[IPv6] [nvarchar](50) NOT NULL,
	[StateObject] [nvarchar](50) NOT NULL,
	[HeatPoint] [int] NULL,
 CONSTRAINT [PK_GameObject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformationDrone]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformationDrone](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[X] [bigint] NOT NULL,
	[Y] [bigint] NOT NULL,
	[IPv6] [nvarchar](50) NOT NULL,
	[DroneShortName] [nchar](3) NOT NULL,
	[HeatPoint] [decimal](10, 2) NULL,
	[LoginUser] [nvarchar](50) NOT NULL,
	[DroneNameUser] [nvarchar](50) NULL,
 CONSTRAINT [PK_InformationDrone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NetScan]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NetScan](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[X] [bigint] NOT NULL,
	[Y] [bigint] NOT NULL,
	[GameObjectId] [bigint] NOT NULL,
	[EventNewCodeNumber] [nvarchar](50) NOT NULL,
	[PlanetName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NetScan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjectAvailable]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectAvailable](
	[ServerId] [bigint] NOT NULL,
	[LoginUser] [nvarchar](50) NOT NULL,
	[ServerLevel] [int] NOT NULL,
 CONSTRAINT [PK_ObjectAvailable] PRIMARY KEY CLUSTERED 
(
	[ServerId] ASC,
	[LoginUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Planet]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planet](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](3000) NOT NULL,
	[Square] [nvarchar](300) NOT NULL,
	[Latitude] [int] NOT NULL,
	[Longitude] [int] NOT NULL,
 CONSTRAINT [PK_Planet] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RateLimit]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RateLimit](
	[Login] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[ActionUserName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Symbol] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleInTeam]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleInTeam](
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RoleInTeam] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateGameObject]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateGameObject](
	[Name] [nvarchar](50) NOT NULL,
	[SymbolState] [char](1) NULL,
 CONSTRAINT [PK_StateServer] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statistic]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statistic](
	[LoginUser] [nvarchar](50) NOT NULL,
	[SAC] [int] NOT NULL,
	[SLM] [int] NOT NULL,
	[CEM] [int] NOT NULL,
	[CEC] [int] NOT NULL,
	[IDLE] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
	[DateCreate] [date] NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeGameObject]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeGameObject](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](3000) NOT NULL,
	[UnicEfficensyId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TypeGameObject] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnicEfficiency]    Script Date: 14.09.2022 11:42:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnicEfficiency](
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[ValueAction] [float] NULL,
 CONSTRAINT [PK_UnicEfficensy] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220819092602_MyMigration', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220819112409_FixCodeNumber', N'6.0.7')
GO
INSERT [dbo].[Account] ([Login], [Name], [Password], [Email], [RoleName], [ApiKey], [MaxRL]) VALUES (N'Enemy', N'Enemy', N'202cb962ac59075b964b07152d234b70', N'burnfeniks2@yandex.ru', N'Игрок', N'1', 10)
INSERT [dbo].[Account] ([Login], [Name], [Password], [Email], [RoleName], [ApiKey], [MaxRL]) VALUES (N'ferasJ', N'Jimmy', N'827ccb0eea8a706c4c34a16891f84e7b', N'Jimmy@jimmy.com', N'Игрок', N'NKJBkJrHNv', 10)
INSERT [dbo].[Account] ([Login], [Name], [Password], [Email], [RoleName], [ApiKey], [MaxRL]) VALUES (N'StasNorman', N'Станислав', N'202cb962ac59075b964b07152d234b70', N'burnfeniks@yandex.ru', N'Игрок', N'9mNo3dTV8O', 10)
INSERT [dbo].[Account] ([Login], [Name], [Password], [Email], [RoleName], [ApiKey], [MaxRL]) VALUES (N'Vido', N'Vidosav', N'388469e6db4cd9643cf2eab8725a521e', N'vido110905@yandex.ru', N'Игрок', N'kBBCzqIGOj', 10)
GO
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Атакует дрон')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Атакует сервер')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Отвечает на вопрос')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Открывает местность')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Перемещение дрона')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Прокачивает сервер')
INSERT [dbo].[ActionUser] ([Name]) VALUES (N'Чинит дрон')
GO
INSERT [dbo].[DisasterWorld] ([Name], [Body]) VALUES (N'Кротовая норма', N'по всему миру телепорты')
INSERT [dbo].[DisasterWorld] ([Name], [Body]) VALUES (N'Праздник', N'увеличенные коины за игровые действия')
INSERT [dbo].[DisasterWorld] ([Name], [Body]) VALUES (N'Спокойствие', N'всем блесс')
INSERT [dbo].[DisasterWorld] ([Name], [Body]) VALUES (N'Тефтельный дождь', N'приятного аппетита')
INSERT [dbo].[DisasterWorld] ([Name], [Body]) VALUES (N'Черная дыра', N'когда 9 квинтилионов атомов собираются в одном месте появляется голодная чёрная дырка')
GO
INSERT [dbo].[Drone] ([ShortName], [Name], [MoveAction], [DroneRoleName]) VALUES (N'DVR', N'Дискавери', 5, N'Исследователь')
INSERT [dbo].[Drone] ([ShortName], [Name], [MoveAction], [DroneRoleName]) VALUES (N'EVA', N'Ева', 2, N'Ремонт')
INSERT [dbo].[Drone] ([ShortName], [Name], [MoveAction], [DroneRoleName]) VALUES (N'VDR', N'Владимир', 2, N'Атакующий')
GO
INSERT [dbo].[DroneRole] ([Name], [Description]) VALUES (N'Атакующий', N'Тупо бьёт')
INSERT [dbo].[DroneRole] ([Name], [Description]) VALUES (N'Исследователь', N'Тупо исследует')
INSERT [dbo].[DroneRole] ([Name], [Description]) VALUES (N'Ремонт', N'Тупо чинит')
GO
INSERT [dbo].[DroneSkillsSet] ([ShortNameDrone], [EfficiencyActionName], [Timestamp]) VALUES (N'DVR', N'Открыть область', NULL)
INSERT [dbo].[DroneSkillsSet] ([ShortNameDrone], [EfficiencyActionName], [Timestamp]) VALUES (N'EVA', N'Отремонтировать объект', NULL)
INSERT [dbo].[DroneSkillsSet] ([ShortNameDrone], [EfficiencyActionName], [Timestamp]) VALUES (N'VDR', N'Единичный выстрел', NULL)
GO
INSERT [dbo].[EfficiencyAction] ([Name], [Description], [ValueAction]) VALUES (N'Единичный выстрел', N'Обычная атака', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[EfficiencyAction] ([Name], [Description], [ValueAction]) VALUES (N'Открыть область', N'Автоматический навык', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[EfficiencyAction] ([Name], [Description], [ValueAction]) VALUES (N'Отремонтировать объект', N'Ремонт', CAST(5.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[EventNew] ([CodeNumber], [Body], [DisasterWorldName]) VALUES (N'500A', N'Небо в огне, не забудьте соус', N'Тефтельный дождь')
INSERT [dbo].[EventNew] ([CodeNumber], [Body], [DisasterWorldName]) VALUES (N'999B', N'Двойные монеты', N'Праздник')
INSERT [dbo].[EventNew] ([CodeNumber], [Body], [DisasterWorldName]) VALUES (N'E200', N'Успешная генерация базовой точки пользователя', N'Спокойствие')
INSERT [dbo].[EventNew] ([CodeNumber], [Body], [DisasterWorldName]) VALUES (N'W200', N'растения', N'Спокойствие')
INSERT [dbo].[EventNew] ([CodeNumber], [Body], [DisasterWorldName]) VALUES (N'Нейтрально', N'растения цветут', N'Спокойствие')
GO
SET IDENTITY_INSERT [dbo].[GameObject] ON 

INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (33, N'IWXM', N'Сервер', N'5350:4452:741d:fa61:73df:70ef:1697:e25b', N'Нейтрален', 416)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (34, N'APYC', N'Сервер', N'a47a:8ad0:fde3:fab7:92c7:ef04:844:4c97', N'Нейтрален', 570)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (35, N'G379', N'Сервер', N'a3d3:629b:2e5f:b722:6861:7322:e316:875f', N'Нейтрален', 645)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (36, N'FQWM', N'Сервер', N'6707:4a98:6aff:4997:3db9:49f0:5e7c:679e', N'Нейтрален', 923)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (37, N'3YWI', N'Сервер', N'6d43:aebe:ea13:57c2:f3d4:86a4:8125:ef06', N'Нейтрален', 816)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (38, N'RTET', N'Сервер', N'e853:a5b1:9b36:9a90:c9c7:fe4b:14cc:db51', N'Нейтрален', 533)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (39, N'VRXU', N'Сервер', N'8d32:1bf2:32cd:47e:fc89:496a:5aa:81fe', N'Нейтрален', 639)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (40, N'QZ35', N'Сервер', N'8841:4891:e5a9:ca85:1af2:b2cd:3a1b:e018', N'Нейтрален', 857)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (41, N'ENW7', N'Сервер', N'ca9e:3444:470d:6616:9b1b:1762:ff8b:7533', N'Нейтрален', 604)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (42, N'WPWG', N'Сервер', N'e740:fa5a:48aa:c95b:990e:cf62:749e:f69d', N'Нейтрален', 403)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (43, N'1ZK1', N'Сервер', N'd697:e44b:da2c:7d5e:1237:f346:d3d1:ffb2', N'Нейтрален', 629)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (44, N'2JSL', N'Сервер', N'560c:1ba:9089:47f1:61b0:4baa:676f:489c', N'Нейтрален', 782)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (45, N'ZNAX', N'Сервер', N'80b1:7338:b30b:32c0:9f17:682d:ed6e:cdc2', N'Нейтрален', 721)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (46, N'5PE8', N'Сервер', N'60cb:9b65:a20:3964:aec1:97f1:cd0a:6adf', N'Нейтрален', 936)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (47, N'SYDD', N'Сервер', N'fea1:18d2:aa78:bd2e:49e2:c68e:5761:c45b', N'Нейтрален', 989)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (48, N'WN0Q', N'Сервер', N'81f3:4bf7:3525:711e:ca7b:4346:3edf:765d', N'Нейтрален', 442)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (49, N'6FA1', N'Сервер', N'57c5:ca37:b8bf:5ed:6596:86dd:fe94:51ed', N'Нейтрален', 646)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (50, N'VFVS', N'Сервер', N'3654:7fd0:8bfa:e140:1fb8:8f3d:3de0:8d50', N'Нейтрален', 633)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (51, N'CIU7', N'Сервер', N'97e7:62d0:d4e6:7756:fd6b:84f7:bcef:ab4a', N'Нейтрален', 706)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (52, N'KGHA', N'Сервер', N'7944:6c7a:14d7:8402:1d3a:cb4f:c5cb:a624', N'Нейтрален', 999)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (53, N'XR0L', N'Сервер', N'41d1:a14a:781e:d662:89ad:d38e:6744:985b', N'Нейтрален', 600)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (54, N'LNX2', N'Сервер', N'f978:7822:c059:65c5:4806:82d:d4fa:8fc4', N'Нейтрален', 475)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (55, N'KAFV', N'Сервер', N'80fa:2d6:f982:da25:6cfe:e6cd:4796:26f7', N'Нейтрален', 539)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (56, N'TECH', N'Сервер', N'35d:9220:228b:8b5d:ca94:d875:7df9:1652', N'Нейтрален', 668)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (57, N'TUIZ', N'Сервер', N'a367:5ffc:ffd5:fe2a:65da:acb2:66e9:8545', N'Нейтрален', 554)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (58, N'COZS', N'Сервер', N'176e:afa2:4b61:952d:eda9:ffa5:b9b7:a3', N'Нейтрален', 738)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (59, N'WF2Q', N'Сервер', N'de61:2dfb:1b8c:639d:10d5:3:33ae:6639', N'Нейтрален', 400)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (60, N'RNJX', N'Сервер', N'c047:e6f:a15f:ebc7:1fd4:eeb9:aeda:dff9', N'Нейтрален', 709)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (61, N'ORSY', N'Сервер', N'471a:5f5b:6295:23e1:9e40:c637:5557:ad74', N'Нейтрален', 870)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (62, N'ROFR', N'Сервер', N'f348:a46f:39c1:ea94:7b3c:6a13:c1a7:3f5d', N'Нейтрален', 885)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (63, N'MPWN', N'Сервер', N'91d8:c13b:1d8a:861:63b9:68e0:c737:82e4', N'Нейтрален', 882)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (64, N'PLH0', N'Сервер', N'64b4:6bbc:f017:e3ed:f278:c251:a303:6b36', N'Нейтрален', 509)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (65, N'KO6V', N'Сервер', N'9bd5:ea46:3576:9126:bc81:ced9:dc54:ca92', N'Нейтрален', 472)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (66, N'TSZK', N'Сервер', N'5070:a4db:1651:2f3d:b800:3a06:f1ce:db6d', N'Нейтрален', 761)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (67, N'GQJN', N'Сервер', N'1bc7:d2f2:dbad:9503:9ed1:b4df:fcdb:18dd', N'Нейтрален', 473)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (68, N'53O3', N'Сервер', N'b81e:fc93:18b0:ca95:4e87:f9a8:61b9:1c9d', N'Нейтрален', 771)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (69, N'S7BF', N'Сервер', N'beb8:e4b1:66d7:beb9:3caf:a535:e73e:c67e', N'Нейтрален', 451)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (70, N'DVSF', N'Сервер', N'95b7:466f:ffe1:8a38:8892:3c2c:cc80:7cd1', N'Нейтрален', 580)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (71, N'IJL2', N'Сервер', N'dcfd:6876:9529:53fd:d267:20b:e4fe:7063', N'Нейтрален', 416)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (72, N'YNVY', N'Сервер', N'c33a:9690:31d6:214b:cf57:e486:22cf:80a1', N'Нейтрален', 820)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (73, N'XGRK', N'Сервер', N'276:db77:f93:454:fbf3:9a8d:8ef5:41f', N'Нейтрален', 757)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (74, N'5VS6', N'Сервер', N'5a49:2dd9:67a4:5d4e:24aa:7456:a571:f179', N'Нейтрален', 406)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (75, N'MKZ4', N'Сервер', N'4759:9da6:d3b:7086:becf:4a09:1468:a389', N'Нейтрален', 601)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (76, N'JU9G', N'Сервер', N'621:9028:2098:b9d0:f017:c29d:42b4:3bd2', N'Нейтрален', 884)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (77, N'0PNV', N'Сервер', N'844b:c0e7:ee23:1c41:d618:eae7:4f4f:ec5e', N'Нейтрален', 769)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (78, N'KXA1', N'Сервер', N'd6b2:af92:369e:78a0:eee1:5003:2a6a:5e15', N'Нейтрален', 675)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (79, N'URCZ', N'Сервер', N'ff0d:6f75:575:7029:ecca:d591:bba9:cf8e', N'Нейтрален', 491)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (80, N'4N9P', N'Сервер', N'5707:1f7a:9985:7566:c66d:ad64:c2d2:f709', N'Нейтрален', 684)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (81, N'O0LL', N'Сервер', N'c333:8f79:1e9e:985b:9cf3:450c:87e5:5b23', N'Нейтрален', 772)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (82, N'CCFY', N'Сервер', N'bc3a:7052:13c9:d550:4344:9ef1:c440:1a97', N'Нейтрален', 956)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (83, N'IWWK', N'Сервер', N'bd8d:b2fa:2e1f:af4a:b09b:3e12:504f:a86', N'Нейтрален', 987)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (84, N'HGX3', N'Сервер', N'69df:bae2:29be:6c26:2534:9a6f:7151:4175', N'Нейтрален', 708)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (85, N'ICYR', N'Сервер', N'b8cc:23e:9745:388:a0ee:e7b5:90bc:cc43', N'Нейтрален', 630)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (86, N'4UXP', N'Сервер', N'8c36:e430:8a62:419c:fabb:34da:f638:88ce', N'Нейтрален', 931)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (87, N'IMKT', N'Сервер', N'20dd:5d02:5f67:cbac:755d:46ad:895f:9afc', N'Нейтрален', 821)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (88, N'OQVJ', N'Сервер', N'24e7:b8c5:4a7:3942:15d3:2bcc:c864:d88', N'Нейтрален', 448)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (89, N'X2S3', N'Сервер', N'e274:51a9:f689:976f:9d0a:cad6:a30:2271', N'Нейтрален', 560)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (90, N'XLUV', N'Сервер', N'a9a6:5427:80ae:9612:7a3c:da6e:1b16:eb5b', N'Нейтрален', 490)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (91, N'O7V1', N'Сервер', N'3680:d4e2:ab7c:2302:8b93:1fd0:f3c1:467d', N'Нейтрален', 999)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (92, N'PZRT', N'Сервер', N'd54c:2566:a390:1015:f5d3:aec2:c19e:86ed', N'Нейтрален', 542)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (93, N'NTUX', N'Сервер', N'93e1:4691:bf8c:979e:8e6e:7456:5584:e1a9', N'Нейтрален', 774)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (94, N'XJC3', N'Сервер', N'aaab:9c0a:350f:95aa:9380:93b3:ad2f:72e9', N'Нейтрален', 484)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (95, N'VCSH', N'Сервер', N'4aab:d2dc:3ed7:ea44:2044:f28a:5898:2bb3', N'Нейтрален', 953)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (96, N'Q157', N'Сервер', N'781b:1276:96f7:19ca:218c:fdd2:b214:e259', N'Нейтрален', 571)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (97, N'H8ZR', N'Сервер', N'bcb0:f464:c328:138c:80db:5e1a:cfdd:f285', N'Нейтрален', 857)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (98, N'LPEL', N'Сервер', N'3350:bc59:ac8c:9adc:44a8:b0be:ab5e:9d38', N'Нейтрален', 485)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (99, N'D5S4', N'Сервер', N'd193:a471:31e7:67c:34d5:b28d:39f8:3e4a', N'Нейтрален', 977)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (100, N'I1UF', N'Сервер', N'9bc6:3d2b:6a44:3b1a:bbad:a817:c83a:73ca', N'Нейтрален', 812)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (101, N'GUJA', N'Сервер', N'4e19:2ee4:4eeb:7245:cad1:9a4e:ea2:7450', N'Нейтрален', 534)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (102, N'F0O3', N'Сервер', N'b5f3:fe5e:46e1:2802:31ce:6f78:c364:c290', N'Нейтрален', 761)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (103, N'C9YV', N'Сервер', N'6146:80ff:6e94:aef2:108b:f689:d1f1:77a4', N'Нейтрален', 562)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (104, N'O8WS', N'Сервер', N'9f61:97db:91b5:1564:d9a2:33ea:7dbb:405b', N'Нейтрален', 609)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (105, N'D5RQ', N'Сервер', N'4149:5c41:b51:609f:2609:c1b5:1f9c:d996', N'Нейтрален', 588)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (106, N'37RH', N'Сервер', N'31ec:bdc6:6057:807f:b53e:d155:dbdb:589c', N'Нейтрален', 742)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (107, N'UQEK', N'Сервер', N'5cb8:8071:d5de:55c8:8073:12c:1f1b:a01c', N'Нейтрален', 877)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (108, N'7UOU', N'Сервер', N'bcdf:ea91:1452:cbeb:dde1:5e7c:34ea:186b', N'Нейтрален', 823)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (109, N'JLJH', N'Сервер', N'55dd:c44a:d3f:1013:fec1:b02d:fe08:d866', N'Нейтрален', 699)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (110, N'VPKJ', N'Сервер', N'4bcb:1b27:5114:460:bea4:2bb:c5c8:2597', N'Нейтрален', 566)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (111, N'LIKH', N'Сервер', N'58:919a:d965:ddfa:7097:56c9:7798:a6aa', N'Нейтрален', 720)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (112, N'QE0O', N'Сервер', N'7e86:2d83:9503:dfec:a7ac:5f07:407:d683', N'Нейтрален', 928)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (116, N'StasNorman-Home', N'Базовая станция', N'5152:6010:1514:4507:efcc:80c5:991b:87a7', N'Нейтрален', -1)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (117, N'StasNorman-Home', N'Базовая станция', N'b52c:a308:f080:c678:c24d:2395:3302:9e54', N'Нейтрален', 1000)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (118, N'Enemy-Home', N'Базовая станция', N'1630:3fb7:d099:6933:3170:1548:318d:4ee4', N'Нейтрален', 1000)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (119, N'Test-Home', N'Базовая станция', N'b17e:aee4:154b:5fae:4e5b:f57b:edd0:1076', N'Нейтрален', 1000)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (120, N'Vido-Home', N'Базовая станция', N'801c:20c:451b:908f:156b:b342:a96:147', N'Нейтрален', 1000)
INSERT [dbo].[GameObject] ([Id], [Name], [TypeObject], [IPv6], [StateObject], [HeatPoint]) VALUES (121, N'ferasJ-Home', N'Базовая станция', N'46ef:1e20:1370:9139:9bba:7a35:14b3:52f3', N'Нейтрален', 1000)
SET IDENTITY_INSERT [dbo].[GameObject] OFF
GO
SET IDENTITY_INSERT [dbo].[InformationDrone] ON 

INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (1, -107, -29, N'631c:bdf5:5822:7a03:fa7:9363:c183:3c0c', N'DVR', CAST(300.00 AS Decimal(10, 2)), N'StasNorman', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (2, -54, -325, N'719d:afde:c793:ecd9:abe1:ea5a:889e:c79e', N'EVA', CAST(300.00 AS Decimal(10, 2)), N'StasNorman', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (3, -54, -325, N'cfc4:9739:3df3:452e:ffe0:5980:7dfc:7494', N'VDR', CAST(300.00 AS Decimal(10, 2)), N'StasNorman', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (4, -105, -29, N'b59d:ff85:e6d3:88a6:e87d:1730:3e3d:1882', N'DVR', CAST(300.00 AS Decimal(10, 2)), N'Enemy', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (5, 476, -637, N'9893:33f:75bd:1ba0:c024:b326:49ce:9643', N'EVA', CAST(300.00 AS Decimal(10, 2)), N'Enemy', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (6, 476, -637, N'affe:4b80:f6d3:b7d8:1646:8cc:ce5b:8926', N'VDR', CAST(300.00 AS Decimal(10, 2)), N'Enemy', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (10, -53, -201, N'23cb:6072:f7e7:e857:c728:8cf6:90bb:265e', N'DVR', CAST(300.00 AS Decimal(10, 2)), N'Vido', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (11, -53, -201, N'4bcd:3f4a:28df:99c7:656:6788:dd5c:2a4b', N'EVA', CAST(300.00 AS Decimal(10, 2)), N'Vido', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (12, -53, -201, N'264f:621b:5227:e6b5:3bab:e1d3:9262:a335', N'VDR', CAST(300.00 AS Decimal(10, 2)), N'Vido', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (13, 250, 778, N'ed1:8acc:27c9:73bf:b692:ba99:2505:20c8', N'DVR', CAST(300.00 AS Decimal(10, 2)), N'ferasJ', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (14, 250, 778, N'4948:b913:859b:dc0f:c5b9:b20f:68d:a950', N'EVA', CAST(300.00 AS Decimal(10, 2)), N'ferasJ', N'Edit')
INSERT [dbo].[InformationDrone] ([Id], [X], [Y], [IPv6], [DroneShortName], [HeatPoint], [LoginUser], [DroneNameUser]) VALUES (15, 250, 778, N'b624:4aba:c813:7368:2b6b:6ef9:5d67:902d', N'VDR', CAST(300.00 AS Decimal(10, 2)), N'ferasJ', N'Edit')
SET IDENTITY_INSERT [dbo].[InformationDrone] OFF
GO
SET IDENTITY_INSERT [dbo].[NetScan] ON 

INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (61, -107, -29, 63, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (62, -107, -30, 64, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (63, 438, 13, 65, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (64, -328, 198, 66, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (65, 450, 124, 67, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (66, -48, -292, 68, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (67, 252, -219, 69, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (68, 178, -508, 70, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (69, 320, 99, 71, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (70, -380, -308, 72, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (71, 380, -283, 73, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (72, -5, -33, 74, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (73, 83, -436, 75, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (74, -321, -443, 76, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (75, 348, -674, 77, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (76, 421, -62, 78, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (77, 199, -445, 79, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (78, 260, 588, 80, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (79, 111, -47, 81, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (80, -327, -462, 82, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (81, -297, 681, 83, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (82, -247, -661, 84, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (83, -185, -373, 85, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (84, 196, -370, 86, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (85, -239, -511, 87, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (86, 78, -17, 88, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (87, -391, -335, 89, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (88, 94, -255, 90, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (89, -392, -395, 91, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (90, -229, -207, 92, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (91, 287, -485, 93, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (92, -167, 635, 94, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (93, 43, -368, 95, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (94, -480, 156, 96, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (95, -206, 66, 97, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (96, -194, 478, 98, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (97, 137, 162, 99, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (98, 188, 451, 100, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (99, 414, -291, 101, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (100, 8, -63, 102, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (101, -138, 143, 103, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (102, -281, -675, 104, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (103, 129, -592, 105, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (104, 456, -257, 106, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (105, 21, -8, 107, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (106, 286, -357, 108, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (107, -404, 72, 109, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (108, -63, -392, 110, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (109, 482, -536, 111, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (110, -422, 100, 112, N'W200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (114, 158, 681, 116, N'E200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (115, -54, -325, 117, N'E200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (116, 476, -637, 118, N'E200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (117, 241, -640, 119, N'E200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (118, -53, -201, 120, N'E200', N'Земля')
INSERT [dbo].[NetScan] ([Id], [X], [Y], [GameObjectId], [EventNewCodeNumber], [PlanetName]) VALUES (119, 250, 778, 121, N'E200', N'Земля')
SET IDENTITY_INSERT [dbo].[NetScan] OFF
GO
INSERT [dbo].[ObjectAvailable] ([ServerId], [LoginUser], [ServerLevel]) VALUES (117, N'StasNorman', 0)
INSERT [dbo].[ObjectAvailable] ([ServerId], [LoginUser], [ServerLevel]) VALUES (118, N'Enemy', 0)
INSERT [dbo].[ObjectAvailable] ([ServerId], [LoginUser], [ServerLevel]) VALUES (120, N'Vido', 0)
INSERT [dbo].[ObjectAvailable] ([ServerId], [LoginUser], [ServerLevel]) VALUES (121, N'ferasJ', 0)
GO
INSERT [dbo].[Planet] ([Name], [Description], [Square], [Latitude], [Longitude]) VALUES (N'Земля', N'Тут будет JSON', N'100000', 800, 500)
GO
INSERT [dbo].[Role] ([Name], [Description], [Symbol]) VALUES (N'Администратор', N'Админ', N'A')
INSERT [dbo].[Role] ([Name], [Description], [Symbol]) VALUES (N'Игрок', N'Обычный игрок', N'P')
INSERT [dbo].[Role] ([Name], [Description], [Symbol]) VALUES (N'Модератор', N'Модератор', N'M')
GO
INSERT [dbo].[StateGameObject] ([Name], [SymbolState]) VALUES (N'Атакован', N'A')
INSERT [dbo].[StateGameObject] ([Name], [SymbolState]) VALUES (N'Не открыт', N'U')
INSERT [dbo].[StateGameObject] ([Name], [SymbolState]) VALUES (N'Нейтрален', N'N')
INSERT [dbo].[StateGameObject] ([Name], [SymbolState]) VALUES (N'Открыт', N'E')
INSERT [dbo].[StateGameObject] ([Name], [SymbolState]) VALUES (N'Ремонтируется', N'R')
GO
INSERT [dbo].[TypeGameObject] ([Name], [Description], [UnicEfficensyId]) VALUES (N'Базовая станция', N'б', N'Изначальная база')
INSERT [dbo].[TypeGameObject] ([Name], [Description], [UnicEfficensyId]) VALUES (N'Сервер', N'а', N'Возобновление')
GO
INSERT [dbo].[UnicEfficiency] ([Name], [Description], [ValueAction]) VALUES (N'Александрийский маяк', N'Усиление мощностей антенн', 20)
INSERT [dbo].[UnicEfficiency] ([Name], [Description], [ValueAction]) VALUES (N'Возобновление', N'Возобновление сервера после полного уничтожения', 180)
INSERT [dbo].[UnicEfficiency] ([Name], [Description], [ValueAction]) VALUES (N'Горн Марса', N'Усиление атаки', 20)
INSERT [dbo].[UnicEfficiency] ([Name], [Description], [ValueAction]) VALUES (N'Изначальная база', N'Стартовое, не может быть уничтожено', 200)
INSERT [dbo].[UnicEfficiency] ([Name], [Description], [ValueAction]) VALUES (N'Молот Гефеста', N'Увеличение параметров ремонта', 20)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Account_RoleName]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_Account_RoleName] ON [dbo].[Account]
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DeveloperInTeam_Role]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_DeveloperInTeam_Role] ON [dbo].[DeveloperInTeam]
(
	[Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DeveloperInTeam_TeamName]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_DeveloperInTeam_TeamName] ON [dbo].[DeveloperInTeam]
(
	[TeamName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Drone_TypeDrone]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_Drone_TypeDrone] ON [dbo].[Drone]
(
	[MoveAction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EventNew_DisasterWorldName]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_EventNew_DisasterWorldName] ON [dbo].[EventNew]
(
	[DisasterWorldName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GameObject_StateObject]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_GameObject_StateObject] ON [dbo].[GameObject]
(
	[StateObject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GameObject_TypeObject]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_GameObject_TypeObject] ON [dbo].[GameObject]
(
	[TypeObject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_InformationDrone_DroneShortName]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_InformationDrone_DroneShortName] ON [dbo].[InformationDrone]
(
	[DroneShortName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_InformationDrone_LoginUser]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_InformationDrone_LoginUser] ON [dbo].[InformationDrone]
(
	[LoginUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_NetScan_EventNewCodeNumber]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_NetScan_EventNewCodeNumber] ON [dbo].[NetScan]
(
	[EventNewCodeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_NetScan_GameObjectId]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_NetScan_GameObjectId] ON [dbo].[NetScan]
(
	[GameObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_NetScan_PlanetName]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_NetScan_PlanetName] ON [dbo].[NetScan]
(
	[PlanetName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ObjectAvailable_LoginUser]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_ObjectAvailable_LoginUser] ON [dbo].[ObjectAvailable]
(
	[LoginUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ObjectAvailable_ServerId]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_ObjectAvailable_ServerId] ON [dbo].[ObjectAvailable]
(
	[ServerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Statistic_LoginUser]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_Statistic_LoginUser] ON [dbo].[Statistic]
(
	[LoginUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TypeGameObject_UnicEfficensyId]    Script Date: 14.09.2022 11:42:56 ******/
CREATE NONCLUSTERED INDEX [IX_TypeGameObject_UnicEfficensyId] ON [dbo].[TypeGameObject]
(
	[UnicEfficensyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleName])
REFERENCES [dbo].[Role] ([Name])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[DeveloperInTeam]  WITH CHECK ADD  CONSTRAINT [FK_DeveloperInTeam_Account] FOREIGN KEY([LoginUser])
REFERENCES [dbo].[Account] ([Login])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DeveloperInTeam] CHECK CONSTRAINT [FK_DeveloperInTeam_Account]
GO
ALTER TABLE [dbo].[DeveloperInTeam]  WITH CHECK ADD  CONSTRAINT [FK_DeveloperInTeam_RoleInTeam] FOREIGN KEY([Role])
REFERENCES [dbo].[RoleInTeam] ([Name])
GO
ALTER TABLE [dbo].[DeveloperInTeam] CHECK CONSTRAINT [FK_DeveloperInTeam_RoleInTeam]
GO
ALTER TABLE [dbo].[DeveloperInTeam]  WITH CHECK ADD  CONSTRAINT [FK_DeveloperInTeam_Team] FOREIGN KEY([TeamName])
REFERENCES [dbo].[Team] ([Name])
GO
ALTER TABLE [dbo].[DeveloperInTeam] CHECK CONSTRAINT [FK_DeveloperInTeam_Team]
GO
ALTER TABLE [dbo].[Drone]  WITH CHECK ADD  CONSTRAINT [FK_Drone_DroneRole] FOREIGN KEY([DroneRoleName])
REFERENCES [dbo].[DroneRole] ([Name])
GO
ALTER TABLE [dbo].[Drone] CHECK CONSTRAINT [FK_Drone_DroneRole]
GO
ALTER TABLE [dbo].[DroneSkillsSet]  WITH CHECK ADD  CONSTRAINT [FK_DroneSkillsSet_Drone] FOREIGN KEY([ShortNameDrone])
REFERENCES [dbo].[Drone] ([ShortName])
GO
ALTER TABLE [dbo].[DroneSkillsSet] CHECK CONSTRAINT [FK_DroneSkillsSet_Drone]
GO
ALTER TABLE [dbo].[DroneSkillsSet]  WITH CHECK ADD  CONSTRAINT [FK_DroneSkillsSet_EfficiencyAction] FOREIGN KEY([EfficiencyActionName])
REFERENCES [dbo].[EfficiencyAction] ([Name])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DroneSkillsSet] CHECK CONSTRAINT [FK_DroneSkillsSet_EfficiencyAction]
GO
ALTER TABLE [dbo].[EventNew]  WITH CHECK ADD  CONSTRAINT [FK_Event_Disaster] FOREIGN KEY([DisasterWorldName])
REFERENCES [dbo].[DisasterWorld] ([Name])
GO
ALTER TABLE [dbo].[EventNew] CHECK CONSTRAINT [FK_Event_Disaster]
GO
ALTER TABLE [dbo].[GameObject]  WITH CHECK ADD  CONSTRAINT [FK_GameObject_StateGameObject] FOREIGN KEY([StateObject])
REFERENCES [dbo].[StateGameObject] ([Name])
GO
ALTER TABLE [dbo].[GameObject] CHECK CONSTRAINT [FK_GameObject_StateGameObject]
GO
ALTER TABLE [dbo].[GameObject]  WITH CHECK ADD  CONSTRAINT [FK_GameObject_TypeGameObject1] FOREIGN KEY([TypeObject])
REFERENCES [dbo].[TypeGameObject] ([Name])
GO
ALTER TABLE [dbo].[GameObject] CHECK CONSTRAINT [FK_GameObject_TypeGameObject1]
GO
ALTER TABLE [dbo].[InformationDrone]  WITH CHECK ADD  CONSTRAINT [FK_InformationDrone_Account] FOREIGN KEY([LoginUser])
REFERENCES [dbo].[Account] ([Login])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InformationDrone] CHECK CONSTRAINT [FK_InformationDrone_Account]
GO
ALTER TABLE [dbo].[InformationDrone]  WITH CHECK ADD  CONSTRAINT [FK_InformationDrone_Drone1] FOREIGN KEY([DroneShortName])
REFERENCES [dbo].[Drone] ([ShortName])
GO
ALTER TABLE [dbo].[InformationDrone] CHECK CONSTRAINT [FK_InformationDrone_Drone1]
GO
ALTER TABLE [dbo].[NetScan]  WITH CHECK ADD  CONSTRAINT [FK_NetScan_Event] FOREIGN KEY([EventNewCodeNumber])
REFERENCES [dbo].[EventNew] ([CodeNumber])
GO
ALTER TABLE [dbo].[NetScan] CHECK CONSTRAINT [FK_NetScan_Event]
GO
ALTER TABLE [dbo].[NetScan]  WITH CHECK ADD  CONSTRAINT [FK_NetScan_GameObject] FOREIGN KEY([GameObjectId])
REFERENCES [dbo].[GameObject] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NetScan] CHECK CONSTRAINT [FK_NetScan_GameObject]
GO
ALTER TABLE [dbo].[NetScan]  WITH CHECK ADD  CONSTRAINT [FK_NetScan_Planet] FOREIGN KEY([PlanetName])
REFERENCES [dbo].[Planet] ([Name])
GO
ALTER TABLE [dbo].[NetScan] CHECK CONSTRAINT [FK_NetScan_Planet]
GO
ALTER TABLE [dbo].[ObjectAvailable]  WITH CHECK ADD  CONSTRAINT [FK_ObjectAvailable_Account] FOREIGN KEY([LoginUser])
REFERENCES [dbo].[Account] ([Login])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ObjectAvailable] CHECK CONSTRAINT [FK_ObjectAvailable_Account]
GO
ALTER TABLE [dbo].[ObjectAvailable]  WITH CHECK ADD  CONSTRAINT [FK_ObjectAvailable_GameObject] FOREIGN KEY([ServerId])
REFERENCES [dbo].[GameObject] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ObjectAvailable] CHECK CONSTRAINT [FK_ObjectAvailable_GameObject]
GO
ALTER TABLE [dbo].[RateLimit]  WITH CHECK ADD  CONSTRAINT [FK_RateLimit_Account] FOREIGN KEY([Login])
REFERENCES [dbo].[Account] ([Login])
GO
ALTER TABLE [dbo].[RateLimit] CHECK CONSTRAINT [FK_RateLimit_Account]
GO
ALTER TABLE [dbo].[RateLimit]  WITH CHECK ADD  CONSTRAINT [FK_RateLimit_ActionUser] FOREIGN KEY([ActionUserName])
REFERENCES [dbo].[ActionUser] ([Name])
GO
ALTER TABLE [dbo].[RateLimit] CHECK CONSTRAINT [FK_RateLimit_ActionUser]
GO
ALTER TABLE [dbo].[Statistic]  WITH CHECK ADD  CONSTRAINT [FK_Statistic_Account] FOREIGN KEY([LoginUser])
REFERENCES [dbo].[Account] ([Login])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Statistic] CHECK CONSTRAINT [FK_Statistic_Account]
GO
ALTER TABLE [dbo].[TypeGameObject]  WITH CHECK ADD  CONSTRAINT [FK_TypeGameObject_UnicEfficensy] FOREIGN KEY([UnicEfficensyId])
REFERENCES [dbo].[UnicEfficiency] ([Name])
GO
ALTER TABLE [dbo].[TypeGameObject] CHECK CONSTRAINT [FK_TypeGameObject_UnicEfficensy]
GO
USE [master]
GO
ALTER DATABASE [SpaceGameWorld] SET  READ_WRITE 
GO
