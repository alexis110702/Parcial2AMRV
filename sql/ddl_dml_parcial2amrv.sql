-- DDL - Parcial2AMRV
-- Base de datos para Canal de Television
-- Iniciales: AMRV

CREATE DATABASE Parcial2AMRV;
GO
USE master
GO
CREATE LOGIN usrparcial2 WITH PASSWORD = '12345678',
  DEFAULT_DATABASE = Parcial2AMRV,
  CHECK_EXPIRATION = OFF,
  CHECK_POLICY = ON
GO
USE Parcial2AMRV
GO
CREATE USER usrparcial2 FOR LOGIN usrparcial2
GO
ALTER ROLE db_owner ADD MEMBER usrparcial2
GO

DROP TABLE IF EXISTS Programa;
DROP TABLE IF EXISTS Canal;

CREATE TABLE Canal (
  id        INT IDENTITY(1,1) PRIMARY KEY,
  nombre    VARCHAR(50)  NOT NULL,
  frecuencia VARCHAR(20) NOT NULL,
  estado    SMALLINT     NOT NULL DEFAULT 1
);

CREATE TABLE Programa (
  id           INT IDENTITY(1,1) PRIMARY KEY,
  idCanal      INT           NOT NULL,
  titulo       VARCHAR(100)  NOT NULL,
  descripcion  VARCHAR(250)  NOT NULL,
  duracion     INT           NOT NULL,
  productor    VARCHAR(100)  NOT NULL,
  fechaEstreno DATE          NOT NULL,
  estado       SMALLINT      NOT NULL DEFAULT 1,
  CONSTRAINT fk_Programa_Canal FOREIGN KEY (idCanal) REFERENCES Canal(id)
);

-- Procedimiento almacenado para listar Programas
GO
DROP PROC IF EXISTS paProgramaListar;
GO
CREATE PROC paProgramaListar @parametro VARCHAR(100)
AS
  SELECT p.id, p.idCanal, p.titulo, p.descripcion,
         c.nombre AS canal,
         p.duracion, p.productor, p.fechaEstreno, p.estado
  FROM Programa p
  INNER JOIN Canal c ON c.id = p.idCanal
  WHERE p.estado = 1
    AND p.titulo + p.descripcion + c.nombre LIKE '%' + REPLACE(@parametro,' ','%') + '%'
  ORDER BY p.titulo;
GO

-- DML - Datos de prueba
INSERT INTO Canal (nombre, frecuencia, estado)
VALUES ('Canal 1 Bolivia', '100.5 FM', 1),
       ('Red Uno',         '102.3 FM', 1),
       ('Bolivia TV',      '104.7 FM', 1);

INSERT INTO Programa (idCanal, titulo, descripcion, duracion, productor, fechaEstreno, estado)
VALUES (1, 'Noticias Centrales',
           'Noticiero de alcance nacional con cobertura en vivo',
           60, 'Juan Perez', '2024-01-15', 1),
       (2, 'Cine en Casa',
           'Proyeccion de peliculas nacionales e internacionales',
           120, 'Maria Lopez', '2024-03-10', 1),
       (3, 'Deportes en Vivo',
           'Transmision de partidos de futbol y otros deportes',
           90, 'Carlos Mamani', '2024-05-20', 1);

SELECT * FROM Canal;
SELECT * FROM Programa;
EXEC paProgramaListar '';
EXEC paProgramaListar 'noticias';
