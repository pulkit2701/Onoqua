CREATE TABLE [dbo].[FieldExpressions] (
    [FieldExpressionID] NUMERIC (18)  NOT NULL,
    [FieldExpression]   VARCHAR (100) NOT NULL,
    [FieldID]           NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_FieldExpressions] PRIMARY KEY CLUSTERED ([FieldExpressionID] ASC),
    CONSTRAINT [FK_FieldExpressions_Fields] FOREIGN KEY ([FieldID]) REFERENCES [dbo].[Fields] ([FieldID])
);

