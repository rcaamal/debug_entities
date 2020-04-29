CREATE TABLE [dbo].[BlogPost] (
    [PostID]    INT            NOT NULL,
    [UserName]  NVARCHAR (128) NULL,
    [Title]     NVARCHAR (50)  NULL,
    [Post]      NVARCHAR (MAX) NULL,
    [Category]  NVARCHAR (50)  DEFAULT ('Default') NULL,
    [Published] DATE            DEFAULT ((0)) NULL,
    [Created]   NVARCHAR (50)  DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([PostID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [TitleIndex]
    ON [dbo].[BlogPost]([Title] ASC);

