/****** Object:  Table [dbo].[Countries]    Script Date: 16/07/2016 10:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Country Code] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[IncomeGroup] [nvarchar](max) NULL,
	[SpecialNotes] [nvarchar](max) NULL,
	[TableName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Data]    Script Date: 16/07/2016 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Data](
	[Country Name] [nvarchar](max) NULL,
	[Country Code] [nvarchar](max) NULL,
	[Indicator Name] [nvarchar](max) NULL,
	[Indicator Code] [nvarchar](max) NULL,
	[1960] [nvarchar](max) NULL,
	[1961] [float] NULL,
	[1962] [float] NULL,
	[1963] [float] NULL,
	[1964] [float] NULL,
	[1965] [float] NULL,
	[1966] [float] NULL,
	[1967] [float] NULL,
	[1968] [float] NULL,
	[1969] [float] NULL,
	[1970] [float] NULL,
	[1971] [float] NULL,
	[1972] [float] NULL,
	[1973] [float] NULL,
	[1974] [float] NULL,
	[1975] [float] NULL,
	[1976] [float] NULL,
	[1977] [float] NULL,
	[1978] [float] NULL,
	[1979] [float] NULL,
	[1980] [float] NULL,
	[1981] [float] NULL,
	[1982] [float] NULL,
	[1983] [float] NULL,
	[1984] [float] NULL,
	[1985] [float] NULL,
	[1986] [float] NULL,
	[1987] [float] NULL,
	[1988] [float] NULL,
	[1989] [float] NULL,
	[1990] [float] NULL,
	[1991] [float] NULL,
	[1992] [float] NULL,
	[1993] [float] NULL,
	[1994] [float] NULL,
	[1995] [float] NULL,
	[1996] [float] NULL,
	[1997] [float] NULL,
	[1998] [float] NULL,
	[1999] [float] NULL,
	[2000] [float] NULL,
	[2001] [float] NULL,
	[2002] [float] NULL,
	[2003] [float] NULL,
	[2004] [float] NULL,
	[2005] [float] NULL,
	[2006] [float] NULL,
	[2007] [float] NULL,
	[2008] [float] NULL,
	[2009] [float] NULL,
	[2010] [float] NULL,
	[2011] [float] NULL,
	[2012] [float] NULL,
	[2013] [float] NULL,
	[2014] [nvarchar](max) NULL,
	[2015] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Indicators]    Script Date: 16/07/2016 10:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Indicators](
	[INDICATOR_CODE] [nvarchar](max) NULL,
	[INDICATOR_NAME] [nvarchar](max) NULL,
	[SOURCE_NOTE] [nvarchar](max) NOT NULL,
	[SOURCE_ORGANIZATION] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
