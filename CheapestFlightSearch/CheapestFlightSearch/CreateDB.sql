USE [CheapestFlightsDB]
GO

/****** Object:  Table [dbo].[Airports]    Script Date: 7.4.2022. 11:27:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Airports](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IATA] [nchar](10) NULL,
	[ICAO] [nchar](10) NULL,
	[AirportName] [nvarchar](50) NULL,
	[AirportLocation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Airports] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

