USE [Solar]
GO
/****** Object:  Table [dbo].[Planet]    Script Date: 05/06/2017 02:01:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Planet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Mass] [float] NULL,
	[MassUnit] [nvarchar](50) NULL,
	[SolarDistance] [float] NULL,
	[SolarDistanceUnit] [nvarchar](50) NULL,
	[Diameter] [float] NULL,
	[DiameterUnit] [nvarchar](50) NULL,
	[NoOf Moons] [int] NULL,
	[ImageUrl] [nvarchar](1024) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Planet] ON 

INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (1, N'Mercury', 3.3011, N'x 10^23 kg', 57910000, N'km', 4800, N'km', 0, N'https://tse3.mm.bing.net/th?id=OIP.3g4L5SnuUUqHW9lrtVFr_wEsEs&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (2, N'Venus', 4.8675, N'x 10^24 kg', 108939000, N'km', 12100, N'km', 0, N'https://sp.yimg.com/ib/th?id=OIP.DcLn9ex94CAq5UcB5UfFwQEsEs&pid=15.1&rs=1&c=1&qlt=95&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (3, N'Earth', 5.9736, N'x 10^24 kg', 150000000, N'km', 12756, N'km', 1, N'https://tse3.mm.bing.net/th?id=OIP.ZB-A_MLjR0mF590zquFezAEsEs&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (4, N'Mars', 6.4169, N'x 10^23 kg', 228000000, N'km', 6792, N'km', 2, N'https://tse3.mm.bing.net/th?id=OIP.RoiV5xdoglFhuH1gqMoBEQEsEp&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (5, N'Jupiter', 1.9, N'x 10^27 kg', 778547200, N'km', 142984, N'km', 68, N'https://tse4.mm.bing.net/th?id=OIP.3POXj9kBSXGxvUn96uI8gQENEs&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (6, N'Saturn', 5.6, N'x 10^26 kg', 1433449370, N'km', 120536, N'km', 150, N'https://tse2.mm.bing.net/th?id=OIP.r-7nbqKRZ7wuDybxDfou6AEsDI&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (7, N'Uranus', 8.68, N'x 10^25 kg', 2876679082, N'km', 51118, N'km', 27, N'https://tse3.mm.bing.net/th?id=OIP.PKyvCfsJ5JyNoDFVk5fOPgEsDh&pid=15.1&P=0&w=300&h=300')
INSERT [dbo].[Planet] ([Id], [Name], [Mass], [MassUnit], [SolarDistance], [SolarDistanceUnit], [Diameter], [DiameterUnit], [NoOf Moons], [ImageUrl]) VALUES (8, N'Neptune', 1.02, N'x 10^26 Kg', 4503443661, N'km', 49500, N'km', 14, N'https://tse4.mm.bing.net/th?id=OIP.WCJ8qtS2d3RYwafhLLpkaQEsEs&pid=15.1&P=0&w=300&h=300')
SET IDENTITY_INSERT [dbo].[Planet] OFF
