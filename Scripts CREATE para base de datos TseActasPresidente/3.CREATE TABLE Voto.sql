USE TseActasPresidente
GO

/****** Object:  Table [dbo].[Voto]    Script Date: 12/1/2017 12:47:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Voto](
	[CodCandidato] [int] NOT NULL,
	[NomCandidato] [varchar](500) NOT NULL,
	[IdentidadCandidato] [varchar](500) NOT NULL,
	[CodPartido] [int] NOT NULL,
	[NomPartido] [varchar](500) NOT NULL,
	[NumVotos] [int] NOT NULL,
	[NumPosicion] [int] NOT NULL,
	[CodActa] [int] NULL,
	[IdVoto] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Voto__12641620898CB095] PRIMARY KEY CLUSTERED 
(
	[IdVoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


