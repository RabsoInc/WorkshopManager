CREATE TABLE [dbo].[Customers] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [FirstName] NVARCHAR (50)    NOT NULL,
    [LastName]  NVARCHAR (50)    NOT NULL,
    [GenderId]  UNIQUEIDENTIFIER NOT NULL,
    [TitleId]   UNIQUEIDENTIFIER DEFAULT ('00000000-0000-0000-0000-000000000000') NOT NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Customers_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Customers_Titles_TitleId] FOREIGN KEY ([TitleId]) REFERENCES [dbo].[Titles] ([Id]) ON DELETE CASCADE
);




GO
CREATE NONCLUSTERED INDEX [IX_Customers_TitleId]
    ON [dbo].[Customers]([TitleId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Customers_GenderId]
    ON [dbo].[Customers]([GenderId] ASC);

