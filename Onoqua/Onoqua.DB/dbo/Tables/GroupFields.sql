CREATE TABLE [dbo].[GroupFields] (
    [GroupFieldID] NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [GroupID]      NUMERIC (18) NOT NULL,
    [FieldID]      NUMERIC (18) NOT NULL,
    [Priority]     INT          NOT NULL,
    [UIClass]      VARCHAR (20) CONSTRAINT [DF_GroupFields_UIClass] DEFAULT ('col-md-12') NOT NULL,
    CONSTRAINT [PK_GroupFields] PRIMARY KEY CLUSTERED ([GroupFieldID] ASC),
    CONSTRAINT [FK_GroupFields_Fields] FOREIGN KEY ([FieldID]) REFERENCES [dbo].[Fields] ([FieldID]),
    CONSTRAINT [FK_GroupFields_Groups] FOREIGN KEY ([GroupID]) REFERENCES [dbo].[Groups] ([GroupID])
);

