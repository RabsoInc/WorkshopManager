CREATE TABLE [dbo].[Titles] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (100)   NOT NULL,
    CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

