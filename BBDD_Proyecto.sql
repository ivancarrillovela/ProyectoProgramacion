CREATE DATABASE PROYECTOINTER
USE PROYECTOINTER

CREATE TABLE ODS (
    NUMODS SMALLINT PRIMARY KEY,
    NOMBRE NVARCHAR(40) NOT NULL,
    DESCRIPCION NVARCHAR(40) NOT NULL
)
CREATE UNIQUE INDEX IX_ODS_NOMBRE ON ODS(NOMBRE);

CREATE TABLE CICLOS (
	CURSO SMALLINT CHECK (CURSO IN (1, 2)),
    NOMBRE NVARCHAR(40),
    CONSTRAINT PK_CICLOS PRIMARY KEY (CURSO, NOMBRE)
)

CREATE TABLE ORGANIZACIONES (
    CIF NCHAR(9) PRIMARY KEY,
    NOMBRE NVARCHAR(40) NOT NULL,
    DIRECCION NVARCHAR(40) NOT NULL,
    CP CHAR(5) NOT NULL,
    LOCALIDAD NVARCHAR(40) NOT NULL,
    DESCRIPCION NVARCHAR(40) NOT NULL,
    CONTACTO NVARCHAR(40) NOT NULL
)

CREATE TABLE ACTIVIDADES (
    CODACTIVIDAD SMALLINT IDENTITY(1,1) PRIMARY KEY,
    NOMBRE NVARCHAR(40) NOT NULL,
    ESTADO NVARCHAR(40) NOT NULL,
    DIRECCION NVARCHAR(40) NOT NULL,
    MAX_PARTICIPANTES SMALLINT NOT NULL,
    FECHA_INICIO DATETIME NOT NULL DEFAULT GETDATE(),
    FECHA_FIN DATETIME NOT NULL,
    CIF_EMPRESA NCHAR(9),
	CONSTRAINT FK_ACTIVIDADES FOREIGN KEY (CIF_EMPRESA) REFERENCES ORGANIZACIONES(CIF)
)

CREATE TABLE VOLUNTARIOS (
    DNI NCHAR(9) PRIMARY KEY,
    NOMBRE NVARCHAR(40) NOT NULL,
    APELLIDO1 NVARCHAR(40) NOT NULL,
    APELLIDO2 NVARCHAR(40) NOT NULL,
    CORREO NVARCHAR(40) NOT NULL,
    COCHE BIT NOT NULL,
    FECHA_NACIMIENTO DATETIME NOT NULL,
    EXPERIENCIA NVARCHAR(40),
	CURSO_CICLOS SMALLINT,
    NOMBRE_CICLOS NVARCHAR(40),
    CONSTRAINT FK_VOLUNTARIOS FOREIGN KEY (CURSO_CICLOS, NOMBRE_CICLOS) REFERENCES CICLOS(CURSO, NOMBRE)
)

CREATE TABLE DISPONIBILIDAD(
	DNI_VOLUNTARIO NCHAR(9) NOT NULL,
	DIA_SEMANA NVARCHAR(9) NOT NULL,
	HORARIO NVARCHAR(40) NOT NULL,
	CONSTRAINT FK_DISPONIBILIDAD FOREIGN KEY (DNI_VOLUNTARIO) REFERENCES VOLUNTARIOS(DNI),
	CONSTRAINT PK_DISPONIBILIDAD PRIMARY KEY (DNI_VOLUNTARIO, DIA_SEMANA, HORARIO)
)

CREATE UNIQUE INDEX IX_ORGANIZACIONES_NOMBRE ON ORGANIZACIONES(NOMBRE);

CREATE TABLE TIPOACTIVIDAD (
    NOMBRE NVARCHAR(40) PRIMARY KEY
)

CREATE TABLE ODS_ACTIVIDAD (
    CODACTIVIDAD SMALLINT NOT NULL,
    NUMODS SMALLINT NOT NULL,
	CONSTRAINT FK_ODS_ACTIVIDAD_CODACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDADES(CODACTIVIDAD),
	CONSTRAINT FK_ODS_ACTIVIDAD_NUMODS FOREIGN KEY (NUMODS) REFERENCES ODS(NUMODS),
	CONSTRAINT PK_ODS_ACTIVIDAD PRIMARY KEY (CODACTIVIDAD,NUMODS)
)

CREATE TABLE ACTIVIDADES_TIPOACTIVIDAD (
    NOMBRE_ACTIVIDAD NVARCHAR(40) NOT NULL,
    CODACTIVIDAD SMALLINT NOT NULL,
	CONSTRAINT FK_ACTIVIDADES_TIPOACTIVIDAD_NOMBRE_ACTIVIDAD FOREIGN KEY (NOMBRE_ACTIVIDAD) REFERENCES TIPOACTIVIDAD(NOMBRE),
	CONSTRAINT FK_ACTIVIDADES_TIPOACTIVIDAD_CODACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDADES(CODACTIVIDAD),
	CONSTRAINT PK_ACTIVIDADES_TIPOACTIVIDAD PRIMARY KEY (NOMBRE_ACTIVIDAD, CODACTIVIDAD)
)

CREATE TABLE TIPOACTIVIDAD_VOLUNTARIOS (
    DNI_VOLUNTARIO NCHAR(9) NOT NULL,
    NOMBRE_ACTIVIDAD NVARCHAR(40) NOT NULL,
	CONSTRAINT FK_TIPOACTIVIDAD_VOLUNTARIOS_DNI_VOLUNTARIO FOREIGN KEY (DNI_VOLUNTARIO) REFERENCES VOLUNTARIOS(DNI),
	CONSTRAINT FK_TIPOACTIVIDAD_VOLUNTARIOS_NOMBRE_ACTIVIDAD FOREIGN KEY (NOMBRE_ACTIVIDAD) REFERENCES TIPOACTIVIDAD(NOMBRE),
	CONSTRAINT PK_TIPOACTIVIDAD_VOLUNTARIOS PRIMARY KEY (DNI_VOLUNTARIO, NOMBRE_ACTIVIDAD)
)

CREATE TABLE VOLUNTARIOS_ACTIVIDADES (
    DNI_VOLUNTARIO NCHAR(9) NOT NULL,
    CODACTIVIDAD SMALLINT NOT NULL,
    CONSTRAINT FK_VOLUNTARIOS_ACTIVIDADES_DNI FOREIGN KEY (DNI_VOLUNTARIO) REFERENCES VOLUNTARIOS(DNI),
    CONSTRAINT FK_VOLUNTARIOS_ACTIVIDADES_CODACTIVIDAD FOREIGN KEY (CODACTIVIDAD) REFERENCES ACTIVIDADES(CODACTIVIDAD),
	CONSTRAINT PK_VOLUNTARIOS_ACTIVIDADES PRIMARY KEY (DNI_VOLUNTARIO, CODACTIVIDAD)
)


ALTER TABLE ACTIVIDADES ADD CONSTRAINT CK_ACTIVIDADES_ESTADO CHECK (ESTADO IN ('En Curso','Archivado','Pendiente'))

ALTER TABLE ACTIVIDADES ADD CONSTRAINT CK_ACTIVIDADES_FECHA_INICIO CHECK (FECHA_INICIO >= GETDATE());
ALTER TABLE ACTIVIDADES ADD CONSTRAINT CK_ACTIVIDADES_FECHA_FIN CHECK (FECHA_FIN >= FECHA_INICIO);

ALTER TABLE ORGANIZACIONES ADD CONSTRAINT CK_ORGANIZACIONES_CP CHECK (
    CP LIKE '[0-5][0-9][0-9][0-9][0-9]'
    AND CAST(LEFT(CP, 2) AS INT) BETWEEN 1 AND 52)

ALTER TABLE DISPONIBILIDAD ADD CONSTRAINT CHK_DIA_SEMANA CHECK (DIA_SEMANA IN ('Lunes', 'Martes', 'Mi�rcoles', 'Jueves', 'Viernes', 'S�bado', 'Domingo'));
go
CREATE RULE CIFSRULE AS (@CAMPO LIKE '[A-Z][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
go
EXEC SP_BINDRULE CIFSRULE,'ACTIVIDADES.CIF_EMPRESA'
EXEC SP_BINDRULE CIFSRULE,'ORGANIZACIONES.CIF'


go
CREATE RULE NIFSRULE AS (@CAMPO LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]')
go
EXEC SP_BINDRULE NIFSRULE,'VOLUNTARIOS.DNI'
EXEC SP_BINDRULE NIFSRULE,'VOLUNTARIOS_ACTIVIDADES.DNI_VOLUNTARIO'
EXEC SP_BINDRULE NIFSRULE,'DISPONIBILIDAD.DNI_VOLUNTARIO'
EXEC SP_BINDRULE NIFSRULE,'TIPOACTIVIDAD_VOLUNTARIOS.DNI_VOLUNTARIO'

go
CREATE PROCEDURE EliminarActividadesArchivadas
AS
BEGIN
    DELETE FROM ACTIVIDADES
    WHERE ESTADO = 'Archivada' AND FECHA_INICIO <= DATEADD(YEAR, -1, GETDATE())
END
go

go
CREATE PROCEDURE EliminarActividad
    @codActividad INT
AS
BEGIN
    DELETE FROM ODS_ACTIVIDAD WHERE CODACTIVIDAD = @codActividad
    DELETE FROM VOLUNTARIOS_ACTIVIDAD WHERE CODACTIVIDAD = @codActividad
    DELETE FROM ACTIVIDADES_TIPOACTIVI WHERE CODACTIVIDAD = @codActividad

    DELETE FROM ACTIVIDADES WHERE CODACTIVIDAD = @codActividad
END
go

go
CREATE PROCEDURE AgregarVoluntarioActividad
    @dniVoluntario NVARCHAR(50),
    @codActividad INT
AS
BEGIN
    INSERT INTO VOLUNTARIOS_ACTIVIDAD (DNI_VOLUNTARIO, CODACTIVIDAD)
    VALUES (@dniVoluntario, @codActividad)
END
go

go
CREATE PROCEDURE ActualizarEstadoActividad
    @codActividad INT,
    @nuevoEstado NVARCHAR(50)
AS
BEGIN
    UPDATE ACTIVIDADES
    SET ESTADO = @nuevoEstado
    WHERE CODACTIVIDAD = @codActividad
END
go

go
CREATE PROCEDURE ODSYCICLO
@ODS NVARCHAR(40),
@CICLOS NVARCHAR(40)
AS
BEGIN
    SELECT
        ACTIVIDADES.CODACTIVIDAD,
        ACTIVIDADES.NOMBRE AS NOMBREACTIVIDAD,
        ODS.NOMBRE AS NOMBREODS
    FROM ACTIVIDADES
    INNER JOIN ODS_ACTIVIDAD ON ACTIVIDADES.CODACTIVIDAD = ODS_ACTIVIDAD.CODACTIVIDAD
    INNER JOIN ODS ON ODS_ACTIVIDAD.NUMODS = ODS.NUMODS
    INNER JOIN VOLUNTARIOS_ACTIVIDADES ON ACTIVIDADES.CODACTIVIDAD = VOLUNTARIOS_ACTIVIDADES.CODACTIVIDAD
    INNER JOIN VOLUNTARIOS ON VOLUNTARIOS_ACTIVIDADES.DNI_VOLUNTARIO = VOLUNTARIOS.DNI
    INNER JOIN CICLOS ON VOLUNTARIOS.NOMBRE = CICLOS.NOMBRE
    WHERE ODS.NOMBRE = @ODS
      AND CICLOS.NOMBRE = @CICLOS;
END
go

INSERT INTO ODS (NUMODS, NOMBRE, DESCRIPCION) VALUES
(1, 'Fin de la pobreza', 'Erradicar la pobreza'),
(2, 'Hambre cero', 'Eliminar el hambre mundial'),
(3, 'Salud y bienestar', 'Promover salud integral');

INSERT INTO CICLOS (CURSO, NOMBRE) VALUES
(1, 'Desarrollo de Aplicaciones Web'),
(2, 'Desarrollo de Aplicaciones Web'),
(1, 'Administraci�n de Sistemas');

INSERT INTO ORGANIZACIONES (CIF, NOMBRE, DIRECCION, CP, LOCALIDAD, DESCRIPCION, CONTACTO) VALUES
('A12345678', 'Cruz Roja', 'Calle Mayor 10', '28001', 'Madrid', 'Organizaci�n humanitaria', 'cr@cruzroja.org'),
('B87654321', 'Banco de Alimentos', 'Avda. Solidaridad 5', '46001', 'Valencia', 'Recogida de alimentos', 'info@balimentos.org');

INSERT INTO ACTIVIDADES (NOMBRE, ESTADO, DIRECCION, MAX_PARTICIPANTES, FECHA_INICIO, FECHA_FIN, CIF_EMPRESA) VALUES
('Reparto de alimentos', 'En Curso', 'Calle Solidaridad 5', 20, DATEADD(DAY, 1, GETDATE()), DATEADD(DAY, 30, GETDATE()), 'B87654321'),
('Campa�a sanitaria', 'Pendiente', 'Centro M�dico Local', 10, DATEADD(DAY, 3, GETDATE()), DATEADD(DAY, 33, GETDATE()), 'A12345678'),
('Taller de Educaci�n', 'En Curso', 'Escuela Primaria Central', 15, DATEADD(DAY, 5, GETDATE()), DATEADD(DAY, 28, GETDATE()), 'B87654321');

INSERT INTO VOLUNTARIOS (DNI, NOMBRE, APELLIDO1, APELLIDO2, CORREO, COCHE, FECHA_NACIMIENTO, EXPERIENCIA, CURSO_CICLOS, NOMBRE_CICLOS) VALUES
('12345678A', 'Laura', 'G�mez', 'Mart�nez', 'laura.gomez@mail.com', 1, '2000-05-12', 'Buena con personas mayores', 2, 'Desarrollo de Aplicaciones Web'),
('87654321B', 'Carlos', 'P�rez', 'L�pez', 'carlos.perez@mail.com', 0, '1999-10-20', 'Conductor habitual', 1, 'Administraci�n de Sistemas');

INSERT INTO ODS_ACTIVIDAD (CODACTIVIDAD, NUMODS) VALUES
(1, 2),
(2, 3);

INSERT INTO VOLUNTARIOS_ACTIVIDADES (DNI_VOLUNTARIO, CODACTIVIDAD) VALUES
('12345678A', 1),
('87654321B', 2);

INSERT INTO TIPOACTIVIDAD (NOMBRE) VALUES
('Reparto'),
('Salud');

INSERT INTO ACTIVIDADES_TIPOACTIVIDAD (NOMBRE_ACTIVIDAD, CODACTIVIDAD) VALUES
('Reparto', 1),
('Salud', 2);

INSERT INTO TIPOACTIVIDAD_VOLUNTARIOS (DNI_VOLUNTARIO, NOMBRE_ACTIVIDAD) VALUES
('12345678A', 'Reparto'),
('87654321B', 'Salud');


INSERT INTO DISPONIBILIDAD (DNI_VOLUNTARIO, DIA_SEMANA, HORARIO) VALUES
('12345678A', 'Lunes', '10:00-16:00'),
('87654321B', 'Mi�rcoles', '16:00-20:00');

