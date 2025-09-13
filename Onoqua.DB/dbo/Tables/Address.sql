CREATE TABLE [dbo].[Address] (
    [AddressID]   NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [Line1]       VARCHAR (100) NOT NULL,
    [Line2]       VARCHAR (100) NULL,
    [Line3]       VARCHAR (100) NULL,
    [City]        VARCHAR (100) NOT NULL,
    [State]       VARCHAR (100) NOT NULL,
    [Zip]         VARCHAR (20)  NOT NULL,
    [AddressType] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressID] ASC)
);

