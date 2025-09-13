CREATE TABLE [dbo].[WorkFlowFields] (
    [WorkFlowFieldID] NUMERIC (18) NOT NULL,
    [WorkFlowID]      NUMERIC (18) NOT NULL,
    [FieldID]         NUMERIC (18) NOT NULL,
    [QueryFilterID]   NUMERIC (18) NOT NULL,
    CONSTRAINT [FK_WorkFlowFields_Fields] FOREIGN KEY ([FieldID]) REFERENCES [dbo].[Fields] ([FieldID]),
    CONSTRAINT [FK_WorkFlowFields_QueryFilters] FOREIGN KEY ([QueryFilterID]) REFERENCES [dbo].[QueryFilters] ([QueryFilterID]),
    CONSTRAINT [FK_WorkFlowFields_WorkFlows] FOREIGN KEY ([WorkFlowID]) REFERENCES [dbo].[WorkFlows] ([WorkFlowID])
);

