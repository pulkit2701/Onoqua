CREATE TABLE [dbo].[ComboValues] (
    [ComboValueID] NUMERIC (18) NOT NULL,
    [FieldID]      NUMERIC (18) NOT NULL,
    [DisplayText]  VARCHAR (50) NOT NULL,
    [ComboValue]   VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_ComboValues] PRIMARY KEY CLUSTERED ([ComboValueID] ASC),
    CONSTRAINT [FK_ComboValues_Fields] FOREIGN KEY ([FieldID]) REFERENCES [dbo].[Fields] ([FieldID])
);

