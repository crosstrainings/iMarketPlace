USE [iMarketPlaceDataBase]
GO
/****** Object:  Table [dbo].[Advertisements]    Script Date: 10/26/2019 2:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertisements](
	[Title] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Category] [int] NULL,
	[Image] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Advertisements] ([Title], [Price], [Category], [Image]) VALUES (N'First Title', N'1000', 0, N'https://www.91-img.com/pictures/133710-v6-realme-c2-mobile-phone-large-1.jpg')
INSERT [dbo].[Advertisements] ([Title], [Price], [Category], [Image]) VALUES (N'Totam mollit fugit ', N'104', 4, N'https://www.91-img.com/pictures/133710-v6-realme-c2-mobile-phone-large-1.jpg')
INSERT [dbo].[Advertisements] ([Title], [Price], [Category], [Image]) VALUES (N'Consectetur nobis co', N'618', 3, N'https://www.91-img.com/pictures/128557-v5-honor-9n-mobile-phone-large-1.jpg')
