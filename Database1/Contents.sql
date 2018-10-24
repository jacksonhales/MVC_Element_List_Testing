CREATE TABLE [dbo].[Contents]
(
	[Id] INT NOT NULL,
	[SectionId] INT NOT NULL,
	[Title] NVARCHAR(100) NOT NULL,
	[Date] NVARCHAR(10),
	[Type] NVARCHAR(20),
	[Source] NVARCHAR(20),
	[DisplayPosition] INT,
	CONSTRAINT PK_Contents PRIMARY KEY ([Id], [SectionId]),
	CONSTRAINT FK_Contents_Sections FOREIGN KEY ([SectionId]) REFERENCES Sections ([Id])
)
