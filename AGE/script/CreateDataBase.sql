USE [GestioEnfant]
GO

/****** Object: Table [dbo].[Membre] Script Date: 13/09/2023 15:19:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Membre](
	[Id] [int] NOT NULL IDENTITY,
	[NumDossier] [varchar](255) NOT NULL,
	[Nom] [varchar](255) NOT NULL,
	[Prenom] [varchar](255) NOT NULL,
	[DateNaissance] [date] NOT NULL,
	[IGroupe] [int] NOT NULL,
	[IdBus] [int] NOT NULL,
 CONSTRAINT [PK_MEMBRE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Membre]  WITH CHECK ADD  CONSTRAINT [Membre_fk0] FOREIGN KEY([IGroupe])
REFERENCES [dbo].[Groupe] ([IdGroupe])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Membre] CHECK CONSTRAINT [Membre_fk0]
GO

ALTER TABLE [dbo].[Membre]  WITH CHECK ADD  CONSTRAINT [Membre_fk1] FOREIGN KEY([IdBus])
REFERENCES [dbo].[Bus] ([IdBus])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Membre] CHECK CONSTRAINT [Membre_fk1]
GO

/****** Object: Table [dbo].[Liste] Script Date: 13/09/2023 15:30:00 ******/
CREATE TABLE [dbo].[Liste](
	[IdListe] [int] NOT NULL IDENTITY,
	[NomListe] [varchar](255) NOT NULL,
 CONSTRAINT [PK_LISTE] PRIMARY KEY CLUSTERED 
(
	[IdListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Ajoutez une table de liaison MembreListe pour gérer les associations entre membres et listes ******/
CREATE TABLE [dbo].[MembreListe](
	[IdMembreListe] [int] NOT NULL IDENTITY,
	[IdMembre] [int] NOT NULL,
	[IdListe] [int] NOT NULL,
 CONSTRAINT [PK_MEMBRELISTE] PRIMARY KEY CLUSTERED 
(
	[IdMembreListe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[MembreListe]  WITH CHECK ADD  CONSTRAINT [MembreListe_fk0] FOREIGN KEY([IdMembre])
REFERENCES [dbo].[Membre] ([Id])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[MembreListe] CHECK CONSTRAINT [MembreListe_fk0]
GO

ALTER TABLE [dbo].[MembreListe]  WITH CHECK ADD  CONSTRAINT [MembreListe_fk1] FOREIGN KEY([IdListe])
REFERENCES [dbo].[Liste] ([IdListe])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[MembreListe] CHECK CONSTRAINT [MembreListe_fk1]
GO

/****** Object: Table [dbo].[Groupe] Script Date: 13/09/2023 16:00:00 ******/
CREATE TABLE [dbo].[Groupe](
	[IdGroupe] [int] NOT NULL,
	[LibeleGroup] [varchar](255) NOT NULL,
 CONSTRAINT [PK_GROUPE] PRIMARY KEY CLUSTERED 
(
	[IdGroupe] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object: Table [dbo].[Bus] Script Date: 13/09/2023 16:05:00 ******/
CREATE TABLE [dbo].[Bus](
	[IdBus] [int] NOT NULL,
	[LibeleBus] [varchar](255) NOT NULL,
 CONSTRAINT [PK_BUS] PRIMARY KEY CLUSTERED 
(
	[IdBus] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

