/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [Entrenamiento].[Alumno]
           ([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Edad])
     VALUES
           ('Franco','Cotrina','Romero',35),
		   ('Carlos','Espejo','Huerta',29),
		   ('Jose','Caceres','Mamani',36),
		   ('Yuri','Grandez','Del Aguila',36)
GO
