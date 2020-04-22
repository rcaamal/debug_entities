CREATE TABLE [dbo].[BlogPost] (
    [PostID]    INT IDENTITY (1,1)           NOT NULL,
    [UserName]  NVARCHAR (128) NULL,
    [Title]     NVARCHAR (50)  NULL,
    [Post]      NVARCHAR (MAX) NULL,
    [Published] date            DEFAULT  NULL,
    CONSTRAINT [PK_dbo.BlogPost] PRIMARY KEY CLUSTERED ([PostID] ASC)
);