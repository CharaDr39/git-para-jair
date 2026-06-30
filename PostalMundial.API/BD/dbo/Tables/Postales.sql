CREATE TABLE [dbo].[Postales] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [IdPais]        UNIQUEIDENTIFIER NOT NULL,
    [IdGrupo]       UNIQUEIDENTIFIER NOT NULL,
    [Numero]        INT              NOT NULL,
    [Tengo]         BIT              NOT NULL,
    [FechaAgregada] DATETIME         NOT NULL,
    [Notas]         VARCHAR (MAX)    NULL,
    CONSTRAINT [PK_Postales] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Postales_Grupos] FOREIGN KEY ([IdGrupo]) REFERENCES [dbo].[Grupos] ([Id]),
    CONSTRAINT [FK_Postales_Paises] FOREIGN KEY ([IdPais]) REFERENCES [dbo].[Paises] ([Id])
);

