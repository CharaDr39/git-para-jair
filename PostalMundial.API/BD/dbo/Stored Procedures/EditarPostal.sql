CREATE PROCEDURE [dbo].[EditarPostal]
    @Id UNIQUEIDENTIFIER,
    @IdPais UNIQUEIDENTIFIER,
    @IdGrupo UNIQUEIDENTIFIER,
    @Numero INT,
    @Tengo BIT,
    @Notas VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION
    UPDATE dbo.Postales
    SET
        IdPais = @IdPais,
        IdGrupo = @IdGrupo,
        Numero = @Numero,
        Tengo = @Tengo,
        Notas = @Notas
    WHERE Id = @Id;
    SELECT @IdPais
    COMMIT TRANSACTION
END