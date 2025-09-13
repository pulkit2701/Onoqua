CREATE TABLE [dbo].[ConnectionStrings] (
    [ConnectionStringID] NUMERIC (18) NOT NULL,
    [ConnectionString]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ConnectionStrings] PRIMARY KEY CLUSTERED ([ConnectionStringID] ASC)
);

