-----------------------------------------------------------------------------------------------------------------------
--										BASE DE DATOS MEDICAL CONTROL
-----------------------------------------------------------------------------------------------------------------------
CREATE DATABASE bd_proyecto
GO

USE bd_proyecto
GO


CREATE TABLE Cuenta (

IdCuenta INT PRIMARY KEY IDENTITY (1,1),
NombreCuenta VARCHAR (30),
Contrasena VARCHAR (20),
TipoCuenta VARCHAR (30),
CONSTRAINT DatosCuenta UNIQUE (NombreCuenta,Contrasena)

);


CREATE TABLE Especialidad (

IdEspecialidad INT PRIMARY KEY IDENTITY (1,1),
NombreEs VARCHAR (20),
CONSTRAINT NomEspecialidad UNIQUE (NombreES)

);


CREATE TABLE Medico (

IdMedico INT PRIMARY KEY IDENTITY (1,1),
NombreM VARCHAR (30),
ApellidoM VARCHAR (30),
IdEspecialidad INT,
EmailM VARCHAR (60),
TelefonoM VARCHAR (10),
CedulaM VARCHAR (16),
SexoM VARCHAR (1),
DireccionM VARCHAR(MAX),
FOREIGN KEY (IdEspecialidad) REFERENCES Especialidad (IdEspecialidad),
CONSTRAINT DatosMedico UNIQUE (EmailM,TelefonoM,CedulaM),
CONSTRAINT SexoCheck CHECK (SexoM='F' OR SexoM='M')

);


CREATE TABLE Usuario (

IdCuenta INT,
IdMedico INT,
FOREIGN KEY (IdCuenta) REFERENCES Cuenta (IdCuenta),
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico)

);



CREATE TABLE Expediente (

IdExpediente INT PRIMARY KEY IDENTITY (1,1),
NumeroExpediente VARCHAR (16),
MotivoConsulta VARCHAR(MAX),
TratamientoIndicado VARCHAR (MAX),
CedulaPac VARCHAR (16),
NombrePac VARCHAR (50),
ApellidosPac VARCHAR (50),
FechaNacimiento DATE,
LugarNacimiento VARCHAR(MAX),
SexoPac VARCHAR (1),
EdadPac INT,
GrupoEtnico VARCHAR(80),
DireccionHabitualPac VARCHAR (MAX),
NombrePadre VARCHAR (100),
NombreMadre VARCHAR (100),
ReligionPac VARCHAR (100),
ProcedenciaPac VARCHAR (20),
TelefonoPac VARCHAR (9),
EstadoCivilPac VARCHAR (15),
EnferICHepatitis VARCHAR(1),
EnferICSifilis VARCHAR(1),
EnferICColera VARCHAR(1),
EnferICTosferina VARCHAR(1),
EnferICSarampion VARCHAR(1),
EnferICVaricela VARCHAR(1),
EnferICRubeola VARCHAR(1),
EnferICPariotiditis VARCHAR(1),
EnferICMeningitis VARCHAR(1),
EnferICImpetigo VARCHAR(1),
EnferICTifoidea VARCHAR(1),
EnferICMalaria VARCHAR(1),
EnferICEscabiasis VARCHAR(1),
EnferICTina VARCHAR(1),
EnferHAlergias VARCHAR(1),
EnferHDiabetes VARCHAR(1),
EnferHHipertension VARCHAR(1),
EnferHReumatica VARCHAR(1),
EnferHRenales VARCHAR(1),
EnferHOculares VARCHAR(1),
EnferHCardiacas VARCHAR(1),
EnferHHepatica VARCHAR(1),
EnferHMusculares VARCHAR(1),
EnferHMalCongenitas VARCHAR(1),
EnferHDesorMentales VARCHAR(1),
CONSTRAINT Paciente_datos UNIQUE (CedulaPac,TelefonoPac,NumeroExpediente),
CONSTRAINT SexoPCheck CHECK (SexoPac='F' OR SexoPac='M')

);


CREATE TABLE Servicios (

IdServicios INT PRIMARY KEY IDENTITY (1,1),
NombreServicio VARCHAR (80),
CostoServicio MONEY

);


CREATE TABLE DetalleServicios (

IdDetServic INT PRIMARY KEY IDENTITY (1,1),
Precio MONEY,
IdExpediente INT,
IdServicios INT,
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
FOREIGN KEY (IdServicios) REFERENCES Servicios (IdServicios)

);


CREATE TABLE Cita (

IdCita INT PRIMARY KEY IDENTITY (1,1),
FechaConsul DATETIME,
FechaRealCita DATETIME,
HoraC TIME,
IdExpediente INT,
IdMedico INT,
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico)

);


CREATE TABLE Medicamento (

IdMedica INT PRIMARY KEY IDENTITY (1,1),
NombreMedica VARCHAR (80),
PresentacionMedica VARCHAR (80)

);


CREATE TABLE Consulta(

IdConsulta INT PRIMARY KEY IDENTITY (1,1),
Fecha DATETIME,
Hora TIME,
Costo MONEY,
Sintomas VARCHAR (MAX),
Diagnostico VARCHAR (MAX),
IdExpediente INT,
IdMedico INT,
FOREIGN KEY (IdExpediente) REFERENCES Expediente (IdExpediente),
FOREIGN KEY (IdMedico) REFERENCES Medico (IdMedico)

);


CREATE TABLE Consulta_Medicamento (

IdMedica INT,
IdConsulta INT,
FOREIGN KEY (IdMedica) REFERENCES Medicamento (IdMedica),
FOREIGN KEY (IdConsulta) REFERENCES Consulta (IdConsulta)

);





-----------------------------------------------------------------------------------------------------------------------
--										PROCEDIMIENTOS ALMACENADOS
-----------------------------------------------------------------------------------------------------------------------



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--1. Procedimiento para tabla cuenta--

CREATE PROCEDURE Cuenta_Proced

	@b INT, 
	@IdCuenta INT,
	@NombreCuenta VARCHAR (30), 
	@Contrasena VARCHAR (20),
	@TipoCuenta VARCHAR (30)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Cuenta VALUES (
									@NombreCuenta,
									@Contrasena,
									@TipoCuenta
								);

	IF @b=2
	DELETE FROM Cuenta WHERE Cuenta.IdCuenta=@IdCuenta;

	IF @b=3
	SELECT * FROM Cuenta;

	IF @b=4
	UPDATE Cuenta SET Cuenta.Contrasena=@Contrasena WHERE Cuenta.IdCuenta=@IdCuenta;

	IF @b=5
	SELECT * FROM Cuenta WHERE Cuenta.NombreCuenta=@NombreCuenta AND Cuenta.Contrasena=@Contrasena;

	IF @b=6
	SELECT * FROM Cuenta WHERE Cuenta.NombreCuenta LIKE '%' + @NombreCuenta + '%';

	IF @b=7
	SELECT * FROM Cuenta 
	WHERE (Cuenta.IdCuenta NOT IN (SELECT IdCuenta FROM Usuario))
	AND Cuenta.TipoCuenta='Estándar'
END
GO


CREATE PROCEDURE BuscarIdCuenta_Proced

	@NombreCuenta VARCHAR (30)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT IdCuenta FROM Cuenta WHERE Cuenta.NombreCuenta=@NombreCuenta;
END
GO

CREATE PROCEDURE TipoCuenta_Proced

	@NombreCuenta VARCHAR (30), 
	@Contrasena VARCHAR (20)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT TipoCuenta FROM Cuenta WHERE Cuenta.NombreCuenta=@NombreCuenta AND Cuenta.Contrasena=@Contrasena;

END
GO

--2. Procedimiento para tabla de especialidad--

CREATE PROCEDURE Especialidad_Proced

	@b INT, 
	@IdEspecialidad INT,
	@NombreEs VARCHAR (20) 

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Especialidad VALUES (
										@NombreEs
									);

	IF @b=2
	DELETE FROM Especialidad WHERE Especialidad.IdEspecialidad=@IdEspecialidad;

	IF @b=3
	SELECT * FROM Especialidad;

	IF @b=4
	UPDATE Especialidad SET Especialidad.NombreEs=@NombreEs WHERE Especialidad.IdEspecialidad=@IdEspecialidad;

	IF @b=5
	SELECT * FROM Especialidad WHERE Especialidad.NombreEs LIKE '%' + @NombreEs + '%';

	IF @b=6
	SELECT IdEspecialidad FROM Especialidad WHERE Especialidad.NombreEs=@NombreEs;

END
GO

--3. procedimiento para tabla de medico--

CREATE PROCEDURE Medico_Proced

	@b INT, 
	@IdMedico INT,
	@NombreM VARCHAR (30),
	@ApellidoM VARCHAR (30),
	@IdEspecialidad INT,
	@EmailM VARCHAR (60),
	@TelefonoM VARCHAR (10),
	@CedulaM VARCHAR (16),
	@SexoM VARCHAR (1),
	@DireccionM VARCHAR (MAX)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Medico VALUES (
									@NombreM,
									@ApellidoM,
									@IdEspecialidad,
									@EmailM,
									@TelefonoM,
									@CedulaM,
									@SexoM,
									@DireccionM
								);

	IF @b=2
	DELETE FROM Medico WHERE Medico.IdMedico=@IdMedico;

	IF @b=3
	SELECT * FROM Medico;

	IF @b=4
	UPDATE Medico SET 
					  Medico.IdEspecialidad=@IdEspecialidad,
					  Medico.EmailM=@EmailM,
					  Medico.TelefonoM=@TelefonoM,
					  Medico.DireccionM=@DireccionM
	WHERE Medico.IdMedico=@IdMedico;

	IF @b=5
	SELECT * FROM Medico WHERE Medico.NombreM LIKE '%' + @NombreM + '%' OR
	Medico.ApellidoM LIKE '%' + @ApellidoM + '%' OR
	Medico.CedulaM LIKE '%' + @CedulaM + '%'


	IF @b=6
	SELECT * FROM Medico WHERE (Medico.IdMedico NOT IN (SELECT IdMedico FROM Usuario));
END
GO

CREATE PROCEDURE Usuario_Proced

	@b INT,
	@IdCuenta INT,
	@IdMedico INT

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Usuario VALUES (
									@IdCuenta,
									@IdMedico
								);

	IF @b=2
	DELETE FROM Usuario WHERE Usuario.IdMedico=@IdMedico;

	IF @b=3
	SELECT * FROM Usuario;

	IF @b=4
	UPDATE Usuario SET Usuario.IdMedico=@IdMedico
	WHERE Usuario.IdCuenta=@IdCuenta;

	IF @b=5
	SELECT IdMedico FROM Usuario WHERE Usuario.IdCuenta=@IdCuenta;

END
GO



CREATE PROCEDURE IdMedico_Proced

	@b INT,
	@NombreCom VARCHAR(70)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	SELECT IdMedico FROM Medico WHERE (Medico.NombreM+' '+Medico.ApellidoM)=@NombreCom;
	
	IF @b=2
	SELECT IdMedico FROM Medico WHERE (Medico.NombreM+' '+Medico.ApellidoM)=@NombreCom
	AND (Medico.IdMedico NOT IN (SELECT IdMedico FROM Usuario));

END
GO

CREATE PROCEDURE NombreMedico_Proced

	@IdMedico INT

AS
BEGIN
	SET NOCOUNT ON;

	SELECT NombreM, ApellidoM FROM Medico WHERE Medico.IdMedico=@IdMedico

END
GO


--4. Procedimeinto almacenado para tabla de expediente--

CREATE PROCEDURE Expediente_Proced 

	@b INT,
	@IdExpediente INT,
	@NumeroExpediente VARCHAR (16),
	@MotivoConsulta VARCHAR (MAX),
	@TratamientoIndicado VARCHAR (MAX),
	@CedulaPac VARCHAR (16),
	@NombrePac VARCHAR (50),
	@ApellidosPac VARCHAR (50),
	@FechaNacimiento DATE,
	@LugarNacimiento VARCHAR (MAX),
	@SexoPac VARCHAR (1),
	@EdadPac INT,
	@GrupoEtnico VARCHAR(80),
	@DireccionHabitualPac VARCHAR (MAX),
	@NombrePadre VARCHAR (100),
	@NombreMadre VARCHAR (100),
	@ReligionPac VARCHAR (100),
	@ProcedenciaPac VARCHAR (20),
	@TelefonoPac VARCHAR (9),
	@EstadoCivilPac VARCHAR (15),
	@EnferICHepatitis VARCHAR(1),
	@EnferICSifilis VARCHAR(1),
	@EnferICColera VARCHAR(1),
	@EnferICTosferina VARCHAR(1),
	@EnferICSarampion VARCHAR(1),
	@EnferICVaricela VARCHAR(1),
	@EnferICRubeola VARCHAR(1),
	@EnferICPariotiditis VARCHAR(1),
	@EnferICMeningitis VARCHAR(1),
	@EnferICImpetigo VARCHAR(1),
	@EnferICTifoidea VARCHAR(1),
	@EnferICMalaria VARCHAR(1),
	@EnferICEscabiasis VARCHAR(1),
	@EnferICTina VARCHAR(1),
	@EnferHAlergias VARCHAR(1),
	@EnferHDiabetes VARCHAR(1),
	@EnferHHipertension VARCHAR(1),
	@EnferHReumatica VARCHAR(1),
	@EnferHRenales VARCHAR(1),
	@EnferHOculares VARCHAR(1),
	@EnferHCardiacas VARCHAR(1),
	@EnferHHepatica VARCHAR(1),
	@EnferHMusculares VARCHAR(1),
	@EnferHMalCongenitas VARCHAR(1),
	@EnferHDesorMentales VARCHAR(1)
	
AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Expediente VALUES (
									@NumeroExpediente,
									@MotivoConsulta,
									@TratamientoIndicado,
									@CedulaPac,
									@NombrePac,
									@ApellidosPac,
									@FechaNacimiento,
									@LugarNacimiento,
									@SexoPac,
									@EdadPac,
									@GrupoEtnico,
									@DireccionHabitualPac,
									@NombrePadre,
									@NombreMadre,
									@ReligionPac,
									@ProcedenciaPac,
									@TelefonoPac,
									@EstadoCivilPac,
									@EnferICHepatitis,
									@EnferICSifilis,
									@EnferICColera,
									@EnferICTosferina,
									@EnferICSarampion,
									@EnferICVaricela,
									@EnferICRubeola,
									@EnferICPariotiditis,
									@EnferICMeningitis,
									@EnferICImpetigo,
									@EnferICTifoidea,
									@EnferICMalaria,
									@EnferICEscabiasis,
									@EnferICTina,
									@EnferHAlergias,
									@EnferHDiabetes,
									@EnferHHipertension,
									@EnferHReumatica,
									@EnferHRenales,
									@EnferHOculares,
									@EnferHCardiacas,
									@EnferHHepatica,
									@EnferHMusculares,
									@EnferHMalCongenitas,
									@EnferHDesorMentales

								);

	IF @b=2
	DELETE FROM Expediente WHERE Expediente.IdExpediente=@IdExpediente;

	IF @b=3
	SELECT * FROM Expediente;

	IF @b=4
	UPDATE Expediente SET			
							Expediente.MotivoConsulta=@MotivoConsulta,
							Expediente.TratamientoIndicado=@TratamientoIndicado,
							Expediente.DireccionHabitualPac=@DireccionHabitualPac,
							Expediente.TelefonoPac=@TelefonoPac,
							Expediente.EstadoCivilPac=@EstadoCivilPac
					  WHERE Expediente.IdExpediente=@IdExpediente;

	IF @b=5
	SELECT * FROM Expediente WHERE Expediente.NombrePac LIKE '%' + @NombrePac + '%' OR
	Expediente.CedulaPac LIKE '%' + @CedulaPac + '%'


	IF @b=6
	SELECT * FROM Expediente WHERE IdExpediente=@IdExpediente;

END
GO



CREATE PROCEDURE Paciente_Proced 

	@b INT,
	@IdExpediente INT,
	@NumeroExpediente INT,
	@CedulaPac VARCHAR (16),
	@NombrePac VARCHAR (50),
	@ApellidosPac VARCHAR (50),
	@FechaNacimiento DATE,
	@LugarNacimiento VARCHAR (MAX),
	@SexoPac VARCHAR (1),
	@EdadPac INT,
	@GrupoEtnico VARCHAR(80),
	@DireccionHabitualPac VARCHAR (MAX),
	@NombrePadre VARCHAR (100),
	@NombreMadre VARCHAR (100),
	@ReligionPac VARCHAR (100),
	@ProcedenciaPac VARCHAR (20),
	@TelefonoPac VARCHAR (10),
	@EstadoCivilPac VARCHAR (15)
	
AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO 
	Expediente (
				NumeroExpediente,
				CedulaPac,
				NombrePac,
				ApellidosPac,
				FechaNacimiento,
				LugarNacimiento,
				SexoPac,
				EdadPac,
				GrupoEtnico,
				DireccionHabitualPac,
				NombrePadre,
				NombreMadre,
				ReligionPac,
				ProcedenciaPac,
				TelefonoPac,
				EstadoCivilPac
				) 
	
	VALUES (
				@NumeroExpediente,
				@CedulaPac,
				@NombrePac,
				@ApellidosPac,
				@FechaNacimiento,
				@LugarNacimiento,
				@SexoPac,
				@EdadPac,
				@GrupoEtnico,
				@DireccionHabitualPac,
				@NombrePadre,
				@NombreMadre,
				@ReligionPac,
				@ProcedenciaPac,
				@TelefonoPac,
				@EstadoCivilPac

			);

	IF @b=2
	DELETE FROM Expediente WHERE Expediente.IdExpediente=@IdExpediente;

	IF @b=3
	SELECT IdExpediente,NumeroExpediente, CedulaPac, NombrePac, ApellidosPac, FechaNacimiento, LugarNacimiento,
		   SexoPac,EdadPac, GrupoEtnico, DireccionHabitualPac, NombrePadre, NombreMadre, ReligionPac, ProcedenciaPac,
		   TelefonoPac, EstadoCivilPac
	FROM Expediente;

	IF @b=4
	UPDATE Expediente SET			
							Expediente.DireccionHabitualPac=@DireccionHabitualPac,
							Expediente.TelefonoPac=@TelefonoPac,
							Expediente.EstadoCivilPac=@EstadoCivilPac
	WHERE Expediente.IdExpediente=@IdExpediente;

	IF @b=5
	SELECT * FROM Expediente WHERE Expediente.NombrePac LIKE '%' + @NombrePac + '%' OR
	Expediente.CedulaPac LIKE '%' + @CedulaPac + '%';

END
GO


alter PROCEDURE PacienteMedico_Proced

	@IdMedico INT,
	@b INT,
	@NombrePac VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	SELECT IdExpediente,NumeroExpediente, CedulaPac, NombrePac, ApellidosPac, FechaNacimiento, LugarNacimiento,
		   SexoPac,EdadPac, GrupoEtnico, DireccionHabitualPac, NombrePadre, NombreMadre, ReligionPac, ProcedenciaPac,
		   TelefonoPac, EstadoCivilPac
	FROM Expediente WHERE(Expediente.IdExpediente IN (SELECT IdExpediente FROM Cita WHERE IdMedico=@IdMedico));

	IF @b=2
	SELECT IdExpediente,NumeroExpediente, CedulaPac, NombrePac, ApellidosPac, FechaNacimiento, LugarNacimiento,
		   SexoPac,EdadPac, GrupoEtnico, DireccionHabitualPac, NombrePadre, NombreMadre, ReligionPac, ProcedenciaPac,
		   TelefonoPac, EstadoCivilPac
	FROM Expediente WHERE(Expediente.IdExpediente IN (SELECT IdExpediente FROM Cita WHERE IdMedico=@IdMedico))
	AND Expediente.NombrePac LIKE '%' + @NombrePac + '%'

	IF @b=3
	SELECT * FROM Expediente WHERE(Expediente.IdExpediente IN (SELECT IdExpediente FROM Cita WHERE IdMedico=@IdMedico))

END
GO


--5. Procedimiento almacenda para tabla de servicios

CREATE PROCEDURE Servicios_Proced 

	@b INT, 
	@IdServicios INT,
	@NombreServicio VARCHAR (80),
	@CostoServicio MONEY

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Servicios VALUES (
									@NombreServicio,
									@CostoServicio
								 );

	IF @b=2
	DELETE FROM Servicios WHERE Servicios.IdServicios=@IdServicios;

	IF @b=3
	SELECT * FROM Servicios;

	IF @b=4
	UPDATE Servicios SET 
						 Servicios.NombreServicio=@NombreServicio, 
						 Servicios.CostoServicio=@CostoServicio 
	WHERE Servicios.IdServicios=@IdServicios;

	IF @b=5
	SELECT * FROM Servicios WHERE Servicios.NombreServicio LIKE '%' + @NombreServicio + '%'

END
GO

--6. Procedimiento para tabla de DetalleServicios--

CREATE PROCEDURE DetalleServicios_Proced 

	@b INT, 
	@IdDetServic INT,
	@Precio MONEY,
	@IdExpediente INT,
	@IdServicios INT

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO DetalleServicios VALUES (
											@Precio,
											@IdExpediente,
											@IdServicios
										);

	IF @b=2
	DELETE FROM DetalleServicios WHERE DetalleServicios.IdDetServic=@IdDetServic;

	IF @b=3
	SELECT * FROM DetalleServicios;

	IF @b=4
	UPDATE DetalleServicios SET 
								DetalleServicios.Precio=@Precio, 
								DetalleServicios.IdExpediente=@IdExpediente, 
								DetalleServicios.IdServicios=@IdServicios
	WHERE DetalleServicios.IdDetServic=@IdDetServic;

END
GO

--7. procedimiento para tabla cita--

CREATE PROCEDURE Cita_Proced 

	@b INT, 
	@IdCita INT,
	@FechaConsul DATETIME,
	@FechaRealCita DATETIME,
	@HoraC TIME,
	@IdExpediente INT,
	@IdMedico INT

AS
BEGIN

	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Cita VALUES (
								@FechaConsul,
								@FechaRealCita,
								@HoraC,
								@IdExpediente,
								@IdMedico
							);

	IF @b=2
	DELETE FROM Cita WHERE Cita.IdCita=@IdCita;

	IF @b=3
	SELECT * FROM Cita;

	IF @b=4
	UPDATE Cita SET		 
						 Cita.FechaConsul=@FechaConsul,
						 Cita.FechaRealCita=@FechaRealCita,
						 Cita.HoraC=@HoraC,
						 Cita.IdExpediente=@IdExpediente
	WHERE Cita.IdCita=@IdCita;

	IF @b=5
	SELECT * FROM Cita WHERE Cita.FechaConsul LIKE '%' + @FechaConsul + '%' 
	OR Cita.FechaRealCita LIKE '%' + @FechaRealCita;

	IF @b=6
	SELECT * FROM Cita WHERE Cita.IdMedico=@IdMedico;

	IF @b=7
	SELECT * FROM Cita WHERE CAST(Cita.FechaConsul AS VARCHAR(12))=CAST (GETDATE() AS DATE);

	IF @b=8
	SELECT * FROM Cita WHERE CAST(Cita.FechaConsul AS VARCHAR(12))=CAST (GETDATE() AS DATE) AND Cita.IdMedico=@IdMedico;

END
GO

--8. procedimiento para tabla de medicamento--

CREATE PROCEDURE Medicamento_Proced 

	@b INT, 
	@IdMedica INT,
	@NombreMedica VARCHAR (80),
	@PresentacionMedica VARCHAR (80)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Medicamento VALUES (
										@NombreMedica,
										@PresentacionMedica
									);

	IF @b=2
	DELETE FROM Medicamento WHERE Medicamento.IdMedica=@IdMedica;

	IF @b=3
	SELECT * FROM Medicamento;

	IF @b=4
	UPDATE Medicamento SET	
							Medicamento.NombreMedica=@NombreMedica, 
							Medicamento.PresentacionMedica=@PresentacionMedica
	WHERE Medicamento.IdMedica=@IdMedica;

	IF @b=5
	SELECT * FROM Medicamento WHERE Medicamento.NombreMedica LIKE '%' + @NombreMedica + '%'

END
GO

--9. procedimiento para tabla de consulta--

CREATE PROCEDURE Consulta_Proced 

	@b INT, 
	@IdConsulta INT,
	@Fecha DATETIME,
	@Hora TIME,
	@Costo MONEY,
	@Sintomas VARCHAR (MAX),
	@Diagnostico VARCHAR (MAX),
	@IdExpediente INT,
	@IdMedico INT

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Consulta VALUES (	
									@Fecha ,
									@Hora ,
									@Costo ,
									@Sintomas,
									@Diagnostico,
									@IdExpediente,
									@IdMedico
								 );

	IF @b=2
	DELETE FROM Consulta WHERE Consulta.IdConsulta=@IdConsulta;

	IF @b=3
	SELECT * FROM Consulta;

	IF @b=4
	UPDATE Consulta SET  
						 Consulta.Fecha=@Fecha, 
						 Consulta.Hora=@Hora,
						 Consulta.Costo=@Costo,
						 Consulta.Sintomas=@Sintomas,
						 Consulta.Diagnostico=@Diagnostico,
						 Consulta.IdExpediente=@IdExpediente
	WHERE Consulta.IdConsulta=@IdConsulta;

	IF @b=5
	SELECT * FROM Consulta WHERE Consulta.Fecha LIKE '%' + @Fecha + '%';

	IF @b=6
	SELECT * FROM Consulta WHERE Consulta.IdMedico=@IdMedico;

	IF @b=7
	SELECT * FROM Consulta WHERE CAST(Consulta.Fecha AS VARCHAR(12))=CAST (GETDATE() AS DATE)
	AND Consulta.IdMedico=@IdMedico;

END
GO

--10. procedimiento para tabla de consulta_medicamento

CREATE PROCEDURE Consulta_Medicamen_Proced

	@b INT, 
	@IdMedica INT,
	@IdConsulta INT

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Consulta_Medicamento VALUES (	
												@IdMedica ,
												@IdConsulta
											);

	IF @b=2
	DELETE FROM Consulta_Medicamento WHERE Consulta_Medicamento.IdConsulta=@IdConsulta;

	IF @b=3
	UPDATE Consulta_Medicamento SET  
						 Consulta_Medicamento.IdMedica=@IdMedica,
						 Consulta_Medicamento.IdConsulta=@IdConsulta
	WHERE Consulta_Medicamento.IdConsulta=@IdConsulta;

END
GO

CREATE PROCEDURE Cuenta_Proced

	@b INT, 
	@IdCuenta INT,
	@NombreCuenta VARCHAR (30), 
	@Contrasena VARCHAR (20),
	@TipoCuenta VARCHAR (30)

AS
BEGIN
	SET NOCOUNT ON;

	IF @b=1
	INSERT INTO Cuenta VALUES (
									@NombreCuenta,
									@Contrasena,
									@TipoCuenta
								);

	IF @b=2
	DELETE FROM Cuenta WHERE Cuenta.IdCuenta=@IdCuenta;

	IF @b=3
	SELECT * FROM Cuenta;

	IF @b=4
	UPDATE Cuenta SET Cuenta.Contrasena=@Contrasena WHERE Cuenta.IdCuenta=@IdCuenta;

	IF @b=5
	SELECT * FROM Cuenta WHERE Cuenta.NombreCuenta=@NombreCuenta AND Cuenta.Contrasena=@Contrasena;

	IF @b=6
	SELECT * FROM Cuenta WHERE Cuenta.NombreCuenta LIKE '%' + @NombreCuenta + '%';

END
GO

CREATE PROCEDURE RespaldoBD_Proced
	
AS
BEGIN
	SET NOCOUNT ON;

	BACKUP DATABASE [bd_proyecto]
	TO DISK= N'E:\Backup\rbd_MC.back'
	WITH CHECKSUM;
END
GO


-----------------------------------------------------------------------------------------------------------------------
--												REGISTROS
-----------------------------------------------------------------------------------------------------------------------


INSERT INTO Cuenta VALUES ('victor22','123','Administrador'),
						  ('jordy20','110998','Administrador'),
						  ('medico','321','Estándar')


INSERT INTO Usuario VALUES (3,1)


INSERT INTO Especialidad VALUES ('Cardiología'),
								('Ginecología'),
								('Pediatría'),
								('Psiquiatría')

INSERT INTO Expediente VALUES ('1234','Dolor de cabeza','Reposo','121-110909-0005l','Víctor','Sánchez','1998-10-30','Boaco','M',22,'Mestizo','Casa de habitación','Julio Sánchez ','María Pérez','Católica','Juigalpa','88889888','Viudo','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F','F'),
							  ('15656','Dolor de pie','Amputar','121-120630-0004P','Dustin','Durán','1997-09-23','Chontales','M',23,'Mestizo','Barrio Tamanes','Mario Durán','Gloria Báez','Evangélica','Texas','84444444','Divorciado','F','F','F','F','F','F','F','F','F','F','F','V','F','F','F','F','F','F','F','F','V','F','F','V','F')

INSERT INTO Medico VALUES ('Josh','González',1,'tumedico@gmail.com','88888887','121-110909-9900E','M','Casa de habitación'),
						  ('Gina','Sepulveda',3,'medicogeneral@gmail.com','88899900','121-230912-8811G','F','Barrio Rubén Darío')


INSERT INTO Usuario VALUES (3,1)


INSERT INTO Cita VALUES ('2019-09-09','2019-09-10','10:38:00',1,1),
						('2019-10-08','2019-10-09','12:40:00',2,2)


INSERT INTO Consulta VALUES ('2019-11-09','08:00:23','2500','Dolor de articulaciones','Artritis',2,1),
							('2019-01-11','12:45:56','4000','Dolor de cabeza','Migraña',1,2)

INSERT INTO Medicamento VALUES ('Paracetamol','Pastilla'),
							   ('Diclofenac','Inyección'),
							   ('Vitaflenaco','Pastilla'),
							   ('Acetaminofén','Pastilla')

INSERT INTO Servicios VALUES ('Cirugía','4000'),
							 ('Ultrasonido','2000')