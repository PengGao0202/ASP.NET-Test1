﻿CREATE TABLE [dbo].[Dogs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(6) NULL, 
    [YearBorn] NVARCHAR(4) NULL, 
    [Breed] NVARCHAR(50) NULL
)
