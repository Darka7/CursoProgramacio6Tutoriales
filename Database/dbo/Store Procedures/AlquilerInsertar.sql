CREATE PROCEDURE dbo.AlquilerInsertar
	
	@ClientesId INT,
	@VehiculoId INT,
	@FechaInicio DATETIME ,
	@FechaFin DATETIME ,
    @Monto DECIMAL(18,2),
	@Impuesto DECIMAL(18,2),
	@Total DECIMAL(18,2),
	@Observaciones VARCHAR(1000),
	@Estado BIT
	
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY

		
		INSERT INTO dbo.Alquiler 
		(	       
	      ClientesId,
		  VehiculoId,
		  FechaInicio,
		  FechaFin,
		  Monto,
		  Impuesto,
		  Total,
		  Observaciones,
		  Estado
		)
		VALUES
		(
		
	      @ClientesId,
		  @VehiculoId,
		  @FechaInicio,
		  @FechaFin,
		  @Monto,
		  @Impuesto,
		  @Total,
		  @Observaciones,
		  @Estado
		)


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END