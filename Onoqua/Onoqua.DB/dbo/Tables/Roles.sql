CREATE TABLE [dbo].[Roles] (
    [RoleID]      NUMERIC (18)  NOT NULL,
    [RoleType]    VARCHAR (100) NOT NULL,
    [Description] VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([RoleID] ASC)
);

