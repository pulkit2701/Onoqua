CREATE TABLE [dbo].[Client] (
    [ClientID] NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ClientID] ASC)
);

