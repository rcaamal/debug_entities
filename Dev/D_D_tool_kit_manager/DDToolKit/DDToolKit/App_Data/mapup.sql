create table [dbo].[Maps](
	[ID]		INT IDENTITY(1,1)	NOT NULL,
	[OwnerID]	Nvarchar(128)		,
	[GameID]	Int					,
	[Name]		NvarChar(30)		Not NULL,
	[MapWidth]	Int					,
	[MapHeight]	Int					,
	[MapLand]	NvarChar(400)		,
	[MapObjects]NvarChar(400)		,

	CONSTRAINT [PK_dbo.Maps] PRIMARY KEY CLUSTERED ([ID] ASC),
);