CREATE TABLE [dbo].[Process] (
    [ProcessID]   NUMERIC (18)  NOT NULL,
    [ProcessName] VARCHAR (100) NOT NULL,
    [Summary]     VARCHAR (400) NOT NULL,
    [LogoURL]     VARCHAR (150) NOT NULL,
    CONSTRAINT [PK_Process] PRIMARY KEY CLUSTERED ([ProcessID] ASC)
);

