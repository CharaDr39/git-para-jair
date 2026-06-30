CREATE PROCEDURE [dbo].[ObtenerPostales]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        P.Id,
        P.Numero,
        P.Tengo,
        P.FechaAgregada,
        P.Notas,
        PA.Nombre AS Pais,
        G.Nombre AS Grupo
    FROM dbo.Postales P
    INNER JOIN dbo.Paises PA ON P.IdPais = PA.Id
    INNER JOIN dbo.Grupos G ON P.IdGrupo = G.Id;
END