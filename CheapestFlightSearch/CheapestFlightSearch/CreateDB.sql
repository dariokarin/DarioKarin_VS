USE [CheapestFlightsDB]
GO

/****** Object:  Table [dbo].[Airports]    Script Date: 10.4.2022. 13:58:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Airports](
	[IATA] [nvarchar](50) NULL,
	[ICAO] [nvarchar](50) NULL,
	[AirportName] [nvarchar](500) NULL,
	[AirportLocation] [nvarchar](500) NULL
) ON [PRIMARY]
GO


USE [CheapestFlightsDB]
GO

/****** Object:  Table [dbo].[SearchingHistory]    Script Date: 10.4.2022. 13:58:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SearchingHistory](
	[DepartureAirport] [nvarchar](50) NULL,
	[ArrivalAirport] [nvarchar](50) NULL,
	[DepartureDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[Currency] [int] NOT NULL
) ON [PRIMARY]
GO