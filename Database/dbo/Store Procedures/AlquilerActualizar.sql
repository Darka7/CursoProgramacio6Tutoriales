CREATE PROCEDURE dbo.AlquilerActualizar
    @IdAlquiler INT,
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

		
	UPDATE dbo.Alquiler SET
	      ClientesId=@ClientesId,
		  VehiculoId=@VehiculoId,
		  FechaInicio=@FechaInicio,
		  FechaFin=@FechaFin,
		  Monto=@Monto,
		  Impuesto=@Impuesto,
		  Total=@Total,
		  Observaciones=@Observaciones,
		  Estado=@Estado

	WHERE IdAlquiler=@IdAlquiler

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
