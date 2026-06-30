CREATE PROCEDURE [dbo].[AgregarPostal]
@IdPais UNIQUEIDENTIFIER,
@IdGrupo UNIQUEIDENTIFIER,
@Numero INT,
@Tengo BIT,
@Notas VARCHAR(MAX)
AS
BEGIN
SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @Id UNIQUEIDENTIFIER = NEWID();

    INSERT INTO dbo.Postales
    (
        Id,
        IdPais,
        IdGrupo,
        Numero,
        Tengo,
        FechaAgregada,
        Notas
    )
    VALUES
    (
        @Id,
        @IdPais,
        @IdGrupo,
        @Numero,
        @Tengo,
        GETDATE(),
        @Notas
    );

    COMMIT TRANSACTION;

    SELECT @Id;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    THROW;
END CATCH

END

-- miaw