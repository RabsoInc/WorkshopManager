CREATE TABLE [dbo].[ReleaseNotes] (
    [Id]                 UNIQUEIDENTIFIER NOT NULL,
    [ReleaseDate]        NVARCHAR (MAX)   NOT NULL,
    [ReleaseNoteDetails] NVARCHAR (MAX)   NOT NULL,
    [ReleaseVersion]     NVARCHAR (10)    DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_ReleaseNotes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

