CREATE TABLE [dbo].[Genders] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (100)   NOT NULL,
    CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

