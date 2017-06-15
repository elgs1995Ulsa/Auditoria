﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Auditoria.Modelo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="semestralAuditoria")]
	public partial class AuditoriaModeloDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertAuditor(Auditor instance);
    partial void UpdateAuditor(Auditor instance);
    partial void DeleteAuditor(Auditor instance);
    partial void InsertAuditorXEmpresa(AuditorXEmpresa instance);
    partial void UpdateAuditorXEmpresa(AuditorXEmpresa instance);
    partial void DeleteAuditorXEmpresa(AuditorXEmpresa instance);
    partial void InsertEmpresa(Empresa instance);
    partial void UpdateEmpresa(Empresa instance);
    partial void DeleteEmpresa(Empresa instance);
    partial void InsertRol(Rol instance);
    partial void UpdateRol(Rol instance);
    partial void DeleteRol(Rol instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertPersona(Persona instance);
    partial void UpdatePersona(Persona instance);
    partial void DeletePersona(Persona instance);
    #endregion
		
		public AuditoriaModeloDataContext() : 
				base(global::Auditoria.Properties.Settings.Default.semestralAuditoriaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AuditoriaModeloDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuditoriaModeloDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuditoriaModeloDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuditoriaModeloDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Auditor> Auditor
		{
			get
			{
				return this.GetTable<Auditor>();
			}
		}
		
		public System.Data.Linq.Table<AuditorXEmpresa> AuditorXEmpresa
		{
			get
			{
				return this.GetTable<AuditorXEmpresa>();
			}
		}
		
		public System.Data.Linq.Table<Empresa> Empresa
		{
			get
			{
				return this.GetTable<Empresa>();
			}
		}
		
		public System.Data.Linq.Table<Rol> Rol
		{
			get
			{
				return this.GetTable<Rol>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Persona> Persona
		{
			get
			{
				return this.GetTable<Persona>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Auditor")]
	public partial class Auditor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAuditor;
		
		private int _idUsuario;
		
		private EntitySet<AuditorXEmpresa> _AuditorXEmpresa;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAuditorChanging(int value);
    partial void OnidAuditorChanged();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    #endregion
		
		public Auditor()
		{
			this._AuditorXEmpresa = new EntitySet<AuditorXEmpresa>(new Action<AuditorXEmpresa>(this.attach_AuditorXEmpresa), new Action<AuditorXEmpresa>(this.detach_AuditorXEmpresa));
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAuditor", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAuditor
		{
			get
			{
				return this._idAuditor;
			}
			set
			{
				if ((this._idAuditor != value))
				{
					this.OnidAuditorChanging(value);
					this.SendPropertyChanging();
					this._idAuditor = value;
					this.SendPropertyChanged("idAuditor");
					this.OnidAuditorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int NOT NULL")]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Auditor_AuditorXEmpresa", Storage="_AuditorXEmpresa", ThisKey="idAuditor", OtherKey="idAuditor")]
		public EntitySet<AuditorXEmpresa> AuditorXEmpresa
		{
			get
			{
				return this._AuditorXEmpresa;
			}
			set
			{
				this._AuditorXEmpresa.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Auditor", Storage="_Usuario", ThisKey="idUsuario", OtherKey="idUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Auditor.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Auditor.Add(this);
						this._idUsuario = value.idUsuario;
					}
					else
					{
						this._idUsuario = default(int);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AuditorXEmpresa(AuditorXEmpresa entity)
		{
			this.SendPropertyChanging();
			entity.Auditor = this;
		}
		
		private void detach_AuditorXEmpresa(AuditorXEmpresa entity)
		{
			this.SendPropertyChanging();
			entity.Auditor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AuditorXEmpresa")]
	public partial class AuditorXEmpresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAuditorXEmpresa;
		
		private int _idAuditor;
		
		private int _idEmpresa;
		
		private EntityRef<Auditor> _Auditor;
		
		private EntityRef<Empresa> _Empresa;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAuditorXEmpresaChanging(int value);
    partial void OnidAuditorXEmpresaChanged();
    partial void OnidAuditorChanging(int value);
    partial void OnidAuditorChanged();
    partial void OnidEmpresaChanging(int value);
    partial void OnidEmpresaChanged();
    #endregion
		
		public AuditorXEmpresa()
		{
			this._Auditor = default(EntityRef<Auditor>);
			this._Empresa = default(EntityRef<Empresa>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAuditorXEmpresa", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAuditorXEmpresa
		{
			get
			{
				return this._idAuditorXEmpresa;
			}
			set
			{
				if ((this._idAuditorXEmpresa != value))
				{
					this.OnidAuditorXEmpresaChanging(value);
					this.SendPropertyChanging();
					this._idAuditorXEmpresa = value;
					this.SendPropertyChanged("idAuditorXEmpresa");
					this.OnidAuditorXEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAuditor", DbType="Int NOT NULL")]
		public int idAuditor
		{
			get
			{
				return this._idAuditor;
			}
			set
			{
				if ((this._idAuditor != value))
				{
					if (this._Auditor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidAuditorChanging(value);
					this.SendPropertyChanging();
					this._idAuditor = value;
					this.SendPropertyChanged("idAuditor");
					this.OnidAuditorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEmpresa", DbType="Int NOT NULL")]
		public int idEmpresa
		{
			get
			{
				return this._idEmpresa;
			}
			set
			{
				if ((this._idEmpresa != value))
				{
					if (this._Empresa.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEmpresaChanging(value);
					this.SendPropertyChanging();
					this._idEmpresa = value;
					this.SendPropertyChanged("idEmpresa");
					this.OnidEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Auditor_AuditorXEmpresa", Storage="_Auditor", ThisKey="idAuditor", OtherKey="idAuditor", IsForeignKey=true)]
		public Auditor Auditor
		{
			get
			{
				return this._Auditor.Entity;
			}
			set
			{
				Auditor previousValue = this._Auditor.Entity;
				if (((previousValue != value) 
							|| (this._Auditor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Auditor.Entity = null;
						previousValue.AuditorXEmpresa.Remove(this);
					}
					this._Auditor.Entity = value;
					if ((value != null))
					{
						value.AuditorXEmpresa.Add(this);
						this._idAuditor = value.idAuditor;
					}
					else
					{
						this._idAuditor = default(int);
					}
					this.SendPropertyChanged("Auditor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empresa_AuditorXEmpresa", Storage="_Empresa", ThisKey="idEmpresa", OtherKey="idEmpresa", IsForeignKey=true)]
		public Empresa Empresa
		{
			get
			{
				return this._Empresa.Entity;
			}
			set
			{
				Empresa previousValue = this._Empresa.Entity;
				if (((previousValue != value) 
							|| (this._Empresa.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Empresa.Entity = null;
						previousValue.AuditorXEmpresa.Remove(this);
					}
					this._Empresa.Entity = value;
					if ((value != null))
					{
						value.AuditorXEmpresa.Add(this);
						this._idEmpresa = value.idEmpresa;
					}
					else
					{
						this._idEmpresa = default(int);
					}
					this.SendPropertyChanged("Empresa");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Empresa")]
	public partial class Empresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEmpresa;
		
		private string _razonSocialEmpresa;
		
		private string _nombreFiscalEmpresa;
		
		private string _rfcEmpresa;
		
		private string _telefonoEmpresa;
		
		private string _correoElectronicoEmpresa;
		
		private string _giroEmpresa;
		
		private string _representanteLegal;
		
		private string _calleNumeroEmpresa;
		
		private string _municipioEmpresa;
		
		private string _cpEmpresa;
		
		private EntitySet<AuditorXEmpresa> _AuditorXEmpresa;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEmpresaChanging(int value);
    partial void OnidEmpresaChanged();
    partial void OnrazonSocialEmpresaChanging(string value);
    partial void OnrazonSocialEmpresaChanged();
    partial void OnnombreFiscalEmpresaChanging(string value);
    partial void OnnombreFiscalEmpresaChanged();
    partial void OnrfcEmpresaChanging(string value);
    partial void OnrfcEmpresaChanged();
    partial void OntelefonoEmpresaChanging(string value);
    partial void OntelefonoEmpresaChanged();
    partial void OncorreoElectronicoEmpresaChanging(string value);
    partial void OncorreoElectronicoEmpresaChanged();
    partial void OngiroEmpresaChanging(string value);
    partial void OngiroEmpresaChanged();
    partial void OnrepresentanteLegalChanging(string value);
    partial void OnrepresentanteLegalChanged();
    partial void OncalleNumeroEmpresaChanging(string value);
    partial void OncalleNumeroEmpresaChanged();
    partial void OnmunicipioEmpresaChanging(string value);
    partial void OnmunicipioEmpresaChanged();
    partial void OncpEmpresaChanging(string value);
    partial void OncpEmpresaChanged();
    #endregion
		
		public Empresa()
		{
			this._AuditorXEmpresa = new EntitySet<AuditorXEmpresa>(new Action<AuditorXEmpresa>(this.attach_AuditorXEmpresa), new Action<AuditorXEmpresa>(this.detach_AuditorXEmpresa));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEmpresa", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEmpresa
		{
			get
			{
				return this._idEmpresa;
			}
			set
			{
				if ((this._idEmpresa != value))
				{
					this.OnidEmpresaChanging(value);
					this.SendPropertyChanging();
					this._idEmpresa = value;
					this.SendPropertyChanged("idEmpresa");
					this.OnidEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_razonSocialEmpresa", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string razonSocialEmpresa
		{
			get
			{
				return this._razonSocialEmpresa;
			}
			set
			{
				if ((this._razonSocialEmpresa != value))
				{
					this.OnrazonSocialEmpresaChanging(value);
					this.SendPropertyChanging();
					this._razonSocialEmpresa = value;
					this.SendPropertyChanged("razonSocialEmpresa");
					this.OnrazonSocialEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreFiscalEmpresa", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string nombreFiscalEmpresa
		{
			get
			{
				return this._nombreFiscalEmpresa;
			}
			set
			{
				if ((this._nombreFiscalEmpresa != value))
				{
					this.OnnombreFiscalEmpresaChanging(value);
					this.SendPropertyChanging();
					this._nombreFiscalEmpresa = value;
					this.SendPropertyChanged("nombreFiscalEmpresa");
					this.OnnombreFiscalEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rfcEmpresa", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string rfcEmpresa
		{
			get
			{
				return this._rfcEmpresa;
			}
			set
			{
				if ((this._rfcEmpresa != value))
				{
					this.OnrfcEmpresaChanging(value);
					this.SendPropertyChanging();
					this._rfcEmpresa = value;
					this.SendPropertyChanged("rfcEmpresa");
					this.OnrfcEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefonoEmpresa", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string telefonoEmpresa
		{
			get
			{
				return this._telefonoEmpresa;
			}
			set
			{
				if ((this._telefonoEmpresa != value))
				{
					this.OntelefonoEmpresaChanging(value);
					this.SendPropertyChanging();
					this._telefonoEmpresa = value;
					this.SendPropertyChanged("telefonoEmpresa");
					this.OntelefonoEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correoElectronicoEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string correoElectronicoEmpresa
		{
			get
			{
				return this._correoElectronicoEmpresa;
			}
			set
			{
				if ((this._correoElectronicoEmpresa != value))
				{
					this.OncorreoElectronicoEmpresaChanging(value);
					this.SendPropertyChanging();
					this._correoElectronicoEmpresa = value;
					this.SendPropertyChanged("correoElectronicoEmpresa");
					this.OncorreoElectronicoEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_giroEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string giroEmpresa
		{
			get
			{
				return this._giroEmpresa;
			}
			set
			{
				if ((this._giroEmpresa != value))
				{
					this.OngiroEmpresaChanging(value);
					this.SendPropertyChanging();
					this._giroEmpresa = value;
					this.SendPropertyChanged("giroEmpresa");
					this.OngiroEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_representanteLegal", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string representanteLegal
		{
			get
			{
				return this._representanteLegal;
			}
			set
			{
				if ((this._representanteLegal != value))
				{
					this.OnrepresentanteLegalChanging(value);
					this.SendPropertyChanging();
					this._representanteLegal = value;
					this.SendPropertyChanged("representanteLegal");
					this.OnrepresentanteLegalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_calleNumeroEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string calleNumeroEmpresa
		{
			get
			{
				return this._calleNumeroEmpresa;
			}
			set
			{
				if ((this._calleNumeroEmpresa != value))
				{
					this.OncalleNumeroEmpresaChanging(value);
					this.SendPropertyChanging();
					this._calleNumeroEmpresa = value;
					this.SendPropertyChanged("calleNumeroEmpresa");
					this.OncalleNumeroEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_municipioEmpresa", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string municipioEmpresa
		{
			get
			{
				return this._municipioEmpresa;
			}
			set
			{
				if ((this._municipioEmpresa != value))
				{
					this.OnmunicipioEmpresaChanging(value);
					this.SendPropertyChanging();
					this._municipioEmpresa = value;
					this.SendPropertyChanged("municipioEmpresa");
					this.OnmunicipioEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpEmpresa", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string cpEmpresa
		{
			get
			{
				return this._cpEmpresa;
			}
			set
			{
				if ((this._cpEmpresa != value))
				{
					this.OncpEmpresaChanging(value);
					this.SendPropertyChanging();
					this._cpEmpresa = value;
					this.SendPropertyChanged("cpEmpresa");
					this.OncpEmpresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Empresa_AuditorXEmpresa", Storage="_AuditorXEmpresa", ThisKey="idEmpresa", OtherKey="idEmpresa")]
		public EntitySet<AuditorXEmpresa> AuditorXEmpresa
		{
			get
			{
				return this._AuditorXEmpresa;
			}
			set
			{
				this._AuditorXEmpresa.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_AuditorXEmpresa(AuditorXEmpresa entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = this;
		}
		
		private void detach_AuditorXEmpresa(AuditorXEmpresa entity)
		{
			this.SendPropertyChanging();
			entity.Empresa = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rol")]
	public partial class Rol : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idRol;
		
		private string _nombreRol;
		
		private EntitySet<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidRolChanging(int value);
    partial void OnidRolChanged();
    partial void OnnombreRolChanging(string value);
    partial void OnnombreRolChanged();
    #endregion
		
		public Rol()
		{
			this._Usuario = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuario), new Action<Usuario>(this.detach_Usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRol", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idRol
		{
			get
			{
				return this._idRol;
			}
			set
			{
				if ((this._idRol != value))
				{
					this.OnidRolChanging(value);
					this.SendPropertyChanging();
					this._idRol = value;
					this.SendPropertyChanged("idRol");
					this.OnidRolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreRol", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string nombreRol
		{
			get
			{
				return this._nombreRol;
			}
			set
			{
				if ((this._nombreRol != value))
				{
					this.OnnombreRolChanging(value);
					this.SendPropertyChanging();
					this._nombreRol = value;
					this.SendPropertyChanged("nombreRol");
					this.OnnombreRolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Usuario", Storage="_Usuario", ThisKey="idRol", OtherKey="idRol")]
		public EntitySet<Usuario> Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				this._Usuario.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Usuario(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Rol = this;
		}
		
		private void detach_Usuario(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Rol = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _nombreUsuario;
		
		private string _contrasenaUsuario;
		
		private int _idPersona;
		
		private int _idRol;
		
		private EntitySet<Auditor> _Auditor;
		
		private EntityRef<Rol> _Rol;
		
		private EntityRef<Persona> _Persona;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void OnnombreUsuarioChanging(string value);
    partial void OnnombreUsuarioChanged();
    partial void OncontrasenaUsuarioChanging(string value);
    partial void OncontrasenaUsuarioChanged();
    partial void OnidPersonaChanging(int value);
    partial void OnidPersonaChanged();
    partial void OnidRolChanging(int value);
    partial void OnidRolChanged();
    #endregion
		
		public Usuario()
		{
			this._Auditor = new EntitySet<Auditor>(new Action<Auditor>(this.attach_Auditor), new Action<Auditor>(this.detach_Auditor));
			this._Rol = default(EntityRef<Rol>);
			this._Persona = default(EntityRef<Persona>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreUsuario", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string nombreUsuario
		{
			get
			{
				return this._nombreUsuario;
			}
			set
			{
				if ((this._nombreUsuario != value))
				{
					this.OnnombreUsuarioChanging(value);
					this.SendPropertyChanging();
					this._nombreUsuario = value;
					this.SendPropertyChanged("nombreUsuario");
					this.OnnombreUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contrasenaUsuario", DbType="VarChar(300) NOT NULL", CanBeNull=false)]
		public string contrasenaUsuario
		{
			get
			{
				return this._contrasenaUsuario;
			}
			set
			{
				if ((this._contrasenaUsuario != value))
				{
					this.OncontrasenaUsuarioChanging(value);
					this.SendPropertyChanging();
					this._contrasenaUsuario = value;
					this.SendPropertyChanged("contrasenaUsuario");
					this.OncontrasenaUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPersona", DbType="Int NOT NULL")]
		public int idPersona
		{
			get
			{
				return this._idPersona;
			}
			set
			{
				if ((this._idPersona != value))
				{
					if (this._Persona.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidPersonaChanging(value);
					this.SendPropertyChanging();
					this._idPersona = value;
					this.SendPropertyChanged("idPersona");
					this.OnidPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idRol", DbType="Int NOT NULL")]
		public int idRol
		{
			get
			{
				return this._idRol;
			}
			set
			{
				if ((this._idRol != value))
				{
					if (this._Rol.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidRolChanging(value);
					this.SendPropertyChanging();
					this._idRol = value;
					this.SendPropertyChanged("idRol");
					this.OnidRolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Auditor", Storage="_Auditor", ThisKey="idUsuario", OtherKey="idUsuario")]
		public EntitySet<Auditor> Auditor
		{
			get
			{
				return this._Auditor;
			}
			set
			{
				this._Auditor.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Rol_Usuario", Storage="_Rol", ThisKey="idRol", OtherKey="idRol", IsForeignKey=true)]
		public Rol Rol
		{
			get
			{
				return this._Rol.Entity;
			}
			set
			{
				Rol previousValue = this._Rol.Entity;
				if (((previousValue != value) 
							|| (this._Rol.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Rol.Entity = null;
						previousValue.Usuario.Remove(this);
					}
					this._Rol.Entity = value;
					if ((value != null))
					{
						value.Usuario.Add(this);
						this._idRol = value.idRol;
					}
					else
					{
						this._idRol = default(int);
					}
					this.SendPropertyChanged("Rol");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persona_Usuario", Storage="_Persona", ThisKey="idPersona", OtherKey="idPersona", IsForeignKey=true)]
		public Persona Persona
		{
			get
			{
				return this._Persona.Entity;
			}
			set
			{
				Persona previousValue = this._Persona.Entity;
				if (((previousValue != value) 
							|| (this._Persona.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Persona.Entity = null;
						previousValue.Usuario.Remove(this);
					}
					this._Persona.Entity = value;
					if ((value != null))
					{
						value.Usuario.Add(this);
						this._idPersona = value.idPersona;
					}
					else
					{
						this._idPersona = default(int);
					}
					this.SendPropertyChanged("Persona");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Auditor(Auditor entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Auditor(Auditor entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persona")]
	public partial class Persona : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idPersona;
		
		private string _nombresPersona;
		
		private string _apellidoPaternoPersona;
		
		private string _apellidoMaternoPersona;
		
		private string _callePersona;
		
		private int _cpPersona;
		
		private string _paisPersona;
		
		private int _numeroCallePersona;
		
		private string _coloniaPersona;
		
		private string _entidadFederativa;
		
		private string _perfilProfesional;
		
		private EntitySet<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPersonaChanging(int value);
    partial void OnidPersonaChanged();
    partial void OnnombresPersonaChanging(string value);
    partial void OnnombresPersonaChanged();
    partial void OnapellidoPaternoPersonaChanging(string value);
    partial void OnapellidoPaternoPersonaChanged();
    partial void OnapellidoMaternoPersonaChanging(string value);
    partial void OnapellidoMaternoPersonaChanged();
    partial void OncallePersonaChanging(string value);
    partial void OncallePersonaChanged();
    partial void OncpPersonaChanging(int value);
    partial void OncpPersonaChanged();
    partial void OnpaisPersonaChanging(string value);
    partial void OnpaisPersonaChanged();
    partial void OnnumeroCallePersonaChanging(int value);
    partial void OnnumeroCallePersonaChanged();
    partial void OncoloniaPersonaChanging(string value);
    partial void OncoloniaPersonaChanged();
    partial void OnentidadFederativaChanging(string value);
    partial void OnentidadFederativaChanged();
    partial void OnperfilProfesionalChanging(string value);
    partial void OnperfilProfesionalChanged();
    #endregion
		
		public Persona()
		{
			this._Usuario = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuario), new Action<Usuario>(this.detach_Usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPersona", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idPersona
		{
			get
			{
				return this._idPersona;
			}
			set
			{
				if ((this._idPersona != value))
				{
					this.OnidPersonaChanging(value);
					this.SendPropertyChanging();
					this._idPersona = value;
					this.SendPropertyChanged("idPersona");
					this.OnidPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombresPersona", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string nombresPersona
		{
			get
			{
				return this._nombresPersona;
			}
			set
			{
				if ((this._nombresPersona != value))
				{
					this.OnnombresPersonaChanging(value);
					this.SendPropertyChanging();
					this._nombresPersona = value;
					this.SendPropertyChanged("nombresPersona");
					this.OnnombresPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoPaternoPersona", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string apellidoPaternoPersona
		{
			get
			{
				return this._apellidoPaternoPersona;
			}
			set
			{
				if ((this._apellidoPaternoPersona != value))
				{
					this.OnapellidoPaternoPersonaChanging(value);
					this.SendPropertyChanging();
					this._apellidoPaternoPersona = value;
					this.SendPropertyChanged("apellidoPaternoPersona");
					this.OnapellidoPaternoPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidoMaternoPersona", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string apellidoMaternoPersona
		{
			get
			{
				return this._apellidoMaternoPersona;
			}
			set
			{
				if ((this._apellidoMaternoPersona != value))
				{
					this.OnapellidoMaternoPersonaChanging(value);
					this.SendPropertyChanging();
					this._apellidoMaternoPersona = value;
					this.SendPropertyChanged("apellidoMaternoPersona");
					this.OnapellidoMaternoPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_callePersona", DbType="Char(200) NOT NULL", CanBeNull=false)]
		public string callePersona
		{
			get
			{
				return this._callePersona;
			}
			set
			{
				if ((this._callePersona != value))
				{
					this.OncallePersonaChanging(value);
					this.SendPropertyChanging();
					this._callePersona = value;
					this.SendPropertyChanged("callePersona");
					this.OncallePersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpPersona", DbType="Int NOT NULL")]
		public int cpPersona
		{
			get
			{
				return this._cpPersona;
			}
			set
			{
				if ((this._cpPersona != value))
				{
					this.OncpPersonaChanging(value);
					this.SendPropertyChanging();
					this._cpPersona = value;
					this.SendPropertyChanged("cpPersona");
					this.OncpPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paisPersona", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string paisPersona
		{
			get
			{
				return this._paisPersona;
			}
			set
			{
				if ((this._paisPersona != value))
				{
					this.OnpaisPersonaChanging(value);
					this.SendPropertyChanging();
					this._paisPersona = value;
					this.SendPropertyChanged("paisPersona");
					this.OnpaisPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numeroCallePersona", DbType="Int NOT NULL")]
		public int numeroCallePersona
		{
			get
			{
				return this._numeroCallePersona;
			}
			set
			{
				if ((this._numeroCallePersona != value))
				{
					this.OnnumeroCallePersonaChanging(value);
					this.SendPropertyChanging();
					this._numeroCallePersona = value;
					this.SendPropertyChanged("numeroCallePersona");
					this.OnnumeroCallePersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_coloniaPersona", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string coloniaPersona
		{
			get
			{
				return this._coloniaPersona;
			}
			set
			{
				if ((this._coloniaPersona != value))
				{
					this.OncoloniaPersonaChanging(value);
					this.SendPropertyChanging();
					this._coloniaPersona = value;
					this.SendPropertyChanged("coloniaPersona");
					this.OncoloniaPersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_entidadFederativa", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string entidadFederativa
		{
			get
			{
				return this._entidadFederativa;
			}
			set
			{
				if ((this._entidadFederativa != value))
				{
					this.OnentidadFederativaChanging(value);
					this.SendPropertyChanging();
					this._entidadFederativa = value;
					this.SendPropertyChanged("entidadFederativa");
					this.OnentidadFederativaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_perfilProfesional", DbType="VarChar(200)")]
		public string perfilProfesional
		{
			get
			{
				return this._perfilProfesional;
			}
			set
			{
				if ((this._perfilProfesional != value))
				{
					this.OnperfilProfesionalChanging(value);
					this.SendPropertyChanging();
					this._perfilProfesional = value;
					this.SendPropertyChanged("perfilProfesional");
					this.OnperfilProfesionalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Persona_Usuario", Storage="_Usuario", ThisKey="idPersona", OtherKey="idPersona")]
		public EntitySet<Usuario> Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				this._Usuario.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Usuario(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Persona = this;
		}
		
		private void detach_Usuario(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Persona = null;
		}
	}
}
#pragma warning restore 1591