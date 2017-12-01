USE TseActasPresidente
GO

/****** Object:  Table [dbo].[Acta]    Script Date: 12/1/2017 12:46:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Acta](
	[CodActa] [int] NOT NULL,
	[NumNivel] [int] NOT NULL,
	[NomNivel] [varchar](500) NOT NULL,
	[CodMER] [int] NOT NULL,
	[CodDepartamento] [int] NOT NULL,
	[CodMunicipio] [int] NOT NULL,
	[NomDepartamento] [varchar](500) NOT NULL,
	[NomMunicipio] [varchar](500) NOT NULL,
	[CodCentroVotacion] [int] NOT NULL,
	[NomCentroVotacion] [varchar](500) NOT NULL,
	[CodEstado] [int] NOT NULL,
	[NomEstado] [varchar](500) NOT NULL,
	[NumVotosValidos] [int] NOT NULL,
	[NumVotosBlancos] [int] NOT NULL,
	[NumVotosNulos] [int] NOT NULL,
	[NumVotosTotal] [int] NOT NULL,
	[NumPapeletasRecibidas] [int] NOT NULL,
	[NumPapeletasSobrantes] [int] NOT NULL,
	[NumPapeletasUtilizadas] [int] NOT NULL,
	[CodBarra] [varchar](500) NOT NULL,
	[Url] [varchar](500) NOT NULL,
 CONSTRAINT [PK__Acta__F55C323E950AB9DB] PRIMARY KEY CLUSTERED 
(
	[CodActa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


