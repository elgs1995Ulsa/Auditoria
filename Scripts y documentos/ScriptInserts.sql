INSERT INTO Rol
	(nombreRol)
VALUES
	('Administrador'),
	('Auditor');


INSERT INTO Persona
	(nombresPersona, apellidoPaternoPersona, apellidoMaternoPersona, callePersona, cpPersona, paisPersona, numeroCallePersona, coloniaPersona, entidadFederativa, perfilProfesional)
VALUES
	('Angel Daniel', 'Alonso', 'Tovar', 'Moctezuma', '68000', 'Mexico', '207', 'Centro', 'Oaxaca', 'Ing. Software');

INSERT INTO Usuario
	(nombreUsuario, contrasenaUsuario, idPersona, idRol)
VALUES
	('admin', 'admin', 1, 1);