CREATE TABLE dbo.Alquiler
(
	  AlquilerId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Alquiler PRIMARY KEY CLUSTERED(AlquilerId)
	, FechaAlquiler DATE NOT NULL
	, FechaRegresarAlquiler DATE NOT NULL
	, AgenciaId INT NOT NULL 
		CONSTRAINT FK_Alquiler_Angecias FOREIGN KEY(AgenciaId) REFERENCES dbo.Agencias(AgenciaId)
	, VehiculoId INT NOT NULL 
		CONSTRAINT FK_Alquiler_Vehiculo FOREIGN KEY(VehiculoId) REFERENCES dbo.Vehiculo(VehiculoId)
)
WITH (DATA_COMPRESSION = PAGE)
GO