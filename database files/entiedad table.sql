USE [SellPoint]
GO

/****** Object:  Table [dbo].[Entidades]    Script Date: 8/10/2022 1:09:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Entidades](
	[IdEntidad] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Direccion] [text] NOT NULL,
	[Localidad] [nvarchar](40) NOT NULL,
	[TipoEntidad] [nvarchar](8) NULL,
	[TipoDocumento] [nvarchar](9) NULL,
	[NumeroDocumento] [nvarchar](60) NULL,
	[Teléfonos] [nvarchar](60) NOT NULL,
	[URLPaginaWeb] [nvarchar](120) NULL,
	[URLFacebook] [nvarchar](120) NULL,
	[URLInstagram] [nvarchar](120) NULL,
	[URLTwitter] [nvarchar](120) NULL,
	[URLTikTok] [nvarchar](120) NULL,
	[CodigoPostal] [nvarchar](10) NULL,
	[CoordenadasGPS] [nvarchar](255) NULL,
	[LimiteCredito] [int] NULL,
	[UserNameEntidad] [nvarchar](60) NOT NULL,
	[PassworEntidad] [nvarchar](30) NOT NULL,
	[RolUserEntidad] [nvarchar](10) NULL,
	[Comentario] [text] NULL,
	[Estatus] [nvarchar](10) NULL,
	[NoEliminable] [bit] NULL,
	[FechaRegistro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ('JURIDICA') FOR [TipoEntidad]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ('RNC') FOR [TipoDocumento]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ((0)) FOR [LimiteCredito]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ('USER') FOR [RolUserEntidad]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ('ACTIVA') FOR [Estatus]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT ((0)) FOR [NoEliminable]
GO

ALTER TABLE [dbo].[Entidades] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO

ALTER TABLE [dbo].[Entidades]  WITH CHECK ADD FOREIGN KEY([CodigoPostal])
REFERENCES [dbo].[CodigoPostal] ([ID])
GO

