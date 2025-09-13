CREATE TABLE [dbo].[Messages] (
    [MessageID] NUMERIC (18)  NOT NULL,
    [Message]   VARCHAR (100) NOT NULL,
    [TaskID]    NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED ([MessageID] ASC),
    CONSTRAINT [FK_Messages_Tasks] FOREIGN KEY ([TaskID]) REFERENCES [dbo].[Tasks] ([TaskID])
);

