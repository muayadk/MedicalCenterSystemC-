USE [master]
GO
/****** Object:  Database [MedicalCenterDb]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE DATABASE [MedicalCenterDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MedicalCenterDb', FILENAME = N'D:\Apps Programing Language\c#\MedicalCenterDb.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MedicalCenterDb_log', FILENAME = N'D:\Apps Programing Language\c#\MedicalCenterDb_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MedicalCenterDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalCenterDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MedicalCenterDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MedicalCenterDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MedicalCenterDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MedicalCenterDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MedicalCenterDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET RECOVERY FULL 
GO
ALTER DATABASE [MedicalCenterDb] SET  MULTI_USER 
GO
ALTER DATABASE [MedicalCenterDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MedicalCenterDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MedicalCenterDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MedicalCenterDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MedicalCenterDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MedicalCenterDb', N'ON'
GO
USE [MedicalCenterDb]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accounts](
	[Acc_Num] [int] NOT NULL,
	[Acc_Name] [nvarchar](100) NOT NULL,
	[Acc_Type] [nvarchar](50) NOT NULL,
	[Parent_Acc] [int] NOT NULL,
	[Degree] [int] NOT NULL,
	[Report] [char](15) NULL,
	[Coin] [nvarchar](50) NULL,
	[Acc_Nature] [nvarchar](30) NULL,
	[Coin_Num] [int] NULL,
	[Acc_Stat] [nvarchar](10) NOT NULL DEFAULT ('???'),
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Acc_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[activeMaterialTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[activeMaterialTab](
	[acId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[acCode] [nvarchar](100) NULL,
	[acName] [nvarchar](100) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_activeMaterialTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_activeMaterialTab] PRIMARY KEY CLUSTERED 
(
	[acId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[appointmentTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointmentTab](
	[apId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[apCode] [nvarchar](100) NULL,
	[apName] [nvarchar](100) NULL,
	[apDate] [date] NULL,
	[apTime] [time](7) NULL,
	[apNote] [nvarchar](200) NULL,
	[paId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_appointmentTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_appointmentTab] PRIMARY KEY CLUSTERED 
(
	[apId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Branch]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[Branch_Num] [int] NOT NULL,
	[Branch_Name] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](1100) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_Branch_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[Branch_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cash]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cash](
	[Cash_Num] [int] NOT NULL,
	[Branch_Num] [int] NULL,
	[Cash_Name] [nvarchar](50) NOT NULL,
	[Acc_Num] [int] NOT NULL,
	[Coin_Num] [int] NULL,
 CONSTRAINT [PK_Cash] PRIMARY KEY CLUSTERED 
(
	[Cash_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clinicTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinicTab](
	[clId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[clCode] [nvarchar](100) NULL,
	[clName] [nvarchar](100) NULL,
	[clMobile] [int] NULL,
	[clAddress] [nvarchar](100) NULL,
	[clNote] [nvarchar](100) NULL,
	[hoId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_clinicTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_clinicTab] PRIMARY KEY CLUSTERED 
(
	[clId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Coin]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Coin](
	[Coin_Num] [int] NOT NULL,
	[Coin_Name] [nvarchar](30) NOT NULL,
	[Symbol] [char](5) NOT NULL,
	[Coin_Price] [float] NULL,
	[Coin_Type] [nvarchar](50) NULL,
	[Coin_Max] [float] NULL,
	[Coin_Min] [float] NULL,
	[Coin_Sub] [nvarchar](50) NULL,
 CONSTRAINT [PK_Coin] PRIMARY KEY CLUSTERED 
(
	[Coin_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[companySuplierDragTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[companySuplierDragTab](
	[comsId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[comsCode] [nvarchar](100) NULL,
	[comsName] [nvarchar](100) NULL,
	[comsMobile1] [int] NULL,
	[comsMobile2] [int] NULL,
	[comsAddress] [nvarchar](100) NULL,
	[comsNote] [nvarchar](200) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_companySuplierDragTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_companySuplierDragTab] PRIMARY KEY CLUSTERED 
(
	[comsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Constriant]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Constriant](
	[Cons_Num] [int] NOT NULL,
	[Mony] [float] NOT NULL,
	[Date] [date] NOT NULL,
	[Operation_Num] [int] NULL,
	[Cons_Type] [nvarchar](40) NOT NULL,
	[Coin_Num] [int] NULL,
	[Is_Round] [nvarchar](50) NULL,
 CONSTRAINT [PK_Constriant] PRIMARY KEY CLUSTERED 
(
	[Cons_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Constriant_Affect]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Constriant_Affect](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Cons_Num] [int] NOT NULL,
	[Acc_Num] [int] NOT NULL,
	[Debit] [float] NULL,
	[Cridit] [float] NULL,
	[Note] [nvarchar](300) NOT NULL,
	[Change_Coin] [float] NULL,
	[Coin_Affect] [int] NULL,
	[Cost_Centers_Num] [int] NULL,
 CONSTRAINT [PK_Constriant_Affect] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cost_Centers]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cost_Centers](
	[Cost_Centers_Num] [int] NOT NULL,
	[Cost_Centers_Name] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diagnoseTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnoseTab](
	[diId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[diCode] [nvarchar](100) NULL,
	[diName] [nvarchar](100) NULL,
	[diDate] [nvarchar](50) NULL,
	[diTime] [nvarchar](50) NULL,
	[viId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_diagnoseTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_diagnoseTab] PRIMARY KEY CLUSTERED 
(
	[diId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doctorsTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctorsTab](
	[doId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[doCode] [nvarchar](100) NULL,
	[doNameE] [nvarchar](100) NULL,
	[doNameA] [nvarchar](100) NULL,
	[doSex] [nvarchar](50) NULL,
	[doBrithday] [nvarchar](50) NULL,
	[doAge] [int] NULL,
	[doMobile] [int] NULL,
	[doAddress] [nvarchar](100) NOT NULL,
	[doImg] [image] NULL,
	[doCountry] [nvarchar](100) NULL,
	[doCity] [nvarchar](100) NULL,
	[doSpecil] [nvarchar](100) NULL,
	[doQual] [nvarchar](100) NULL,
	[doType] [nvarchar](100) NULL,
	[doState] [nvarchar](100) NULL,
	[clId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_doctorsTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_doctorsTab] PRIMARY KEY CLUSTERED 
(
	[doId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doseTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doseTab](
	[doseId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[doseCode] [nvarchar](100) NULL,
	[doseName] [nvarchar](100) NULL,
	[doseQty] [nvarchar](50) NULL,
	[doseTime] [nvarchar](50) NULL,
	[doseSize] [nvarchar](50) NULL,
	[doseUse] [nvarchar](100) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_doseTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_doseTab] PRIMARY KEY CLUSTERED 
(
	[doseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dragTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dragTab](
	[drId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[drCode] [nvarchar](100) NULL,
	[drName] [nvarchar](100) NULL,
	[drSname] [nvarchar](100) NULL,
	[drNote] [nvarchar](100) NULL,
	[sciId] [numeric](18, 0) NULL,
	[acId] [numeric](18, 0) NULL,
	[grdrId] [numeric](18, 0) NULL,
	[sfId] [numeric](18, 0) NULL,
	[comsId] [numeric](18, 0) NULL,
	[header0] [int] NULL,
	[header1] [int] NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_dragTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_dragTab] PRIMARY KEY CLUSTERED 
(
	[drId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[groupDragTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groupDragTab](
	[grdrId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[grdrCode] [nvarchar](100) NULL,
	[grdrName] [nvarchar](100) NULL,
	[grdrNote] [nvarchar](200) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_groupDragTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_groupDragTab] PRIMARY KEY CLUSTERED 
(
	[grdrId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[groupTestTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groupTestTab](
	[grId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[grCode] [nvarchar](100) NULL,
	[grName] [nvarchar](100) NULL,
	[ACC_Num] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_groupTestTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_groupTestTab] PRIMARY KEY CLUSTERED 
(
	[grId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hospitalCenterTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hospitalCenterTab](
	[hoId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[hoCode] [nvarchar](100) NULL,
	[hoNameE] [nvarchar](100) NULL,
	[hoNameA] [nvarchar](100) NULL,
	[hoMobile1] [int] NULL,
	[hoMobile2] [int] NULL,
	[hoAddressE] [nvarchar](100) NULL,
	[hoAddressA] [nvarchar](100) NULL,
	[hoFix] [int] NULL,
	[hoImg] [image] NULL,
	[hoNote] [nvarchar](200) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_hospitalCenterTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_hospitalCenterTab] PRIMARY KEY CLUSTERED 
(
	[hoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[patientsTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patientsTab](
	[paId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[paCode] [nvarchar](100) NULL,
	[paFname] [nvarchar](100) NULL,
	[paLname] [nvarchar](100) NULL,
	[paSex] [nvarchar](50) NULL,
	[paBrithday] [nvarchar](50) NULL,
	[paAge] [int] NULL,
	[paMobile1] [int] NULL,
	[paMobile2] [int] NULL,
	[paImg] [image] NULL,
	[paAddress] [nvarchar](100) NULL,
	[paCountry] [nvarchar](100) NULL,
	[paCity] [nvarchar](100) NULL,
	[paBloodType] [nvarchar](50) NULL,
	[paState] [nvarchar](100) NULL,
	[paType] [nvarchar](100) NULL,
	[ACC_Num] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_patientsTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_patientsTab] PRIMARY KEY CLUSTERED 
(
	[paId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[prescriptionTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prescriptionTab](
	[presId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[presCode] [nvarchar](100) NULL,
	[presName] [nvarchar](100) NULL,
	[presQyt] [nvarchar](100) NULL,
	[presTimeUse] [nvarchar](100) NULL,
	[presSize] [nvarchar](100) NULL,
	[presPriod] [nvarchar](100) NULL,
	[reId] [numeric](18, 0) NULL,
	[drId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_prescriptionTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_presPriod] PRIMARY KEY CLUSTERED 
(
	[presId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[previewTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[previewTab](
	[prId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[prCode] [nvarchar](100) NULL,
	[prName] [nvarchar](100) NULL,
	[prDate] [nvarchar](50) NOT NULL,
	[prTime] [nvarchar](50) NOT NULL,
	[prNote] [nvarchar](200) NULL,
	[viId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_previewTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_previewTab] PRIMARY KEY CLUSTERED 
(
	[prId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[recipeTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recipeTab](
	[reId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[reCode] [nvarchar](100) NULL,
	[reDate] [nvarchar](50) NULL,
	[reTime] [nvarchar](50) NULL,
	[reNote] [nvarchar](200) NULL,
	[viId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_recipeTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_recipeTab] PRIMARY KEY CLUSTERED 
(
	[reId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[resultTestTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[resultTestTab](
	[rtId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[itId] [numeric](18, 0) NULL,
	[trId] [numeric](18, 0) NULL,
	[result] [nvarchar](100) NULL,
	[resultType] [nvarchar](100) NULL,
	[rtNote] [nvarchar](200) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_resultTestTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_resultTestTab] PRIMARY KEY CLUSTERED 
(
	[rtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[roles]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[roleId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](100) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[samplesTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[samplesTab](
	[saId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[saCode] [nvarchar](100) NULL,
	[saName] [nvarchar](100) NULL,
	[saAmount] [nvarchar](100) NULL,
	[saDate] [nvarchar](50) NULL,
	[saTime] [nvarchar](50) NULL,
	[saNote] [nvarchar](200) NULL,
	[trId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_samplesTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_samplesTab] PRIMARY KEY CLUSTERED 
(
	[saId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[scientificNameDragTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[scientificNameDragTab](
	[sciId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[sciCode] [nvarchar](100) NULL,
	[sciName] [nvarchar](100) NULL,
	[sciNote] [nvarchar](100) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_scientificNameDragTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_scientificNameDragTab] PRIMARY KEY CLUSTERED 
(
	[sciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Serial_Table]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serial_Table](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Key_Num] [nvarchar](100) NULL,
	[Serial_Num] [nvarchar](300) NULL,
	[Install] [nvarchar](50) NULL,
	[use_date] [nvarchar](50) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_Serial_Table_isDeleted]  DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[servicesLestTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicesLestTab](
	[slId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[seId] [numeric](18, 0) NULL,
	[srId] [numeric](18, 0) NULL,
	[slnote] [nvarchar](200) NULL,
	[slPrice] [float] NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_servicesLestTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_servicesLestTab] PRIMARY KEY CLUSTERED 
(
	[slId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[servicesRequestTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicesRequestTab](
	[srId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[srCode] [nvarchar](100) NULL,
	[srDate] [nvarchar](50) NULL,
	[srManual] [nvarchar](100) NULL,
	[srDiscount] [decimal](18, 0) NULL,
	[valueAdded] [decimal](18, 0) NULL,
	[Coin_Num] [int] NULL,
	[Cash_Num] [int] NULL,
	[viId] [numeric](18, 0) NULL,
	[methodPayment] [nvarchar](100) NULL,
	[Coin_change] [numeric](18, 0) NULL,
	[state] [nvarchar](50) NULL,
	[cons_Num] [int] NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_servicesRequestTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_servicesRequestTab] PRIMARY KEY CLUSTERED 
(
	[srId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[serviecsTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[serviecsTab](
	[seId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[seCode] [nvarchar](100) NULL,
	[seName] [nvarchar](100) NULL,
	[seType] [nvarchar](100) NULL,
	[sePrice] [decimal](18, 0) NULL,
	[seNote] [nvarchar](200) NULL,
	[ACC_Num] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_serviecsTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_serviecsTab] PRIMARY KEY CLUSTERED 
(
	[seId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[shapeFarmacy]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shapeFarmacy](
	[sfId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[sfCode] [nvarchar](100) NULL,
	[sfName] [nvarchar](100) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_shapeFarmacy_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_shapeFarmacy] PRIMARY KEY CLUSTERED 
(
	[sfId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[System_Options]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[System_Options](
	[Id] [int] NOT NULL,
	[Options_Num] [nvarchar](50) NULL,
	[Options_Name] [nvarchar](50) NULL,
	[Options] [nvarchar](max) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_System_Options_isDeleted]  DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[testItemTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testItemTab](
	[itId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[itCode] [nvarchar](100) NULL,
	[itName] [nvarchar](100) NULL,
	[itSname] [nvarchar](100) NULL,
	[maxValue] [nvarchar](50) NULL,
	[minValue] [nvarchar](50) NULL,
	[unitName] [nvarchar](100) NULL,
	[itPrice] [decimal](18, 0) NULL,
	[qty] [nvarchar](100) NULL,
	[teId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_testItemTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_testItemTab] PRIMARY KEY CLUSTERED 
(
	[itId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[testrRequesTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testrRequesTab](
	[trId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[trCode] [nvarchar](100) NULL,
	[trManual] [nvarchar](100) NULL,
	[trDate] [nvarchar](50) NULL,
	[trDiscount] [decimal](18, 0) NULL,
	[valueAdded] [decimal](18, 0) NULL,
	[Coin_Num] [int] NULL,
	[Cash_Num] [int] NULL,
	[viId] [numeric](18, 0) NULL,
	[methodPayment] [nvarchar](100) NULL,
	[Coin_change] [numeric](18, 0) NULL,
	[state] [nvarchar](50) NULL,
	[consId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_testrRequesTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_testrRequesTab] PRIMARY KEY CLUSTERED 
(
	[trId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[testTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testTab](
	[teId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[teCode] [nvarchar](100) NULL,
	[teName] [nvarchar](100) NULL,
	[teSname] [nvarchar](100) NULL,
	[teNote] [nvarchar](200) NULL,
	[grId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_testTab_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_testTab] PRIMARY KEY CLUSTERED 
(
	[teId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[userRoles]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userRoles](
	[userId] [numeric](18, 0) NULL,
	[roleId] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_Num] [int] NOT NULL,
	[Full_Name] [nvarchar](50) NULL,
	[User_Login_Name] [nvarchar](50) NOT NULL,
	[User_Pass] [nvarchar](50) NOT NULL,
	[Permission_Level] [nvarchar](10) NOT NULL,
	[Address] [nchar](10) NULL,
	[Phone_Num] [nchar](10) NULL,
	[Is_Admin] [bit] NULL,
	[Status] [nvarchar](10) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_Users_isDeleted]  DEFAULT ((0)),
 CONSTRAINT [PK_Users1] PRIMARY KEY CLUSTERED 
(
	[User_Num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users1]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users1](
	[userId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[confirmPassword] [nvarchar](100) NULL,
	[userType] [nvarchar](100) NULL,
	[userState] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[userIdentifier] [numeric](18, 0) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[visitTab]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitTab](
	[viId] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[viCode] [nvarchar](100) NULL,
	[viName] [nvarchar](100) NULL,
	[viDate] [nvarchar](50) NULL,
	[viTime] [nvarchar](50) NULL,
	[paId] [numeric](18, 0) NULL,
	[apId] [numeric](18, 0) NULL,
	[viNote] [nvarchar](200) NULL,
	[doId] [numeric](18, 0) NULL,
	[isDeleted] [bit] NULL CONSTRAINT [DF_visitTab_isDeleted_1]  DEFAULT ((0)),
 CONSTRAINT [PK_visitTab] PRIMARY KEY CLUSTERED 
(
	[viId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [apName]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [apName] ON [dbo].[appointmentTab]
(
	[apName] ASC,
	[apDate] ASC,
	[apTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [clNameIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [clNameIndex] ON [dbo].[clinicTab]
(
	[clName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_clinicTab]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE NONCLUSTERED INDEX [IX_clinicTab] ON [dbo].[clinicTab]
(
	[clName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [diagnoseIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [diagnoseIndex] ON [dbo].[diagnoseTab]
(
	[diName] ASC,
	[diDate] ASC,
	[diTime] ASC,
	[viId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [doNameIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE NONCLUSTERED INDEX [doNameIndex] ON [dbo].[doctorsTab]
(
	[doNameE] ASC,
	[doNameA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [hoNameIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [hoNameIndex] ON [dbo].[hospitalCenterTab]
(
	[hoNameE] ASC,
	[hoNameA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [paNameIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [paNameIndex] ON [dbo].[patientsTab]
(
	[paFname] ASC,
	[paLname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [prName]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [prName] ON [dbo].[previewTab]
(
	[prName] ASC,
	[prDate] ASC,
	[prTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [reCode]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [reCode] ON [dbo].[recipeTab]
(
	[reCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [seCodeIndex-20200913-061239]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [seCodeIndex-20200913-061239] ON [dbo].[serviecsTab]
(
	[seCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [patientVisitIndex]    Script Date: 30/09/2020 06:36:27 ص ******/
CREATE UNIQUE NONCLUSTERED INDEX [patientVisitIndex] ON [dbo].[visitTab]
(
	[viName] ASC,
	[viDate] ASC,
	[viTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[appointmentTab]  WITH CHECK ADD  CONSTRAINT [FK_appointmentTab_patientsTab] FOREIGN KEY([paId])
REFERENCES [dbo].[patientsTab] ([paId])
GO
ALTER TABLE [dbo].[appointmentTab] CHECK CONSTRAINT [FK_appointmentTab_patientsTab]
GO
ALTER TABLE [dbo].[Cash]  WITH CHECK ADD  CONSTRAINT [FK_Cash_Accounts] FOREIGN KEY([Acc_Num])
REFERENCES [dbo].[Accounts] ([Acc_Num])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cash] CHECK CONSTRAINT [FK_Cash_Accounts]
GO
ALTER TABLE [dbo].[clinicTab]  WITH CHECK ADD  CONSTRAINT [FK_clinicTab_hospitalCenterTab] FOREIGN KEY([hoId])
REFERENCES [dbo].[hospitalCenterTab] ([hoId])
GO
ALTER TABLE [dbo].[clinicTab] CHECK CONSTRAINT [FK_clinicTab_hospitalCenterTab]
GO
ALTER TABLE [dbo].[Constriant_Affect]  WITH CHECK ADD  CONSTRAINT [FK_Constriant_Affect_Constriant] FOREIGN KEY([Cons_Num])
REFERENCES [dbo].[Constriant] ([Cons_Num])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Constriant_Affect] CHECK CONSTRAINT [FK_Constriant_Affect_Constriant]
GO
ALTER TABLE [dbo].[doctorsTab]  WITH CHECK ADD  CONSTRAINT [FK_doctorsTab_clinicTab] FOREIGN KEY([clId])
REFERENCES [dbo].[clinicTab] ([clId])
GO
ALTER TABLE [dbo].[doctorsTab] CHECK CONSTRAINT [FK_doctorsTab_clinicTab]
GO
ALTER TABLE [dbo].[dragTab]  WITH CHECK ADD  CONSTRAINT [FK_dragTab_activeMaterialTab] FOREIGN KEY([acId])
REFERENCES [dbo].[activeMaterialTab] ([acId])
GO
ALTER TABLE [dbo].[dragTab] CHECK CONSTRAINT [FK_dragTab_activeMaterialTab]
GO
ALTER TABLE [dbo].[dragTab]  WITH CHECK ADD  CONSTRAINT [FK_dragTab_companySuplierDragTab] FOREIGN KEY([comsId])
REFERENCES [dbo].[companySuplierDragTab] ([comsId])
GO
ALTER TABLE [dbo].[dragTab] CHECK CONSTRAINT [FK_dragTab_companySuplierDragTab]
GO
ALTER TABLE [dbo].[dragTab]  WITH CHECK ADD  CONSTRAINT [FK_dragTab_groupDragTab] FOREIGN KEY([grdrId])
REFERENCES [dbo].[groupDragTab] ([grdrId])
GO
ALTER TABLE [dbo].[dragTab] CHECK CONSTRAINT [FK_dragTab_groupDragTab]
GO
ALTER TABLE [dbo].[dragTab]  WITH CHECK ADD  CONSTRAINT [FK_dragTab_scientificNameDragTab] FOREIGN KEY([sciId])
REFERENCES [dbo].[scientificNameDragTab] ([sciId])
GO
ALTER TABLE [dbo].[dragTab] CHECK CONSTRAINT [FK_dragTab_scientificNameDragTab]
GO
ALTER TABLE [dbo].[dragTab]  WITH CHECK ADD  CONSTRAINT [FK_dragTab_shapeFarmacy] FOREIGN KEY([sfId])
REFERENCES [dbo].[shapeFarmacy] ([sfId])
GO
ALTER TABLE [dbo].[dragTab] CHECK CONSTRAINT [FK_dragTab_shapeFarmacy]
GO
ALTER TABLE [dbo].[prescriptionTab]  WITH CHECK ADD  CONSTRAINT [FK_prescriptionTab_recipeTab] FOREIGN KEY([reId])
REFERENCES [dbo].[recipeTab] ([reId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[prescriptionTab] CHECK CONSTRAINT [FK_prescriptionTab_recipeTab]
GO
ALTER TABLE [dbo].[prescriptionTab]  WITH CHECK ADD  CONSTRAINT [FK_presPriod_doctorsTab] FOREIGN KEY([drId])
REFERENCES [dbo].[dragTab] ([drId])
GO
ALTER TABLE [dbo].[prescriptionTab] CHECK CONSTRAINT [FK_presPriod_doctorsTab]
GO
ALTER TABLE [dbo].[previewTab]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_visitTab] FOREIGN KEY([viId])
REFERENCES [dbo].[visitTab] ([viId])
GO
ALTER TABLE [dbo].[previewTab] CHECK CONSTRAINT [FK_Table_1_visitTab]
GO
ALTER TABLE [dbo].[recipeTab]  WITH CHECK ADD  CONSTRAINT [FK_recipeTab_visitTab] FOREIGN KEY([viId])
REFERENCES [dbo].[visitTab] ([viId])
GO
ALTER TABLE [dbo].[recipeTab] CHECK CONSTRAINT [FK_recipeTab_visitTab]
GO
ALTER TABLE [dbo].[resultTestTab]  WITH CHECK ADD  CONSTRAINT [FK_resultTestTab_testItemTab] FOREIGN KEY([itId])
REFERENCES [dbo].[testItemTab] ([itId])
GO
ALTER TABLE [dbo].[resultTestTab] CHECK CONSTRAINT [FK_resultTestTab_testItemTab]
GO
ALTER TABLE [dbo].[resultTestTab]  WITH CHECK ADD  CONSTRAINT [FK_resultTestTab_testrRequesTab] FOREIGN KEY([trId])
REFERENCES [dbo].[testrRequesTab] ([trId])
GO
ALTER TABLE [dbo].[resultTestTab] CHECK CONSTRAINT [FK_resultTestTab_testrRequesTab]
GO
ALTER TABLE [dbo].[samplesTab]  WITH CHECK ADD  CONSTRAINT [FK_samplesTab_testrRequesTab] FOREIGN KEY([trId])
REFERENCES [dbo].[testrRequesTab] ([trId])
GO
ALTER TABLE [dbo].[samplesTab] CHECK CONSTRAINT [FK_samplesTab_testrRequesTab]
GO
ALTER TABLE [dbo].[servicesLestTab]  WITH CHECK ADD  CONSTRAINT [FK_servicesLestTab_servicesRequestTab] FOREIGN KEY([srId])
REFERENCES [dbo].[servicesRequestTab] ([srId])
GO
ALTER TABLE [dbo].[servicesLestTab] CHECK CONSTRAINT [FK_servicesLestTab_servicesRequestTab]
GO
ALTER TABLE [dbo].[servicesLestTab]  WITH CHECK ADD  CONSTRAINT [FK_servicesLestTab_serviecsTab] FOREIGN KEY([seId])
REFERENCES [dbo].[serviecsTab] ([seId])
GO
ALTER TABLE [dbo].[servicesLestTab] CHECK CONSTRAINT [FK_servicesLestTab_serviecsTab]
GO
ALTER TABLE [dbo].[servicesRequestTab]  WITH CHECK ADD  CONSTRAINT [FK_servicesRequestTab_Cash] FOREIGN KEY([Cash_Num])
REFERENCES [dbo].[Cash] ([Cash_Num])
GO
ALTER TABLE [dbo].[servicesRequestTab] CHECK CONSTRAINT [FK_servicesRequestTab_Cash]
GO
ALTER TABLE [dbo].[servicesRequestTab]  WITH CHECK ADD  CONSTRAINT [FK_servicesRequestTab_Coin] FOREIGN KEY([Coin_Num])
REFERENCES [dbo].[Coin] ([Coin_Num])
GO
ALTER TABLE [dbo].[servicesRequestTab] CHECK CONSTRAINT [FK_servicesRequestTab_Coin]
GO
ALTER TABLE [dbo].[servicesRequestTab]  WITH CHECK ADD  CONSTRAINT [FK_servicesRequestTab_visitTab] FOREIGN KEY([viId])
REFERENCES [dbo].[visitTab] ([viId])
GO
ALTER TABLE [dbo].[servicesRequestTab] CHECK CONSTRAINT [FK_servicesRequestTab_visitTab]
GO
ALTER TABLE [dbo].[testItemTab]  WITH CHECK ADD  CONSTRAINT [FK_testItemTab_testTab] FOREIGN KEY([teId])
REFERENCES [dbo].[testTab] ([teId])
GO
ALTER TABLE [dbo].[testItemTab] CHECK CONSTRAINT [FK_testItemTab_testTab]
GO
ALTER TABLE [dbo].[testrRequesTab]  WITH CHECK ADD  CONSTRAINT [FK_testrRequesTab_Cash] FOREIGN KEY([Cash_Num])
REFERENCES [dbo].[Cash] ([Cash_Num])
GO
ALTER TABLE [dbo].[testrRequesTab] CHECK CONSTRAINT [FK_testrRequesTab_Cash]
GO
ALTER TABLE [dbo].[testrRequesTab]  WITH CHECK ADD  CONSTRAINT [FK_testrRequesTab_Coin] FOREIGN KEY([Coin_Num])
REFERENCES [dbo].[Coin] ([Coin_Num])
GO
ALTER TABLE [dbo].[testrRequesTab] CHECK CONSTRAINT [FK_testrRequesTab_Coin]
GO
ALTER TABLE [dbo].[testrRequesTab]  WITH CHECK ADD  CONSTRAINT [FK_testrRequesTab_visitTab] FOREIGN KEY([viId])
REFERENCES [dbo].[visitTab] ([viId])
GO
ALTER TABLE [dbo].[testrRequesTab] CHECK CONSTRAINT [FK_testrRequesTab_visitTab]
GO
ALTER TABLE [dbo].[testTab]  WITH CHECK ADD  CONSTRAINT [FK_testTab_groupTestTab] FOREIGN KEY([grId])
REFERENCES [dbo].[groupTestTab] ([grId])
GO
ALTER TABLE [dbo].[testTab] CHECK CONSTRAINT [FK_testTab_groupTestTab]
GO
ALTER TABLE [dbo].[userRoles]  WITH CHECK ADD  CONSTRAINT [FK_userRoles_roles] FOREIGN KEY([roleId])
REFERENCES [dbo].[roles] ([roleId])
GO
ALTER TABLE [dbo].[userRoles] CHECK CONSTRAINT [FK_userRoles_roles]
GO
ALTER TABLE [dbo].[userRoles]  WITH CHECK ADD  CONSTRAINT [FK_userRoles_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users1] ([userId])
GO
ALTER TABLE [dbo].[userRoles] CHECK CONSTRAINT [FK_userRoles_users]
GO
ALTER TABLE [dbo].[visitTab]  WITH CHECK ADD  CONSTRAINT [FK_visitTab_doctorsTab] FOREIGN KEY([doId])
REFERENCES [dbo].[doctorsTab] ([doId])
GO
ALTER TABLE [dbo].[visitTab] CHECK CONSTRAINT [FK_visitTab_doctorsTab]
GO
ALTER TABLE [dbo].[visitTab]  WITH CHECK ADD  CONSTRAINT [FK_visitTab_patientsTab] FOREIGN KEY([paId])
REFERENCES [dbo].[patientsTab] ([paId])
GO
ALTER TABLE [dbo].[visitTab] CHECK CONSTRAINT [FK_visitTab_patientsTab]
GO
/****** Object:  StoredProcedure [dbo].[AddDiagnoses]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create PROCEDURE [dbo].[AddDiagnoses](
           @diCode nvarchar(100),
           @diName nvarchar(100),
           @diDate nvarchar(50),
           @diTime nvarchar(50),
           @viId numeric(18,0)
					
                    )
AS
BEGIN




INSERT INTO [dbo].[diagnoseTab]
           ([diCode]
           ,[diName]
           ,[diDate]
           ,[diTime]
           ,[viId]
           )
     VALUES
           (@diCode
           ,@diName
           ,@diDate
           ,@diTime
           ,@viId
           )
		   end
GO
/****** Object:  StoredProcedure [dbo].[AddPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[AddPatient](
            @paCode nvarchar(100)
           ,@paFname nvarchar(100)
           ,@paLname nvarchar(100)
           ,@paSex nvarchar(50)
           ,@paBrithday nvarchar(50)
           ,@paAge int
           ,@paMobile1 int
           ,@paMobile2 int
           ,@paImg image
           ,@paAddress nvarchar(100)
           ,@paCountry nvarchar(100)
           ,@paCity  nvarchar(100)
           ,@paBloodType nvarchar(50)
           ,@paState nvarchar(100)
           ,@paType nvarchar(100)
           ,@ACC_Num numeric(18,0)
					
                    )
AS
BEGIN


INSERT INTO patientsTab
           (
		    [paCode]
           ,[paFname]
           ,[paLname]
           ,[paSex]
           ,[paBrithday]
           ,[paAge]
           ,[paMobile1]
           ,[paMobile2]
           ,[paImg]
           ,[paAddress]
           ,[paCountry]
           ,[paCity]
           ,[paBloodType]
           ,[paState]
           ,[paType]
           ,[ACC_Num]
		   
		   )
     VALUES
           (
		   @paCode, 
           @paFname, 
           @paLname, 
           @paSex, 
           @paBrithday,
           @paAge, 
           @paMobile1, 
           @paMobile2,
           @paImg, 
           @paAddress,
           @paCountry, 
           @paCity, 
           @paBloodType,
           @paState, 
           @paType,
           @ACC_Num
		   )
End



GO
/****** Object:  StoredProcedure [dbo].[AddPrescription]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create PROCEDURE [dbo].[AddPrescription](
            @presCode nvarchar(100)
           ,@presName nvarchar(100)
           ,@presQyt nvarchar(100)
           ,@presTimeUse nvarchar(100)
           ,@presSize  nvarchar(100)
           ,@presPriod nvarchar(100)
           ,@reId numeric(18,0)
           ,@drId numeric(18,0)
					
                    )
AS
BEGIN


INSERT INTO prescriptionTab
           ( presCode 
		   ,presName
		   ,presQyt
           ,presTimeUse
           ,presSize
           ,presPriod
           ,reId
           ,drId
           
           
          )
     VALUES
           ( @presCode 
		   ,@presName
		   ,@presQyt
           ,@presTimeUse
           ,@presSize
           ,@presPriod
           ,@reId
           ,@drId)
	   end


GO
/****** Object:  StoredProcedure [dbo].[AddPreview]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create PROCEDURE [dbo].[AddPreview](
           @prCode nvarchar(100),
           @prName nvarchar(100),
           @prDate nvarchar(50),
           @prTime nvarchar(50),
        
           @prNote nvarchar(200),
           @viId numeric(18,0)
					
                    )
AS
BEGIN


INSERT INTO [dbo].[previewTab]
           ([prCode]
           ,[prName]
           ,[prDate]
           ,[prTime]
           ,[prNote]
           ,[viId])
     VALUES
           (@prCode
           ,@prName
           ,@prDate
           ,@prTime
           ,@prNote
           ,@viId)
	   end


GO
/****** Object:  StoredProcedure [dbo].[AddRecipe]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create PROCEDURE [dbo].[AddRecipe](
           @reCode nvarchar(100),
           @reDate nvarchar(50),
           @reTime nvarchar(50),
           @reNote nvarchar(200),
           @viId numeric(18,0)
					
                    )
AS
BEGIN


INSERT INTO [dbo].recipeTab
           ([reCode]
           
           ,[reDate]
           ,[reTime]
           ,[reNote]
           ,[viId])
     VALUES
           (@reCode
         
           ,@reDate
           ,@reTime
           ,@reNote
           ,@viId)
	   end


GO
/****** Object:  StoredProcedure [dbo].[AddServiecs]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





Create PROCEDURE [dbo].[AddServiecs](
           @seCode nvarchar(100),
           @seName nvarchar(100),
           @seType nvarchar(100),
           @sePrice numeric(18,0),
           @seNote nvarchar(200),
           @ACC_Num numeric(18,0)
					
                    )
AS
BEGIN




INSERT INTO [dbo].[serviecsTab]
           ([seCode]
           ,[seName]
           ,[seType]
           ,[sePrice]
           ,[seNote]
           ,[ACC_Num])
     VALUES
           (@seCode,
           @seName,
           @seType, 
           @sePrice, 
           @seNote, 
           @ACC_Num)
end




GO
/****** Object:  StoredProcedure [dbo].[AddVisit]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





Create PROCEDURE [dbo].[AddVisit](
           @viCode nvarchar(100),
           @viName nvarchar(100),
           @viDate nvarchar(50),
           @viTime nvarchar(50),
           @paId numeric(18,0),
           @apId numeric(18,0),
           @viNote nvarchar(200),
           @doId numeric(18,0)
					
                    )
AS
BEGIN



INSERT INTO [dbo].[visitTab]
           ([viCode]
           ,[viName]
           ,[viDate]
           ,[viTime]
           ,[paId]
           ,[apId]
           ,[viNote]
           ,[doId])
     VALUES
           (@viCode
           ,@viName
           ,@viDate
           ,@viTime
           ,@paId
           ,@apId
           ,@viNote
           ,@doId)
	   end


GO
/****** Object:  StoredProcedure [dbo].[DeleteDiagnoseByUpdate]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DeleteDiagnoseByUpdate]
		@diId numeric(18,0),
      
      @isDeleted bit
AS
BEGIN

	



UPDATE [dbo].diagnoseTab
   SET [isDeleted] =@isDeleted
      
	  where diId=@diId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePatient]
@paId numeric(18,0)

AS
BEGIN
	SET NOCOUNT ON;

DELETE FROM [dbo].[patientsTab]
      WHERE paId=@paId



	 
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePrescription]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DeletePrescription]
@presId numeric(18,0)

AS
BEGIN
	SET NOCOUNT ON;

DELETE FROM [dbo].prescriptionTab
      WHERE presId=@presId



	 
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePreviewByUpdate]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DeletePreviewByUpdate]
		@prId numeric(18,0),
      
      @isDeleted bit
AS
BEGIN

	



UPDATE [dbo].previewTab
   SET [isDeleted] =@isDeleted
      
	  where prId=@prId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteRecipeByUpdate]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DeleteRecipeByUpdate]
		@reId numeric(18,0),
      
      @isDeleted bit
AS
BEGIN

	



UPDATE [dbo].recipeTab
   SET [isDeleted] =@isDeleted
      
	  where reId=@reId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteVisitPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteVisitPatient]
@viId numeric(18,0)

AS
BEGIN
	SET NOCOUNT ON;

DELETE FROM [dbo].[visitTab]
      WHERE viId=@viId
	 
END
GO
/****** Object:  StoredProcedure [dbo].[getAllPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllPatient]
AS
BEGIN


SELECT [paId] as "الرقم"
      ,[paCode] as "رقم الكود"
      ,[paFname] as "الاسم"
      ,[paLname] as "اللقب"
      ,[paSex] as "الجنس"
      ,[paBrithday] as "تاريخ الميلاد"
      ,[paAge] as "العمر"
      ,[paMobile1] as "رقم الموبيل"
      ,[paMobile2] as "رقم التلفون"
      ,[paImg] as "الصورة"
      ,[paAddress] as "العنوان"
      ,[paCountry] as "الدولة"
      ,[paCity] as "المدينة"
      ,[paBloodType] as "فصيلة الدم"
      ,[paState] as "حالة المريض"
      ,[paType] as "نوع المريض"
      ,[ACC_Num] as "رقم الحساب"
  FROM [dbo].[patientsTab]
  where isDeleted !=1
End



GO
/****** Object:  StoredProcedure [dbo].[getAllServiecs]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllServiecs]

AS
BEGIN


SELECT [seId] as "الرقم"
      ,[seCode] as "رقم الكود"
      ,[seName]as "الخدمة "
      ,[seType] as "توع الخدمة"
      ,[sePrice] as "السعر"
      ,[seNote] as "ملاحظات"
      ,[ACC_Num] as "رقم الحساب"
  FROM [dbo].[serviecsTab]
  where isDeleted !=1


  
End



GO
/****** Object:  StoredProcedure [dbo].[getAllVisitPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllVisitPatient]

AS
BEGIN


SELECT  viId as "رقم الزيارة"
	  ,viCode as "رفم الكود"
	  ,viName as  "الزيارة"
	  ,viDate as "تاريخ الزبارة"
	  ,viTime as "وقت الزيارة"
	  ,doctorsTab.doId as "رقم الطبيب"
	  ,doctorsTab.doNameA as "اسم الطبيب"

	  ,viNote as "ملاحظات "
      ,patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	 
	  
	  
  FROM [dbo].[visitTab]  inner join  patientsTab  on patientsTab.paId =visitTab.paId 
  inner join doctorsTab on doctorsTab.doId =visitTab.doId
  where visitTab.isDeleted !=1
End



GO
/****** Object:  StoredProcedure [dbo].[getDiagnosePatientByVistID]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getDiagnosePatientByVistID]
@Id numeric(18,0)
AS 
BEGIN
SELECT 
         VisitTab.viId as "رقم الزيارة"
        ,diagnoseTab.diId as "رقم التشخيص"
		,diagnoseTab.diCode as "الكود"
	  , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
	   , patientsTab.[paSex] as "الجنس"
      
      , patientsTab.[paAge] as "العمر"
		,diagnoseTab.diName as "نتيجة التشخيص"
		,diagnoseTab.diDate as "تاريخ التشخيص"
		,diagnoseTab.diTime as "وقت التشخيص"
       
	   
  FROM diagnoseTab, patientsTab ,  visitTab 

  where   diagnoseTab.viId =visitTab.viId 
 
   and patientsTab.paId =visitTab.paId and  diagnoseTab.viId=@Id
   and diagnoseTab.isDeleted !=1
   end
GO
/****** Object:  StoredProcedure [dbo].[getMaxRecipeID]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[getMaxRecipeID]
AS
BEGIN
select Max(reId +1) from recipeTab


End



GO
/****** Object:  StoredProcedure [dbo].[getPreviewPatientByVistID]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPreviewPatientByVistID]
@Id numeric(18,0)
AS 
BEGIN


    




SELECT 
        previewTab.prId as "رقم المعانية"
		,previewTab.prCode as "الكود"
		,previewTab.prName as "المعاينة"
		,previewTab.prDate as "تاريخ المعاينة"
		,previewTab.prTime as "وقت المعاينة"
		,previewTab.prNote as "ملاحظات"
        ,patientsTab.[paId] as "رقم المريض"
      
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      
      , patientsTab.[paAge] as "العمر"
     
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  
	  
  FROM previewTab, patientsTab ,  visitTab 

  where   previewTab.viId =visitTab.viId 
 
   and patientsTab.paId =visitTab.paId and  previewTab.viId=@Id
   and previewTab.isDeleted !=1
   end
GO
/****** Object:  StoredProcedure [dbo].[getRecipeByRecipeId]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getRecipeByRecipeId]
@Id numeric(18,0)
AS 
BEGIN


SELECT 
    
    prescriptionTab.presCode 
	,prescriptionTab.drId   
      ,prescriptionTab.[presName] 
      ,prescriptionTab.[presQyt] 
	  ,prescriptionTab.[presSize]  
      ,prescriptionTab.[presTimeUse]  
      ,prescriptionTab.[presPriod] 
	  ,prescriptionTab.presId
	  
      
  FROM recipeTab,prescriptionTab
  where recipeTab.reId =prescriptionTab.reId
   
	
	 and recipeTab.isDeleted=0
	 and recipeTab.reId=@Id
   end
GO
/****** Object:  StoredProcedure [dbo].[getRecipeByVisitID]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getRecipeByVisitID]
@Id numeric(18,0)
AS 
BEGIN


SELECT recipeTab.[reId] as  "رفم الرشدة "
      ,recipeTab.[viId] as  "رقم الزيارة"
      ,dragTab.drName  as  "العلاج"
      ,prescriptionTab.[presName] as  " الوصفة"
      ,prescriptionTab.[presQyt] as  "الكمية"
      ,prescriptionTab.[presTimeUse] as  "طريقة الاستخدام"
      ,prescriptionTab.[presPriod] as  "فترات الاستخدام"
	  ,prescriptionTab.[presSize] as  "الحجم"
	  ,recipeTab.reCode as "كود الرشدة"
	     ,recipeTab.reDate as "التاريخ"
	  ,recipeTab.reTime  as "الوقت"
	  ,recipeTab.reNote  as "الملاحظات"
	  
      
  FROM recipeTab,prescriptionTab,dragTab,visitTab
  where recipeTab.reId =prescriptionTab.reId and
     prescriptionTab.drId =dragTab.drId 
	 and recipeTab.viId=visitTab.viId
	 and recipeTab.isDeleted=0
	 and recipeTab.viId=@Id
   end
GO
/****** Object:  StoredProcedure [dbo].[getTestResultPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[getTestResultPatient]
@ID nvarchar(100)
AS 
BEGIN
SELECT  testrRequesTab.[viId] as "رقم الزيارة"
       ,resultTestTab.rtId as "الرقم"
      ,testTab.[teName] as " الفحص"
	  ,testItemTab.[itName]  as " الاسم"
      ,testItemTab.[itSname] as "الاختصار"
	  ,testItemTab.maxValue  as "النتيجة الطبيعية"
	  
	  ,resultTestTab.[result] as "نتيجة الفحص"
      ,resultTestTab.[resultType] as "نوع النتيجة"
	  ,testrRequesTab.trDate as " التاريخ"
	  ,resultTestTab.rtNote as "ملاحظات"

FROM [dbo].[testTab], [dbo].[testItemTab], resultTestTab,testrRequesTab
  where resultTestTab.trId =testrRequesTab.trId and resultTestTab.itId =testItemTab.itId
  and testItemTab.teId =testTab.teId  
   and Convert(nvarchar,testrRequesTab.viId)=@ID
   and resultTestTab.isDeleted=0
 
End
GO
/****** Object:  StoredProcedure [dbo].[getVisitPatientByID]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getVisitPatientByID]
@ID nvarchar(100)
AS 
BEGIN


SELECT 
        patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viCode as "رفم الكود"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  ,VisitTab.viNote as "ملاحظات "
	  
	  
  FROM  patientsTab ,  visitTab 

  where    
   visitTab.isDeleted !=1 and 
   patientsTab.paId =visitTab.paId and  Convert(nvarchar,patientsTab.paId)=@ID
    
	

  
End



GO
/****** Object:  StoredProcedure [dbo].[getVisitPatientByName]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getVisitPatientByName]
@Name nvarchar(100)
AS 
BEGIN


SELECT 
        patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viCode as "رفم الكود"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  ,VisitTab.viNote as "ملاحظات "
	  
	  
  FROM  patientsTab ,  visitTab 

  where  
   visitTab.isDeleted !=1   and
   patientsTab.paId =visitTab.paId and (patientsTab.paFname=@Name )   

    


  
End



GO
/****** Object:  StoredProcedure [dbo].[SearchVisitById]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchVisitById]
@ID nvarchar(100)
AS 
BEGIN


SELECT 
        patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viCode as "رفم الكود"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  ,VisitTab.viNote as "ملاحظات "
	  
	  
  FROM  patientsTab ,  visitTab 


  where    
   patientsTab.paId =visitTab.paId and  Convert(nvarchar,visitTab.viId)=@ID
    


  
End
GO
/****** Object:  StoredProcedure [dbo].[SearchVisitPatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchVisitPatient]
@ID nvarchar(100)

AS 
BEGIN


SELECT 
        patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viCode as "رفم الكود"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  ,VisitTab.viNote as "ملاحظات "
	  
	  
  FROM  patientsTab ,  visitTab 

  where    
   patientsTab.paId =visitTab.paId and  Convert(nvarchar,visitTab.viId)=@ID
  
    


  
End



GO
/****** Object:  StoredProcedure [dbo].[SearchVisitPatientByDate]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SearchVisitPatientByDate]
@viDate nvarchar(100)

AS 
BEGIN


SELECT 
        patientsTab.[paId] as "الرقم"
      , patientsTab.[paCode] as "رقم الكود"
      , patientsTab.[paFname] as "اسم المريض"
      , patientsTab.[paLname] as "اللقب"
      , patientsTab.[paSex] as "الجنس"
      , patientsTab.[paBrithday] as "تاريخ الميلاد"
      , patientsTab.[paAge] as "العمر"
      , patientsTab.[paMobile1] as "رقم الموبيل"
      , patientsTab.[paMobile2] as "رقم التلفون"
      , patientsTab.[paImg] as "الصورة"
      , patientsTab.[paAddress] as "العنوان"
      , patientsTab.[paCountry] as "الدولة"
      , patientsTab.[paCity] as "المدينة"
      , patientsTab.[paBloodType] as "فصيلة الدم"
      , patientsTab.[paState] as "حالة المريض"
      , patientsTab.[paType] as "نوع المريض"
      , patientsTab.[ACC_Num] as "رقم الحساب"
	  , VisitTab.viId as "رقم الزيارة"
	  ,VisitTab.viCode as "رفم الكود"
	  ,VisitTab.viName as  "الزيارة"
	  ,VisitTab.viDate as "تاريخ الزبارة"
	  ,VisitTab.viTime as "وقت الزيارة"
	  ,VisitTab.viNote as "ملاحظات "
	  
	  
  FROM  patientsTab ,  visitTab 

  where    
   patientsTab.paId =visitTab.paId and  visitTab.viDate=@viDate
  
    


  
End



GO
/****** Object:  StoredProcedure [dbo].[UpdateDiagnoses]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdateDiagnoses]
		@diId numeric(18,0),
       @diCode  nvarchar(100)
	   ,@diName nvarchar(100) 
      ,@diDate nvarchar(50)
      ,@diTime nvarchar(50)
    
      
      ,@viId numeric(18,0)
AS
BEGIN

	



UPDATE [dbo].diagnoseTab
   SET [diCode] =@diCode
      ,[diName] =@diName
      ,[diDate] = @diDate
      ,[diTime] = @diTime
      
      ,[viId] = @viId
	  where diId=@diId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[updatePatient]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatePatient]
@paId numeric(18,0),
@paCode nvarchar(100),
@paFname nvarchar(100),
@paLname nvarchar(100),
@paSex nvarchar(50),
@paBrithday nvarchar(50),
@paAge int,
@paMobile1 int,
@paMobile2 int,
@paImg image ,
@paAddress nvarchar(100),
@paCountry nvarchar(100),
@paCity nvarchar(100),
@paBloodType nvarchar(50),
@paState  nvarchar(100),
@paType nvarchar(100),
@ACC_Num numeric(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	

UPDATE [dbo].[patientsTab]
   SET [paCode] = @paCode
      ,[paFname] = @paFname 
      ,[paLname] = @paLname 
      ,[paSex] = @paSex
      ,[paBrithday] = @paBrithday 
      ,[paAge] = @paAge
      ,[paMobile1] = @paMobile1 
      ,[paMobile2] = @paMobile2
      ,[paImg] = @paImg
      ,[paAddress] = @paAddress 
      ,[paCountry] = @paCountry
      ,[paCity] = @paCity
      ,[paBloodType] = @paBloodType
      ,[paState] = @paState 
      ,[paType] = @paType 
      ,[ACC_Num] = @ACC_Num
 WHERE paId=@paId;
	 
END

GO
/****** Object:  StoredProcedure [dbo].[UpdatePrescription]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePrescription]
		@presId numeric(18,0),
       @presCode  nvarchar(100)
       ,@presName nvarchar(100)
	   
      ,@presQyt nvarchar(100)
      ,@presTimeUse nvarchar(100)
    
      ,@presSize nvarchar(100)
	  ,@presPriod nvarchar(100)
	  ,@reId numeric(18,0),
      @drId numeric(18,0)

AS
BEGIN

	



UPDATE [dbo].prescriptionTab
   SET [presCode] =@presCode
      ,[presName] = @presName
      ,presQyt = @presQyt
	  ,presTimeUse=@presTimeUse
      ,presSize = @presSize
	  ,presPriod =@presPriod
	  ,reId=@reId
      ,drId = @drId

	  where presId=@presId

END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePreview]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePreview]
		@prId numeric(18,0),
       @prCode  nvarchar(100)
      ,@prName nvarchar(100)
      ,@prDate nvarchar(50)
      ,@prTime nvarchar(50)
    
      ,@prNote nvarchar(200)
      ,@viId numeric(18,0)
AS
BEGIN

	



UPDATE [dbo].previewTab
   SET [prCode] =@prCode
      ,[prName] =@prName
      ,[prDate] = @prDate
      ,[prTime] = @prTime
      ,[prNote] = @prNote
      ,[viId] = @viId
	  where prId=@prId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRecipe]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateRecipe]
		@reId numeric(18,0),
       @reCode  nvarchar(100)
     
      ,@reDate nvarchar(50)
      ,@reTime nvarchar(50)
    
      ,@reNote nvarchar(200)
      ,@viId numeric(18,0)
AS
BEGIN

	



UPDATE [dbo].recipeTab
   SET [reCode] =@reCode
    
      ,[reDate] = @reDate
      ,[reTime] = @reTime
      ,[reNote] = @reNote
      ,[viId] = @viId
	  where reId=@reId

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateServiecs]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateServiecs]
		  @seId numeric(18,0),
          @seCode nvarchar(100),
           @seName nvarchar(100),
           @seType nvarchar(100),
           @sePrice numeric(18,0),
           @seNote nvarchar(200),
           @ACC_Num numeric(18,0)
AS
BEGIN

	



UPDATE [dbo].serviecsTab
   SET seCode =@seCode,
      [seName] =@seName
      ,[seType] = @seType
      ,[sePrice] = @sePrice
      ,[seNote] = @seNote
      ,[ACC_Num] = @ACC_Num
      
	  where seId=@seId
  
	 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateVisit]    Script Date: 30/09/2020 06:36:27 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVisit]
		@viId numeric(18,0),
       @viCode  nvarchar(100)
      ,@viName nvarchar(100)
      ,@viDate nvarchar(50)
      ,@viTime nvarchar(50)
      ,@paId numeric(18,0)
      ,@apId numeric(18,0) null
      ,@viNote nvarchar(200)
      ,@doId numeric(18,0)
AS
BEGIN

	



UPDATE [dbo].[visitTab]
   SET [viCode] =@viCode
      ,[viName] =@viName
      ,[viDate] = @viDate
      ,[viTime] = @viTime
      ,[paId] = @paId
      ,[apId] = @apId
      ,[viNote] = @viNote
      ,[doId] = @doId
	  where viId=@viId
  
	 
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'visitTab', @level2type=N'COLUMN',@level2name=N'isDeleted'
GO
USE [master]
GO
ALTER DATABASE [MedicalCenterDb] SET  READ_WRITE 
GO
