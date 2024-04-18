
CREATE TABLE tblExamen (
    idExamen INT,
    Nombre VARCHAR(255),
    Descripcion VARCHAR(255)
);

/*El procedure para agregar examenes junto con su descripcion*/
create procedure spAgregar
    @idExamen int,
    @Nombre VARCHAR(255),
    @Descripcion VARCHAR(255)
as
begin
insert into tblExamen (idExamen,Nombre,Descripcion)values(@idExamen,@Nombre,@Descripcion)
end 
/*El procedure para ver cuantos examenes son*/
create procedure spConsultar
as 
begin 
select  * from  tblExamen
end 

exec spConsultar
/*El procedure para actualizar examenes junto con su descripcion*/
create procedure spActualizar
    @idExamen int,
    @Nombre VARCHAR(255),
    @Descripcion VARCHAR(255)
as
begin
UPDATE
   tblExamen set Nombre = @Nombre,Descripcion = @Descripcion where idExamen = @idExamen
end 

create procedure spEliminar
    @idExamen INT
AS
BEGIN
    DELETE FROM tblExamen WHERE idExamen = @idExamen;
END


/*Conocer los stored procedures existentes*/
SELECT COUNT(*) AS TotalProcedures
FROM sys.procedures;

DELETE from tblExamen;
DROP PROCEDURE IF EXISTS spConsultar;
DROP PROCEDURE IF EXISTS spAgregar;
DROP PROCEDURE IF EXISTS DeleteExamen;
DROP PROCEDURE IF EXISTS spActualizar;
DROP TABLE tblExamen;
