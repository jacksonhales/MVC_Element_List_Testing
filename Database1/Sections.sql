CREATE TABLE [dbo].[Sections]
(
	[Id] INT NOT NULL,
	[Title] NVARCHAR(100) NOT NULL,
	[Approved] NVARCHAR(1) NOT NULL,
	[DisplayPosition] INT NOT NULL,
	CONSTRAINT PK_Sections PRIMARY KEY ([Id])
)
