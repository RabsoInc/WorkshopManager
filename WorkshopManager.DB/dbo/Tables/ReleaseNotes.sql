CREATE TABLE [dbo].[ReleaseNotes] (
    [Id]                 UNIQUEIDENTIFIER NOT NULL,
    [ReleaseVersion]     NVARCHAR (10)    NOT NULL,
    [ReleaseDate]        NVARCHAR (MAX)   NOT NULL,
    [ReleaseNoteDetails] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_ReleaseNotes] PRIMARY KEY CLUSTERED ([Id] ASC)
);



