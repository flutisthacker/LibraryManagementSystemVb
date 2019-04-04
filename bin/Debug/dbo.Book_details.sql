CREATE TABLE [dbo].[Book_details] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Book name]      NVARCHAR (50) NOT NULL,
    [author]         NVARCHAR (50) NOT NULL,
    [category]       NVARCHAR (50) NOT NULL,
    [publication]    NVARCHAR (50) NOT NULL,
    [published date] SMALLDATETIME NOT NULL,
    [ISBN no]        NUMERIC (18)  NOT NULL,
    [status]         NVARCHAR (50) NOT NULL,
    [copy]           NUMERIC (18)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

