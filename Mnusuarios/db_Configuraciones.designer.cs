﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mnusuarios
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CONFIGURACIONES")]
	public partial class db_ConfiguracionesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertConfiguracion_empresa(Configuracion_empresa instance);
    partial void UpdateConfiguracion_empresa(Configuracion_empresa instance);
    partial void DeleteConfiguracion_empresa(Configuracion_empresa instance);
    #endregion
		
		public db_ConfiguracionesDataContext() : 
				base(global::Mnusuarios.Properties.Settings.Default.CONFIGURACIONESConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public db_ConfiguracionesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_ConfiguracionesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_ConfiguracionesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public db_ConfiguracionesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Configuracion_empresa> Configuracion_empresas
		{
			get
			{
				return this.GetTable<Configuracion_empresa>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Configuracion_empresas")]
	public partial class Configuracion_empresa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _numero_empresa;
		
		private string _nombre_empresa;
		
		private string _rfc;
		
		private string _nombre_servidor;
		
		private string _nombre_base_datos;
		
		private string _usuario_base_datos;
		
		private string _password_base_datos;
		
		private string _sistema;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onnumero_empresaChanging(int value);
    partial void Onnumero_empresaChanged();
    partial void Onnombre_empresaChanging(string value);
    partial void Onnombre_empresaChanged();
    partial void OnrfcChanging(string value);
    partial void OnrfcChanged();
    partial void Onnombre_servidorChanging(string value);
    partial void Onnombre_servidorChanged();
    partial void Onnombre_base_datosChanging(string value);
    partial void Onnombre_base_datosChanged();
    partial void Onusuario_base_datosChanging(string value);
    partial void Onusuario_base_datosChanged();
    partial void Onpassword_base_datosChanging(string value);
    partial void Onpassword_base_datosChanged();
    partial void OnsistemaChanging(string value);
    partial void OnsistemaChanged();
    #endregion
		
		public Configuracion_empresa()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero_empresa", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int numero_empresa
		{
			get
			{
				return this._numero_empresa;
			}
			set
			{
				if ((this._numero_empresa != value))
				{
					this.Onnumero_empresaChanging(value);
					this.SendPropertyChanging();
					this._numero_empresa = value;
					this.SendPropertyChanged("numero_empresa");
					this.Onnumero_empresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_empresa", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string nombre_empresa
		{
			get
			{
				return this._nombre_empresa;
			}
			set
			{
				if ((this._nombre_empresa != value))
				{
					this.Onnombre_empresaChanging(value);
					this.SendPropertyChanging();
					this._nombre_empresa = value;
					this.SendPropertyChanged("nombre_empresa");
					this.Onnombre_empresaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rfc", DbType="NChar(13) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string rfc
		{
			get
			{
				return this._rfc;
			}
			set
			{
				if ((this._rfc != value))
				{
					this.OnrfcChanging(value);
					this.SendPropertyChanging();
					this._rfc = value;
					this.SendPropertyChanged("rfc");
					this.OnrfcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_servidor", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string nombre_servidor
		{
			get
			{
				return this._nombre_servidor;
			}
			set
			{
				if ((this._nombre_servidor != value))
				{
					this.Onnombre_servidorChanging(value);
					this.SendPropertyChanging();
					this._nombre_servidor = value;
					this.SendPropertyChanged("nombre_servidor");
					this.Onnombre_servidorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_base_datos", DbType="NChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string nombre_base_datos
		{
			get
			{
				return this._nombre_base_datos;
			}
			set
			{
				if ((this._nombre_base_datos != value))
				{
					this.Onnombre_base_datosChanging(value);
					this.SendPropertyChanging();
					this._nombre_base_datos = value;
					this.SendPropertyChanged("nombre_base_datos");
					this.Onnombre_base_datosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_base_datos", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string usuario_base_datos
		{
			get
			{
				return this._usuario_base_datos;
			}
			set
			{
				if ((this._usuario_base_datos != value))
				{
					this.Onusuario_base_datosChanging(value);
					this.SendPropertyChanging();
					this._usuario_base_datos = value;
					this.SendPropertyChanged("usuario_base_datos");
					this.Onusuario_base_datosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password_base_datos", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string password_base_datos
		{
			get
			{
				return this._password_base_datos;
			}
			set
			{
				if ((this._password_base_datos != value))
				{
					this.Onpassword_base_datosChanging(value);
					this.SendPropertyChanging();
					this._password_base_datos = value;
					this.SendPropertyChanged("password_base_datos");
					this.Onpassword_base_datosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sistema", DbType="NChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string sistema
		{
			get
			{
				return this._sistema;
			}
			set
			{
				if ((this._sistema != value))
				{
					this.OnsistemaChanging(value);
					this.SendPropertyChanging();
					this._sistema = value;
					this.SendPropertyChanged("sistema");
					this.OnsistemaChanged();
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
}
#pragma warning restore 1591