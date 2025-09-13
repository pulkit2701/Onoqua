CREATE TABLE [dbo].[InnterFaces] (
    [InterFaceID]        NUMERIC (18)  NOT NULL,
    [SQL]                VARCHAR (300) NOT NULL,
    [ConnectionStringID] NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_InnterFaces] PRIMARY KEY CLUSTERED ([InterFaceID] ASC),
    CONSTRAINT [FK_InnterFaces_ConnectionStrings] FOREIGN KEY ([ConnectionStringID]) REFERENCES [dbo].[ConnectionStrings] ([ConnectionStringID])
);

