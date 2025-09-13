CREATE TABLE [dbo].[Fields] (
    [FieldID]   NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [FieldType] VARCHAR (10)  NOT NULL,
    [FieldName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Fields] PRIMARY KEY CLUSTERED ([FieldID] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'N: Numeric
S: String
C: Combo
R: Currency
D: Date', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Fields';

