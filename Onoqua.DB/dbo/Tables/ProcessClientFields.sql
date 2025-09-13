CREATE TABLE [dbo].[ProcessClientFields] (
    [ProcessClientFieldID] NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [ProcessClientID]      NUMERIC (18)  NOT NULL,
    [FieldID]              NUMERIC (18)  NOT NULL,
    [FieldValue]           VARCHAR (200) NULL,
    CONSTRAINT [PK_ProcessClientFields] PRIMARY KEY CLUSTERED ([ProcessClientFieldID] ASC),
    CONSTRAINT [FK_ProcessClientFields_Fields] FOREIGN KEY ([FieldID]) REFERENCES [dbo].[Fields] ([FieldID]),
    CONSTRAINT [FK_ProcessClientFields_ProcessClients] FOREIGN KEY ([ProcessClientID]) REFERENCES [dbo].[ProcessClients] ([ProcessClientID])
);

