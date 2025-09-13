CREATE TABLE [dbo].[WorkFlows] (
    [WorkFlowID]        NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [TaskID]            NUMERIC (18)  NULL,
    [InterFaceID]       NUMERIC (18)  NULL,
    [FormID]            NUMERIC (18)  NULL,
    [IsLast]            BIT           NOT NULL,
    [ProcessID]         NUMERIC (18)  NOT NULL,
    [ConditionalTaskID] NUMERIC (18)  NULL,
    [Priority]          NUMERIC (5)   NOT NULL,
    [ProcessStepID]     NUMERIC (18)  NOT NULL,
    [Provider]          VARCHAR (100) NOT NULL,
    [isFirst]           BIT           CONSTRAINT [DF_WorkFlows_isFirst] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_WorkFlows] PRIMARY KEY CLUSTERED ([WorkFlowID] ASC),
    CONSTRAINT [FK_WorkFlows_Forms] FOREIGN KEY ([FormID]) REFERENCES [dbo].[Forms] ([FormID]),
    CONSTRAINT [FK_WorkFlows_InnterFaces] FOREIGN KEY ([InterFaceID]) REFERENCES [dbo].[InnterFaces] ([InterFaceID]),
    CONSTRAINT [FK_WorkFlows_Process] FOREIGN KEY ([ProcessID]) REFERENCES [dbo].[Process] ([ProcessID]),
    CONSTRAINT [FK_WorkFlows_ProcessSteps] FOREIGN KEY ([ProcessStepID]) REFERENCES [dbo].[ProcessSteps] ([ProcessStepID]),
    CONSTRAINT [FK_WorkFlows_Tasks] FOREIGN KEY ([TaskID]) REFERENCES [dbo].[Tasks] ([TaskID])
);


GO
CREATE NONCLUSTERED INDEX [NonClusteredIndex-20160627-223348]
    ON [dbo].[WorkFlows]([ProcessID] ASC, [Priority] ASC);

