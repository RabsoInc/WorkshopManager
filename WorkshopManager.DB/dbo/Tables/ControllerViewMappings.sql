CREATE TABLE [dbo].[ControllerViewMappings] (
    [Id]         UNIQUEIDENTIFIER NOT NULL,
    [Controller] NVARCHAR (MAX)   NOT NULL,
    [Action]     NVARCHAR (MAX)   NOT NULL,
    [Path]       NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_ControllerViewMappings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

