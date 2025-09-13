CREATE TABLE [dbo].[Entity] (
    [EntityID]  NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [RoleID]    NUMERIC (18)  NOT NULL,
    [FirstName] VARCHAR (100) NOT NULL,
    [LastName]  VARCHAR (100) NOT NULL,
    [emailID]   VARCHAR (100) NULL,
    [Password]  VARCHAR (50)  NULL,
    [AddressID] NUMERIC (18)  NULL,
    [ClientID]  NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED ([EntityID] ASC),
    CONSTRAINT [FK_Entity_Address] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Address] ([AddressID]),
    CONSTRAINT [FK_Entity_Client] FOREIGN KEY ([ClientID]) REFERENCES [dbo].[Client] ([ClientID]),
    CONSTRAINT [FK_Entity_Roles] FOREIGN KEY ([RoleID]) REFERENCES [dbo].[Roles] ([RoleID])
);

