CREATE PROCEDURE [dbo].[EliminarPostal]
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION
        UPDATE dbo.Postales
        SET Tengo = 0
        WHERE Id = @Id;
        SELECT @Id
        COMMIT TRANSACTION
END