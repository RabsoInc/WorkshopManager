CREATE TABLE [dbo].[SystemAttributes] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [AttributeName] NVARCHAR (100)   NOT NULL,
    [MapCode]       NVARCHAR (125)   NOT NULL,
    CONSTRAINT [PK_SystemAttributes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

