CREATE PROCEDURE [dbo].[CatalogoDistritoLista]
@IdCatalogoDistrito INT
AS
	BEGIN
		SET NOCOUNT ON
		SELECT 
		IdCatalogoDistrito,
		NombreCatalogoDistrito

		FROM	
			dbo.CatalogoDistrito

	    WHERE
		    IdCatalogoDistrito=@IdCatalogoDistrito


	END
