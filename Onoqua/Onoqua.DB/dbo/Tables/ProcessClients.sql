CREATE TABLE [dbo].[ProcessClients] (
    [ProcessClientID] NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [ClientID]        NUMERIC (18) NOT NULL,
    [ProcessID]       NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_ProcessClients] PRIMARY KEY CLUSTERED ([ProcessClientID] ASC),
    CONSTRAINT [FK_ProcessClients_Client] FOREIGN KEY ([ClientID]) REFERENCES [dbo].[Client] ([ClientID]),
    CONSTRAINT [FK_ProcessClients_Process] FOREIGN KEY ([ProcessID]) REFERENCES [dbo].[Process] ([ProcessID])
);

