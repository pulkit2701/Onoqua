CREATE TABLE [dbo].[FormGroups] (
    [FormGroupID] NUMERIC (18)  IDENTITY (4, 1) NOT NULL,
    [FormID]      NUMERIC (18)  NOT NULL,
    [GroupID]     NUMERIC (18)  NOT NULL,
    [Priority]    NUMERIC (3)   NOT NULL,
    [UIClass]     VARCHAR (100) NOT NULL,
    [IsVertical]  BIT           CONSTRAINT [DF_FormGroups_IsVertical] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_FormGroups] PRIMARY KEY CLUSTERED ([FormGroupID] ASC),
    CONSTRAINT [FK_FormGroups_Forms] FOREIGN KEY ([FormID]) REFERENCES [dbo].[Forms] ([FormID]),
    CONSTRAINT [FK_FormGroups_Groups] FOREIGN KEY ([GroupID]) REFERENCES [dbo].[Groups] ([GroupID])
);

