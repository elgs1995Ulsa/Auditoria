create database semestralAuditoria;
use semestralAuditoria;


Create table [Persona] (
	[idPersona] Integer identity(1,1) NOT NULL primary key,
	[nombresPersona] varchar(200) NOT NULL,
	[apellidoPaternoPersona] varchar(200) NOT NULL,
	[apellidoMaternoPersona] varchar(200) NOT NULL,
	[callePersona] Char(200) NOT NULL,
	[cpPersona] int NOT NULL,
	[paisPersona] varchar(100) NOT NULL,
	[numeroCallePersona] int NOT NULL,
	[coloniaPersona] varchar(200) NOT NULL,
	[entidadFederativa] varchar(200) NOT NULL,
	perfilProfesional varchar(200) not null,
) 
go

Create table [Rol] (
	[idRol] Integer identity(1,1) NOT NULL primary key,
	[nombreRol] varchar(20) NOT NULL,
) 
go
Create table [Usuario] (
	[idUsuario] Integer identity(1,1) NOT NULL primary key,
	[nombreUsuario] varchar(300) NOT NULL,
	[contrasenaUsuario] varchar(300) NOT NULL,
	[idPersona] Integer NOT NULL,
	[idRol] Integer NOT NULL,
	FOREIGN KEY (idPersona) REFERENCES Persona(idPersona),
    FOREIGN KEY (idRol) REFERENCES Rol(idRol)
) 
go



Create table [Auditor] (
	[idAuditor] integer identity (1,1)  primary key NOT NULL,
	[idUsuario] Integer NOT NULL,
	FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)

) 
go



Create table [Empresa] (
	[idEmpresa] Integer identity(1,1) primary key NOT NULL,
	[razonSocialEmpresa] varchar(200) NOT NULL,
	[nombreFiscalEmpresa] varchar(200) NOT NULL,
	[rfcEmpresa] varchar(50) NOT NULL,
	[telefonoEmpresa] varchar(20) NOT NULL,
	[correoElectronicoEmpresa] varchar(100) NOT NULL,
	[giroEmpresa] varchar(100) NOT NULL,
	[representanteLegal] varchar(100) NOT NULL,
	[calleNumeroEmpresa] varchar(100) NOT NULL,
	[municipioEmpresa] varchar(100) NOT NULL,
	[cpEmpresa] varchar(10) NOT NULL,
) 
go

Create table [AuditorXEmpresa] (
	idAuditorXEmpresa integer identity(1,1) not null primary key,
	[idAuditor] Integer NOT NULL,
	[idEmpresa] Integer NOT NULL,
    FOREIGN KEY (idAuditor) REFERENCES Auditor(idAuditor),
	FOREIGN KEY (idEmpresa) REFERENCES Empresa(idEmpresa)


) 
go