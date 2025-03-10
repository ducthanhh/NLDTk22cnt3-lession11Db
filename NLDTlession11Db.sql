USE [NLDTk22cnt3Lession11Db]
GO
/****** Object:  Table [dbo].[NLDTCategory]    Script Date: 04/07/2024 10:18:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NLDTCategory](
	[NLDTid] [int] NOT NULL,
	[NLDTCreateName] [nvarchar](50) NULL,
	[NLDTStatus] [bit] NULL,
 CONSTRAINT [PK_NLDTCategory] PRIMARY KEY CLUSTERED 
(
	[NLDTid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NLDTProduct]    Script Date: 04/07/2024 10:18:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NLDTProduct](
	[NLDTid] [nvarchar](50) NOT NULL,
	[NLDTProName] [nvarchar](50) NULL,
	[NLDTQty] [int] NULL,
	[NLDTPrice] [float] NULL,
	[NLDTCateid] [int] NULL,
	[NLDTActive] [bit] NULL,
 CONSTRAINT [PK_NLDTProduct] PRIMARY KEY CLUSTERED 
(
	[NLDTid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NLDTCategory] ([NLDTid], [NLDTCreateName], [NLDTStatus]) VALUES (1, N'221090065', 1)
INSERT [dbo].[NLDTCategory] ([NLDTid], [NLDTCreateName], [NLDTStatus]) VALUES (2, N'phone', 0)
GO
INSERT [dbo].[NLDTProduct] ([NLDTid], [NLDTProName], [NLDTQty], [NLDTPrice], [NLDTCateid], [NLDTActive]) VALUES (N'002', N'samsung', 10, 200, 1, 1)
INSERT [dbo].[NLDTProduct] ([NLDTid], [NLDTProName], [NLDTQty], [NLDTPrice], [NLDTCateid], [NLDTActive]) VALUES (N'221090065', N'nguyen le duc thanh ', 10, 100, 1, 1)
GO
