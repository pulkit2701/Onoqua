CREATE TABLE [dbo].[QueryFilters] (
    [QueryFilterID] NUMERIC (18) NOT NULL,
    [QueryFilter]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_QueryFilters] PRIMARY KEY CLUSTERED ([QueryFilterID] ASC)
);

