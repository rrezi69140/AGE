USE [GestionEnfant]
GO

-- Création de la table Groupe
CREATE TABLE [dbo].[Groupe](
    [IdGroupe] [int] NOT NULL,
    [LibeleGroup] [varchar](255) NOT NULL,
    CONSTRAINT [PK_GROUPE] PRIMARY KEY CLUSTERED 
    (
        [IdGroupe] ASC
    )WITH (
        PAD_INDEX = OFF, 
        STATISTICS_NORECOMPUTE = OFF, 
        IGNORE_DUP_KEY = OFF, 
        ALLOW_ROW_LOCKS = ON, 
        ALLOW_PAGE_LOCKS = ON, 
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Création de la table Bus
CREATE TABLE [dbo].[Bus](
    [IdBus] [int] NOT NULL,
    [LibeleBus] [varchar](255) NOT NULL,
    CONSTRAINT [PK_BUS] PRIMARY KEY CLUSTERED 
    (
        [IdBus] ASC
    )WITH (
        PAD_INDEX = OFF, 
        STATISTICS_NORECOMPUTE = OFF, 
        IGNORE_DUP_KEY = OFF, 
        ALLOW_ROW_LOCKS = ON, 
        ALLOW_PAGE_LOCKS = ON, 
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Création de la table Membre
CREATE TABLE [dbo].[Membre](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [NumDossier] [varchar](255) NOT NULL,
    [Nom] [varchar](255) NOT NULL,
    [Prenom] [varchar](255) NOT NULL,
    [DateNaissance] [date] NOT NULL,
    [IGroupe] [int] NOT NULL,
    [IdBus] [int] NOT NULL,
    CONSTRAINT [PK_MEMBRE] PRIMARY KEY CLUSTERED 
    (
        [Id] ASC
    )WITH (
        PAD_INDEX = OFF, 
        STATISTICS_NORECOMPUTE = OFF, 
        IGNORE_DUP_KEY = OFF, 
        ALLOW_ROW_LOCKS = ON, 
        ALLOW_PAGE_LOCKS = ON, 
        OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
    ) ON [PRIMARY]
)
GO

-- Définition des clés étrangères
ALTER TABLE [dbo].[Membre] WITH CHECK ADD CONSTRAINT [Membre_fk0] FOREIGN KEY([IGroupe])
REFERENCES [dbo].[Groupe] ([IdGroupe])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Membre] CHECK CONSTRAINT [Membre_fk0]
GO

ALTER TABLE [dbo].[Membre] WITH CHECK ADD CONSTRAINT [Membre_fk1] FOREIGN KEY([IdBus])
REFERENCES [dbo].[Bus] ([IdBus])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Membre] CHECK CONSTRAINT [Membre_fk1]
GO
