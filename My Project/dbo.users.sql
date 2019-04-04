CREATE TABLE [dbo].[users] (
    [userid]   INT           IDENTITY (1, 1) NOT NULL,
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    [usertype] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([userid] ASC)
);

