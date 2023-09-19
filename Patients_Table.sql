USE [thewebdoctor]
GO

/****** Object:  Table [dbo].[Patients]    Script Date: 19/09/2023 6:36:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[Adrress] [nvarchar](max) NULL,
	[PatientType] [nvarchar](max) NULL,
	[bednum] [nvarchar](max) NULL,
	[diagnosis] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patients_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


