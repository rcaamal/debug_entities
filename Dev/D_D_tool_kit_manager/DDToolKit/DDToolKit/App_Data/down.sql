﻿DROP TABLE [dbo].[Creatures]
ALTER TABLE [dbo].[AspNetUserClaims]  DROP CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
ALTER TABLE [dbo].[AspNetUserLogins]  DROP CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
ALTER TABLE [dbo].[AspNetUserRoles]  DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
ALTER TABLE [dbo].[AspNetUserRoles]  DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
DROP TABLE [dbo].[AspNetUserRoles]
DROP TABLE [dbo].[AspNetUsers]
DROP TABLE [dbo].[AspNetRoles]
DROP TABLE [dbo].[AspNetUserClaims]
DROP TABLE [dbo].[AspNetUserLogins]

Drop Table [dbo].[Saves]
Drop Table [dbo].[Players]
DROP TABLE [dbo].[Magic]
Drop Table [dbo].[BlogPost]
DROP TABLE [dbo].[Equipment]
DROP TABLE [dbo].[Maps]