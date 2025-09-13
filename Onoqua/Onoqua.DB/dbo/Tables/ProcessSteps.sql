CREATE TABLE [dbo].[ProcessSteps] (
    [ProcessStepID]   NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [ProcessStepName] VARCHAR (50) NOT NULL,
    [IsSetup]         BIT          CONSTRAINT [DF_ProcessSteps_IsSetup] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ProcessSteps] PRIMARY KEY CLUSTERED ([ProcessStepID] ASC)
);

