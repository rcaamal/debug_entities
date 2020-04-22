CREATE TABLE [dbo].[BlogPost] (
    [PostID]    INT            NOT NULL,
    [UserName]  NVARCHAR (128) NULL,
    [Title]     NVARCHAR (50)  NULL,
    [Post]      NVARCHAR (MAX) NULL,
    [Published] date            DEFAULT  NULL,
    CONSTRAINT [PK._dbo.BlogPost]PRIMARY KEY CLUSTERED ([PostID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [TitleIndex]
    ON [dbo].[BlogPost]([Title] ASC);