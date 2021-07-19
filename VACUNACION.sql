USE [VACUNADOS2021]
GO
/****** Object:  Table [dbo].[PERSONA_VACUNA]    Script Date: 7/15/2021 11:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONA_VACUNA](
	[CEDULA_PERSONA] [nvarchar](15) NOT NULL,
	[ID_VACUNA] [varchar](50) NOT NULL,
	[DOSISVACUNA] [int] NOT NULL,
	[FECHAVACUNA] [datetime] NULL,
 CONSTRAINT [PK_VACUNA_PERSONA] PRIMARY KEY CLUSTERED 
(
	[CEDULA_PERSONA] ASC,
	[ID_VACUNA] ASC,
	[DOSISVACUNA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 7/15/2021 11:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CEDULA] [nvarchar](15) NULL,
	[NOMBRE] [varchar](50) NULL,
	[APELLIDO] [varchar](50) NULL,
	[TELEFONO] [varchar](10) NULL,
	[FECHANACIMIENTO] [datetime] NULL,
	[PROVINCIAID] [int] NULL,
	[SIGNOZODID] [int] NULL,
 CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_PERSONA] UNIQUE NONCLUSTERED 
(
	[CEDULA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 7/15/2021 11:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_PROVINCIA] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_PROVINCIA] UNIQUE NONCLUSTERED 
(
	[ID_PROVINCIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SIGNO_ZODIACAL]    Script Date: 7/15/2021 11:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SIGNO_ZODIACAL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_SIGNO_Zodiacal] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
 CONSTRAINT [PK_SIGNO_ZODIACAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_SIGNO_ZODIACAL] UNIQUE NONCLUSTERED 
(
	[ID_SIGNO_Zodiacal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VACUNAS]    Script Date: 7/15/2021 11:54:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VACUNAS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MARCA] [varchar](50) NULL,
	[DOSIS] [int] NULL,
 CONSTRAINT [PK_VACUNAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_VACUNAS] UNIQUE NONCLUSTERED 
(
	[MARCA] ASC,
	[DOSIS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PERSONA_VACUNA]  WITH CHECK ADD  CONSTRAINT [FK_PERSONA_VACUNA] FOREIGN KEY([CEDULA_PERSONA])
REFERENCES [dbo].[PERSONAS] ([CEDULA])
GO
ALTER TABLE [dbo].[PERSONA_VACUNA] CHECK CONSTRAINT [FK_PERSONA_VACUNA]
GO
ALTER TABLE [dbo].[PERSONA_VACUNA]  WITH CHECK ADD  CONSTRAINT [FK_VACUNAS_PERSONA] FOREIGN KEY([ID_VACUNA], [DOSISVACUNA])
REFERENCES [dbo].[VACUNAS] ([MARCA], [DOSIS])
GO
ALTER TABLE [dbo].[PERSONA_VACUNA] CHECK CONSTRAINT [FK_VACUNAS_PERSONA]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD  CONSTRAINT [FK_PROVINCIA_PERSONA] FOREIGN KEY([PROVINCIAID])
REFERENCES [dbo].[PROVINCIAS] ([ID_PROVINCIA])
GO
ALTER TABLE [dbo].[PERSONAS] CHECK CONSTRAINT [FK_PROVINCIA_PERSONA]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD  CONSTRAINT [FK_SignoZodiacal_PERSONA] FOREIGN KEY([SIGNOZODID])
REFERENCES [dbo].[SIGNO_ZODIACAL] ([ID_SIGNO_Zodiacal])
GO
ALTER TABLE [dbo].[PERSONAS] CHECK CONSTRAINT [FK_SignoZodiacal_PERSONA]
GO
