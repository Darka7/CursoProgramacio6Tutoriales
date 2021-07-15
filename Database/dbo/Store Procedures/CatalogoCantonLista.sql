CREATE PROCEDURE [dbo].[CatalogoCantonLista]
@IdCatalogoProvincia INT
AS
	BEGIN
		SET NOCOUNT ON
		SELECT 
		IdCatalogoProvincia,
		NombreCatalogoProvincia

		FROM	
			dbo.CatalogoProvincia

	    WHERE
		    IdCatalogoProvincia=@IdCatalogoProvincia


	END