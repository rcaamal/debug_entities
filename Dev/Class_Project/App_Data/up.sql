Create Table [User](
	[UserID] int Primary Key Identity (1,1),
	[Name] NVarChar(60),
	[Email] nvarchar(60),
	[Password] nvarchar(60)
)
Go

Create Table [Results](
	[AthleteStats] nvarchar(120),
	[TimeEvents] TimeStamp
)
Go

Create Table [Administrator](
	[AdminID] int primary key identity (1,1),
	[Name] nvarchar(60),
	[Password] nvarchar(60)
)
Go

Create Table [Coaches](
	[CoachID] int primary key identity (1,1),
	[Name] nvarchar(60),
	[Password] nvarchar(60)
)


Alter Table [Administrator] Add Foreign Key ([UserID]) References [User] ([UserID])
Alter Table [Administrator] Add Foreign Key ([CoachID]) References [Coaches] ([CoachesID])
Alter Table [Administrator] Add Foreign Key ([Results]) References [Results] ([CoachesID])