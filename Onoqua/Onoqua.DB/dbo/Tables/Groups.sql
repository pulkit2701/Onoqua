﻿CREATE TABLE [dbo].[Groups] (
    [GroupID]   NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [GroupName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([GroupID] ASC)
);

