CREATE TABLE [dbo].[Paises] (
    [Id]      UNIQUEIDENTIFIER NOT NULL,
    [Nombre]  VARCHAR (MAX)    NOT NULL,
    [Bandera] VARCHAR (MAX)    NULL,
    CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED ([Id] ASC)
);

