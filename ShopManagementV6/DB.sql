USE [master]
GO
/****** Object:  Database [QuanLySieuThi]    Script Date: 12/15/2017 8:01:16 AM ******/
CREATE DATABASE [QuanLySieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySieuThi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.PHDTHAIHOANG\MSSQL\DATA\QuanLySieuThi.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLySieuThi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.PHDTHAIHOANG\MSSQL\DATA\QuanLySieuThi_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLySieuThi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLySieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLySieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySieuThi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLySieuThi]
GO
/****** Object:  User [QLST]    Script Date: 12/15/2017 8:01:16 AM ******/
CREATE USER [QLST] FOR LOGIN [QLST] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [QLST]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/15/2017 8:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](50) NULL,
	[Name] [nvarchar](100) NULL,
	[Descriptions] [nvarchar](250) NULL,
	[DateOfBirth] [datetime] NULL,
	[IsAdmin] [bit] NULL,
	[SalesPersonID] [bigint] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/15/2017 8:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[BillInfo] [varchar](100) NOT NULL,
	[SoldDate] [datetime] NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[Description] [nvarchar](250) NULL,
	[CustomerName] [nvarchar](100) NULL,
	[SalesPersonID] [bigint] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[BillInfo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/15/2017 8:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[ProductDescription] [nvarchar](250) NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[AddedDate] [datetime] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductsBill]    Script Date: 12/15/2017 8:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductsBill](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NULL,
	[ProductName] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[BillInfo] [varchar](100) NULL,
	[TotalPrice] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ProductsBill] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesPerson]    Script Date: 12/15/2017 8:01:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesPerson](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[DateOfBirth] [date] NULL,
	[Salary] [decimal](18, 0) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_SalesPerson] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (1, N'hoangnguyencs96', N'123456', N'Nguyễn Thái Hoàng', NULL, NULL, 0, 4)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (2, N'admin', N'admin', N'Nguyễn Văn Admin', NULL, NULL, 1, 5)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (3, N'dangvanduy', N'dangvanduy', N'Đặng Văn Duy', NULL, NULL, 0, 1)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (4, N'hahuygiang', N'hahuygiang', N'Hà Huy Giang', NULL, NULL, 0, 2)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (6, N'nguyenle', N'123456', N'Nguyễn Lệ', N'babi', CAST(0x0000897900000000 AS DateTime), 1, 4)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (8, N'duybech', N'duybech', NULL, NULL, NULL, 0, 1)
INSERT [dbo].[Account] ([ID], [UserName], [Password], [Name], [Descriptions], [DateOfBirth], [IsAdmin], [SalesPersonID]) VALUES (9, N'bech1', N'bech1', N'Giang Bếch', N'', CAST(0x0000000000000000 AS DateTime), 0, 2)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (5, N'11/8/2017 11:56:15 PM', CAST(0x0000A825018A7A81 AS DateTime), CAST(86450000 AS Decimal(18, 0)), NULL, N'Hoàng', 4)
INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (6, N'11/8/2017 11:57:08 PM', CAST(0x0000A825018AB965 AS DateTime), CAST(74480000 AS Decimal(18, 0)), NULL, N'Duy', 4)
INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (10005, N'11/10/2017 4:00:45 PM', CAST(0x0000A8270107E101 AS DateTime), CAST(72000000 AS Decimal(18, 0)), NULL, N'Duy', 4)
INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (10006, N'11/10/2017 4:02:13 PM', CAST(0x0000A827010848C0 AS DateTime), CAST(53490000 AS Decimal(18, 0)), NULL, N'Hùng', 4)
INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (10007, N'11/10/2017 4:03:16 PM', CAST(0x0000A827010891F3 AS DateTime), CAST(91480000 AS Decimal(18, 0)), NULL, N'Phousack', 4)
INSERT [dbo].[Bill] ([ID], [BillInfo], [SoldDate], [TotalPrice], [Description], [CustomerName], [SalesPersonID]) VALUES (10008, N'12/4/2017 9:21:43 AM', CAST(0x0000A83F009A4802 AS DateTime), CAST(65470000 AS Decimal(18, 0)), NULL, N'', 4)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (1, N'DELL INSPIRON 16 3543', N'Core-i7/8GB/1TB/Nvidia840M/', 16, CAST(17990000 AS Decimal(18, 0)), CAST(0x0000A8230163FF70 AS DateTime))
INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (2, N'DELL VOSTRO 3333', N'Core-i5/4GB/500GB/Nvidia820M/', 16, CAST(13490000 AS Decimal(18, 0)), CAST(0x0000A82301648C8C AS DateTime))
INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (5, N'HP Elitebook 4210', N'Core-i3/4GB/250GB/Nvidia450M', 18, CAST(10000000 AS Decimal(18, 0)), CAST(0x0000A82400502124 AS DateTime))
INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (6, N'HP Elitebook 5320', N'Core-i5/8GB/500GB/Nvidia950M', 11, CAST(16000000 AS Decimal(18, 0)), CAST(0x0000A82400505927 AS DateTime))
INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (7, N'Sony Vaio 2420', N'Core-i9/16GB/2TB/Nvidia980M-GTX/SDD250GB', 12, CAST(30000000 AS Decimal(18, 0)), CAST(0x0000A82400509D60 AS DateTime))
INSERT [dbo].[Product] ([ID], [ProductName], [ProductDescription], [Quantity], [Price], [AddedDate]) VALUES (9, N'Android Tivi Sony 4K 43 inch KD-43X7500E', N'Android/43inch/UltraHD4K', 19, CAST(14990000 AS Decimal(18, 0)), CAST(0x0000A82400E712B1 AS DateTime))
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[ProductsBill] ON 

INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (9, 1, N'DELL INSPIRON 16 3543', 2, N'11/8/2017 11:56:15 PM', CAST(35980000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10, 2, N'DELL VOSTRO 3333', 3, N'11/8/2017 11:56:15 PM', CAST(40470000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (11, 5, N'HP Elitebook 4210', 1, N'11/8/2017 11:56:15 PM', CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (12, 2, N'DELL VOSTRO 3333', 1, N'11/8/2017 11:57:08 PM', CAST(13490000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (13, 7, N'Sony Vaio 2420', 1, N'11/8/2017 11:57:08 PM', CAST(30000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (14, 6, N'HP Elitebook 5320', 1, N'11/8/2017 11:57:08 PM', CAST(16000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (15, 9, N'Android Tivi Sony 4K 43 inch KD-43X7500E', 1, N'11/8/2017 11:57:08 PM', CAST(14990000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10009, 5, N'HP Elitebook 4210', 1, N'11/10/2017 4:00:45 PM', CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10010, 6, N'HP Elitebook 5320', 2, N'11/10/2017 4:00:45 PM', CAST(32000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10011, 7, N'Sony Vaio 2420', 1, N'11/10/2017 4:00:45 PM', CAST(30000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10012, 2, N'DELL VOSTRO 3333', 1, N'11/10/2017 4:02:13 PM', CAST(13490000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10013, 5, N'HP Elitebook 4210', 1, N'11/10/2017 4:02:13 PM', CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10014, 7, N'Sony Vaio 2420', 1, N'11/10/2017 4:02:13 PM', CAST(30000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10015, 1, N'DELL INSPIRON 16 3543', 1, N'11/10/2017 4:03:16 PM', CAST(17990000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10016, 2, N'DELL VOSTRO 3333', 1, N'11/10/2017 4:03:16 PM', CAST(13490000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10017, 7, N'Sony Vaio 2420', 2, N'11/10/2017 4:03:16 PM', CAST(60000000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10018, 1, N'DELL INSPIRON 16 3543', 3, N'12/4/2017 9:21:43 AM', CAST(35980000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10019, 2, N'DELL VOSTRO 3333', 1, N'12/4/2017 9:21:43 AM', CAST(13490000 AS Decimal(18, 0)))
INSERT [dbo].[ProductsBill] ([ID], [ProductID], [ProductName], [Quantity], [BillInfo], [TotalPrice]) VALUES (10020, 6, N'HP Elitebook 5320', 1, N'12/4/2017 9:21:43 AM', CAST(16000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ProductsBill] OFF
SET IDENTITY_INSERT [dbo].[SalesPerson] ON 

INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (1, N'Đặng Văn Duy', CAST(0xD41E0B00 AS Date), CAST(5000000 AS Decimal(18, 0)), N'Ẳng Ẳng Ẳng')
INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (2, N'Hà Huy Giang', CAST(0xA21F0B00 AS Date), CAST(6000000 AS Decimal(18, 0)), N'Éc Éc Éc')
INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (3, N'Đỗ Tiến Đạt', CAST(0x521E0B00 AS Date), CAST(5000000 AS Decimal(18, 0)), N'Gâu Gâu Gâu')
INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (4, N'Nguyễn Thái Hoàng', CAST(0xD41E0B00 AS Date), CAST(10000000 AS Decimal(18, 0)), N'Big Boss')
INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (5, N'Nguyễn Văn Admin', CAST(0x061D0B00 AS Date), CAST(8000000 AS Decimal(18, 0)), N'Semi Boss')
INSERT [dbo].[SalesPerson] ([ID], [Name], [DateOfBirth], [Salary], [Description]) VALUES (10006, N'Nguyễn Lệ', CAST(0xBE1E0B00 AS Date), CAST(200000 AS Decimal(18, 0)), N'')
SET IDENTITY_INSERT [dbo].[SalesPerson] OFF
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [DF_Account_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF_Bill_SoldDate]  DEFAULT (getdate()) FOR [SoldDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_AddedDate]  DEFAULT (getdate()) FOR [AddedDate]
GO
USE [master]
GO
ALTER DATABASE [QuanLySieuThi] SET  READ_WRITE 
GO
