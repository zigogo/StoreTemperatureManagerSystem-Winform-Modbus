USE [master]
GO
/****** Object:  Database [stmsbase]    Script Date: 2024/1/17 20:44:59 ******/
CREATE DATABASE [stmsbase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stmsbase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\stmsbase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'stmsbase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\stmsbase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [stmsbase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stmsbase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stmsbase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stmsbase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stmsbase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stmsbase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stmsbase] SET ARITHABORT OFF 
GO
ALTER DATABASE [stmsbase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [stmsbase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stmsbase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stmsbase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stmsbase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stmsbase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stmsbase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stmsbase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stmsbase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stmsbase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [stmsbase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stmsbase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stmsbase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stmsbase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stmsbase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stmsbase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stmsbase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stmsbase] SET RECOVERY FULL 
GO
ALTER DATABASE [stmsbase] SET  MULTI_USER 
GO
ALTER DATABASE [stmsbase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stmsbase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stmsbase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stmsbase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [stmsbase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [stmsbase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'stmsbase', N'ON'
GO
ALTER DATABASE [stmsbase] SET QUERY_STORE = ON
GO
ALTER DATABASE [stmsbase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [stmsbase]
GO
/****** Object:  User [root]    Script Date: 2024/1/17 20:44:59 ******/
CREATE USER [root] FOR LOGIN [root] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[productstoreinfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productstoreinfos](
	[ProStoreId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[StoreId] [int] NOT NULL,
	[SRegionId] [int] NOT NULL,
	[ProductCount] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__products__60B1D5EF2F011B74] PRIMARY KEY CLUSTERED 
(
	[ProStoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[storeinfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[storeinfos](
	[StoreId] [int] IDENTITY(1,1) NOT NULL,
	[StoreName] [varchar](20) NOT NULL,
	[StoreNo] [varchar](20) NULL,
	[RegionCount] [int] NOT NULL,
	[Remark] [varchar](500) NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__storeinf__3B82F101C1EA9C39] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[storeregioninfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[storeregioninfos](
	[SRegionId] [int] IDENTITY(1,1) NOT NULL,
	[SRegionName] [varchar](20) NOT NULL,
	[SregionNo] [varchar](20) NULL,
	[StoreId] [int] NOT NULL,
	[SRTemperature] [decimal](18, 2) NULL,
	[AllowLowTemperature] [decimal](18, 2) NULL,
	[AllowHighTemperature] [decimal](18, 2) NULL,
	[TemperState] [int] NOT NULL,
	[Remark] [varchar](500) NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__storereg__E7846256FF2003EA] PRIMARY KEY CLUSTERED 
(
	[SRegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productinfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productinfos](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](20) NOT NULL,
	[ProductNo] [varchar](20) NULL,
	[FitLowTemperature] [decimal](18, 2) NOT NULL,
	[FitHighTemperature] [decimal](18, 2) NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__producti__B40CC6CD40003E36] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewProductStoreInfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewProductStoreInfos]
AS
SELECT dbo.productstoreinfos.ProStoreId, dbo.productstoreinfos.ProductId, dbo.productstoreinfos.SRegionId, dbo.productstoreinfos.StoreId, dbo.productstoreinfos.ProductCount, dbo.productstoreinfos.IsDeleted, 
         dbo.productinfos.ProductName, dbo.storeregioninfos.SRegionName, dbo.storeinfos.StoreName
FROM  dbo.productinfos INNER JOIN
         dbo.productstoreinfos ON dbo.productinfos.ProductId = dbo.productstoreinfos.ProductId INNER JOIN
         dbo.storeinfos ON dbo.productstoreinfos.StoreId = dbo.storeinfos.StoreId INNER JOIN
         dbo.storeregioninfos ON dbo.productstoreinfos.SRegionId = dbo.storeregioninfos.SRegionId
GO
/****** Object:  View [dbo].[ViewSRegionTemperInfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewSRegionTemperInfos]
AS
SELECT t.StoreId, t.SRegionId, t.TotalCount, t.SRegionName, sr1.SRTemperature, sr1.AllowLowTemperature, sr1.AllowHighTemperature, sr1.TemperState
FROM  (SELECT s.StoreId, sr.SRegionId, SUM(ps.ProductCount) AS TotalCount, sr.SRegionName
        FROM   dbo.storeregioninfos AS sr INNER JOIN
                 dbo.storeinfos AS s ON sr.StoreId = s.StoreId LEFT OUTER JOIN
                 dbo.productstoreinfos AS ps ON ps.SRegionId = sr.SRegionId
        WHERE  (sr.IsDeleted = 0) AND (s.IsDeleted = 0) AND (ps.IsDeleted = 0)
        GROUP BY s.StoreId, sr.SRegionId, sr.SRegionName) AS t INNER JOIN
         dbo.storeregioninfos AS sr1 ON sr1.SRegionId = t.SRegionId
GO
/****** Object:  View [dbo].[View_SRegionTemperInfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SRegionTemperInfos]
AS
SELECT t.StoreId, t.SRegionId, t.TotalCount, t.SRegionName, sr1.SRTemperature, sr1.AllowLowTemperature, sr1.AllowHighTemperature, sr1.TemperState
FROM  (SELECT s.StoreId, sr.SRegionId, SUM(ps.ProductCount) AS TotalCount, sr.SRegionName
        FROM   dbo.storeregioninfos AS sr INNER JOIN
                 dbo.storeinfos AS s ON sr.StoreId = s.StoreId LEFT OUTER JOIN
                 dbo.productstoreinfos AS ps ON ps.SRegionId = sr.SRegionId
        WHERE  (sr.IsDeleted = 0) AND (s.IsDeleted = 0) AND (ps.IsDeleted = 0)
        GROUP BY s.StoreId, sr.SRegionId, sr.SRegionName) AS t INNER JOIN
         dbo.storeregioninfos AS sr1 ON sr1.SRegionId = t.SRegionId
GO
/****** Object:  View [dbo].[ViewStoreRegionInfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewStoreRegionInfos]
AS
SELECT  dbo.storeregioninfos.SRegionId, dbo.storeregioninfos.SregionNo, dbo.storeregioninfos.SRegionName, dbo.storeregioninfos.StoreId, 
               dbo.storeinfos.StoreName, dbo.storeregioninfos.SRTemperature, dbo.storeregioninfos.AllowLowTemperature, 
               dbo.storeregioninfos.AllowHighTemperature, dbo.storeregioninfos.TemperState, 
               (CASE dbo.storeregioninfos.TemperState WHEN 1 THEN '正常' WHEN 0 THEN '低温' WHEN 2 THEN '高温' ELSE ' ' END) AS TemperStateText, 
               dbo.storeregioninfos.Remark, dbo.storeregioninfos.IsDeleted
FROM     dbo.storeinfos INNER JOIN
               dbo.storeregioninfos ON dbo.storeinfos.StoreId = dbo.storeregioninfos.StoreId
GO
/****** Object:  Table [dbo].[productinstorerecordinfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productinstorerecordinfos](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[SRegionId] [int] NOT NULL,
	[ProductCount] [int] NOT NULL,
	[InStoreTime] [varchar](255) NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__producti__FBDF78E9AF064586] PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userinfos]    Script Date: 2024/1/17 20:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userinfos](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[UserPwd] [varchar](20) NOT NULL,
	[UserState] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK__userinfo__1788CC4CC62A194D] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[productinfos] ADD  CONSTRAINT [DF__productin__Produ__25DB9BFC]  DEFAULT (NULL) FOR [ProductNo]
GO
ALTER TABLE [dbo].[productinfos] ADD  CONSTRAINT [DF__productin__IsDel__26CFC035]  DEFAULT ('0') FOR [IsDeleted]
GO
ALTER TABLE [dbo].[productinstorerecordinfos] ADD  CONSTRAINT [DF__productin__Produ__29AC2CE0]  DEFAULT ('0') FOR [ProductCount]
GO
ALTER TABLE [dbo].[productinstorerecordinfos] ADD  CONSTRAINT [DF__productin__InSto__2AA05119]  DEFAULT (getdate()) FOR [InStoreTime]
GO
ALTER TABLE [dbo].[productinstorerecordinfos] ADD  CONSTRAINT [DF__productin__IsDel__2B947552]  DEFAULT ('0') FOR [IsDeleted]
GO
ALTER TABLE [dbo].[productstoreinfos] ADD  CONSTRAINT [DF__productst__Produ__2E70E1FD]  DEFAULT ('0') FOR [ProductCount]
GO
ALTER TABLE [dbo].[productstoreinfos] ADD  CONSTRAINT [DF__productst__IsDel__2F650636]  DEFAULT ('0') FOR [IsDeleted]
GO
ALTER TABLE [dbo].[storeinfos] ADD  CONSTRAINT [DF__storeinfo__Store__324172E1]  DEFAULT (NULL) FOR [StoreNo]
GO
ALTER TABLE [dbo].[storeinfos] ADD  CONSTRAINT [DF__storeinfo__Regio__3335971A]  DEFAULT ('0') FOR [RegionCount]
GO
ALTER TABLE [dbo].[storeinfos] ADD  CONSTRAINT [DF__storeinfo__Remar__3429BB53]  DEFAULT (NULL) FOR [Remark]
GO
ALTER TABLE [dbo].[storeinfos] ADD  CONSTRAINT [DF__storeinfo__IsDel__351DDF8C]  DEFAULT ('0') FOR [IsDeleted]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__Sregi__37FA4C37]  DEFAULT (NULL) FOR [SregionNo]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__SRTem__38EE7070]  DEFAULT (NULL) FOR [SRTemperature]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__Allow__39E294A9]  DEFAULT (NULL) FOR [AllowLowTemperature]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__Allow__3AD6B8E2]  DEFAULT (NULL) FOR [AllowHighTemperature]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__Tempe__3BCADD1B]  DEFAULT ('1') FOR [TemperState]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__Remar__3CBF0154]  DEFAULT (NULL) FOR [Remark]
GO
ALTER TABLE [dbo].[storeregioninfos] ADD  CONSTRAINT [DF__storeregi__IsDel__3DB3258D]  DEFAULT ('0') FOR [IsDeleted]
GO
ALTER TABLE [dbo].[userinfos] ADD  CONSTRAINT [DF__userinfos__UserS__408F9238]  DEFAULT ('1') FOR [UserState]
GO
ALTER TABLE [dbo].[userinfos] ADD  CONSTRAINT [DF__userinfos__IsDel__4183B671]  DEFAULT ('0') FOR [IsDeleted]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[27] 2[27] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "sr1"
            Begin Extent = 
               Top = 13
               Left = 853
               Bottom = 283
               Right = 1272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 13
               Left = 86
               Bottom = 283
               Right = 392
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1273
         Width = 1327
         Width = 1780
         Width = 1620
         Width = 1860
         Width = 2120
         Width = 2520
         Width = 1267
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1173
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1353
         SortOrder = 1413
         GroupBy = 1353
         Filter = 1353
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SRegionTemperInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SRegionTemperInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "productinfos"
            Begin Extent = 
               Top = 13
               Left = 86
               Bottom = 283
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "storeinfos"
            Begin Extent = 
               Top = 13
               Left = 940
               Bottom = 283
               Right = 1232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "storeregioninfos"
            Begin Extent = 
               Top = 286
               Left = 86
               Bottom = 556
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "productstoreinfos"
            Begin Extent = 
               Top = 13
               Left = 551
               Bottom = 389
               Right = 929
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewProductStoreInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewProductStoreInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[13] 2[41] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "sr1"
            Begin Extent = 
               Top = 13
               Left = 853
               Bottom = 283
               Right = 1272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 13
               Left = 86
               Bottom = 283
               Right = 392
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1273
         Width = 1327
         Width = 1780
         Width = 1620
         Width = 1860
         Width = 2120
         Width = 2520
         Width = 1267
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1173
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1353
         SortOrder = 1413
         GroupBy = 1353
         Filter = 1353
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSRegionTemperInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewSRegionTemperInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[41] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "storeinfos"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 324
               Right = 274
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "storeregioninfos"
            Begin Extent = 
               Top = 9
               Left = 331
               Bottom = 436
               Right = 814
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2560
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewStoreRegionInfos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewStoreRegionInfos'
GO
USE [master]
GO
ALTER DATABASE [stmsbase] SET  READ_WRITE 
GO
