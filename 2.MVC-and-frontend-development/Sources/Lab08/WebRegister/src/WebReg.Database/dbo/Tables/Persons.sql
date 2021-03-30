CREATE TABLE [dbo].[Persons] (
    [Id]        UNIQUEIDENTIFIER CONSTRAINT [DF_Persons_Id] DEFAULT (newid()) NOT NULL,
    [FirstName] NVARCHAR (50)    NULL,
    [LastName]  NVARCHAR (50)    NULL,
    [BirthDate] DATE             NULL,
    [Email]     NVARCHAR (100)   NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([Id] ASC)
);

