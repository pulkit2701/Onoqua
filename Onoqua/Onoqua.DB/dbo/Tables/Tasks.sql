CREATE TABLE [dbo].[Tasks] (
    [TaskID]        NUMERIC (18)  NOT NULL,
    [Expression]    VARCHAR (500) NOT NULL,
    [ResultFieldID] NUMERIC (18)  NOT NULL,
    [Description]   VARCHAR (200) NOT NULL,
    CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED ([TaskID] ASC)
);

