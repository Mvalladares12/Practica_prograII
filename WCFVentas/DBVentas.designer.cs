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

namespace WCFVentas
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ventas_progra2")]
	public partial class DBVentasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertVentas(Ventas instance);
    partial void UpdateVentas(Ventas instance);
    partial void DeleteVentas(Ventas instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    #endregion
		
		public DBVentasDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Ventas_progra2ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBVentasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBVentasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBVentasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBVentasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ventas> Ventas
		{
			get
			{
				return this.GetTable<Ventas>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<V_ventas> V_ventas
		{
			get
			{
				return this.GetTable<V_ventas>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_InsertarVenta")]
		public int SP_InsertarVenta([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaVenta", DbType="DateTime")] System.Nullable<System.DateTime> fechaVenta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaInserta", DbType="DateTime")] System.Nullable<System.DateTime> fechaInserta, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string cliente, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string vendedor)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_producto, fechaVenta, fechaInserta, cliente, cantidad, vendedor);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_InsertarUsuario")]
		public int SP_InsertarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string usuarioinserta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaInserta", DbType="DateTime")] System.Nullable<System.DateTime> fechaInserta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre_user", DbType="VarChar(50)")] string nombre_user)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contraseña, usuarioinserta, fechaInserta, nombre_user);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_EditarUsuario")]
		public ISingleResult<SP_EditarUsuarioResult> SP_EditarUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> idusuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string contraseña, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string usuarioinserta, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre_user", DbType="VarChar(50)")] string nombre_user, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string usuario_act)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), idusuario, usuario, contraseña, usuarioinserta, nombre_user, usuario_act);
			return ((ISingleResult<SP_EditarUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_EliminarUser")]
		public int SP_EliminarUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_usuario)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_usuario);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ventas")]
	public partial class Ventas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_venta;
		
		private System.Nullable<int> _id_producto;
		
		private System.Nullable<System.DateTime> _Fecha_venta;
		
		private string _Usuario_venta;
		
		private System.Nullable<int> _Cantidad;
		
		private string _usuario_inserta;
		
		private System.Nullable<System.DateTime> _fecha_inserta;
		
		private string _usuario_actualiza;
		
		private System.Nullable<System.DateTime> _fecha_actualiza;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_ventaChanging(int value);
    partial void Onid_ventaChanged();
    partial void Onid_productoChanging(System.Nullable<int> value);
    partial void Onid_productoChanged();
    partial void OnFecha_ventaChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_ventaChanged();
    partial void OnUsuario_ventaChanging(string value);
    partial void OnUsuario_ventaChanged();
    partial void OnCantidadChanging(System.Nullable<int> value);
    partial void OnCantidadChanged();
    partial void Onusuario_insertaChanging(string value);
    partial void Onusuario_insertaChanged();
    partial void Onfecha_insertaChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_insertaChanged();
    partial void Onusuario_actualizaChanging(string value);
    partial void Onusuario_actualizaChanged();
    partial void Onfecha_actualizaChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_actualizaChanged();
    #endregion
		
		public Ventas()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_venta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_venta
		{
			get
			{
				return this._id_venta;
			}
			set
			{
				if ((this._id_venta != value))
				{
					this.Onid_ventaChanging(value);
					this.SendPropertyChanging();
					this._id_venta = value;
					this.SendPropertyChanged("id_venta");
					this.Onid_ventaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_producto", DbType="Int")]
		public System.Nullable<int> id_producto
		{
			get
			{
				return this._id_producto;
			}
			set
			{
				if ((this._id_producto != value))
				{
					this.Onid_productoChanging(value);
					this.SendPropertyChanging();
					this._id_producto = value;
					this.SendPropertyChanged("id_producto");
					this.Onid_productoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_venta", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_venta
		{
			get
			{
				return this._Fecha_venta;
			}
			set
			{
				if ((this._Fecha_venta != value))
				{
					this.OnFecha_ventaChanging(value);
					this.SendPropertyChanging();
					this._Fecha_venta = value;
					this.SendPropertyChanged("Fecha_venta");
					this.OnFecha_ventaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario_venta", DbType="VarChar(50)")]
		public string Usuario_venta
		{
			get
			{
				return this._Usuario_venta;
			}
			set
			{
				if ((this._Usuario_venta != value))
				{
					this.OnUsuario_ventaChanging(value);
					this.SendPropertyChanging();
					this._Usuario_venta = value;
					this.SendPropertyChanged("Usuario_venta");
					this.OnUsuario_ventaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="Int")]
		public System.Nullable<int> Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this.OnCantidadChanging(value);
					this.SendPropertyChanging();
					this._Cantidad = value;
					this.SendPropertyChanged("Cantidad");
					this.OnCantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_inserta", DbType="VarChar(50)")]
		public string usuario_inserta
		{
			get
			{
				return this._usuario_inserta;
			}
			set
			{
				if ((this._usuario_inserta != value))
				{
					this.Onusuario_insertaChanging(value);
					this.SendPropertyChanging();
					this._usuario_inserta = value;
					this.SendPropertyChanged("usuario_inserta");
					this.Onusuario_insertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_inserta", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_inserta
		{
			get
			{
				return this._fecha_inserta;
			}
			set
			{
				if ((this._fecha_inserta != value))
				{
					this.Onfecha_insertaChanging(value);
					this.SendPropertyChanging();
					this._fecha_inserta = value;
					this.SendPropertyChanged("fecha_inserta");
					this.Onfecha_insertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_actualiza", DbType="VarChar(50)")]
		public string usuario_actualiza
		{
			get
			{
				return this._usuario_actualiza;
			}
			set
			{
				if ((this._usuario_actualiza != value))
				{
					this.Onusuario_actualizaChanging(value);
					this.SendPropertyChanging();
					this._usuario_actualiza = value;
					this.SendPropertyChanged("usuario_actualiza");
					this.Onusuario_actualizaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_actualiza", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_actualiza
		{
			get
			{
				return this._fecha_actualiza;
			}
			set
			{
				if ((this._fecha_actualiza != value))
				{
					this.Onfecha_actualizaChanging(value);
					this.SendPropertyChanging();
					this._fecha_actualiza = value;
					this.SendPropertyChanged("fecha_actualiza");
					this.Onfecha_actualizaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_usuario;
		
		private string _Usuario;
		
		private string _Contraseña;
		
		private string _usuario_inserta;
		
		private System.Nullable<System.DateTime> _fecha_inserta;
		
		private string _usuario_actualiza;
		
		private System.Nullable<System.DateTime> _fecha_actualiza;
		
		private string _Nombre_usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContraseñaChanging(string value);
    partial void OnContraseñaChanged();
    partial void Onusuario_insertaChanging(string value);
    partial void Onusuario_insertaChanged();
    partial void Onfecha_insertaChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_insertaChanged();
    partial void Onusuario_actualizaChanging(string value);
    partial void Onusuario_actualizaChanged();
    partial void Onfecha_actualizaChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_actualizaChanged();
    partial void OnNombre_usuarioChanging(string value);
    partial void OnNombre_usuarioChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(50)")]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contraseña", DbType="VarChar(20)")]
		public string Contraseña
		{
			get
			{
				return this._Contraseña;
			}
			set
			{
				if ((this._Contraseña != value))
				{
					this.OnContraseñaChanging(value);
					this.SendPropertyChanging();
					this._Contraseña = value;
					this.SendPropertyChanged("Contraseña");
					this.OnContraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_inserta", DbType="VarChar(50)")]
		public string usuario_inserta
		{
			get
			{
				return this._usuario_inserta;
			}
			set
			{
				if ((this._usuario_inserta != value))
				{
					this.Onusuario_insertaChanging(value);
					this.SendPropertyChanging();
					this._usuario_inserta = value;
					this.SendPropertyChanged("usuario_inserta");
					this.Onusuario_insertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_inserta", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_inserta
		{
			get
			{
				return this._fecha_inserta;
			}
			set
			{
				if ((this._fecha_inserta != value))
				{
					this.Onfecha_insertaChanging(value);
					this.SendPropertyChanging();
					this._fecha_inserta = value;
					this.SendPropertyChanged("fecha_inserta");
					this.Onfecha_insertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_actualiza", DbType="VarChar(50)")]
		public string usuario_actualiza
		{
			get
			{
				return this._usuario_actualiza;
			}
			set
			{
				if ((this._usuario_actualiza != value))
				{
					this.Onusuario_actualizaChanging(value);
					this.SendPropertyChanging();
					this._usuario_actualiza = value;
					this.SendPropertyChanged("usuario_actualiza");
					this.Onusuario_actualizaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_actualiza", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_actualiza
		{
			get
			{
				return this._fecha_actualiza;
			}
			set
			{
				if ((this._fecha_actualiza != value))
				{
					this.Onfecha_actualizaChanging(value);
					this.SendPropertyChanging();
					this._fecha_actualiza = value;
					this.SendPropertyChanged("fecha_actualiza");
					this.Onfecha_actualizaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre_usuario", DbType="VarChar(50)")]
		public string Nombre_usuario
		{
			get
			{
				return this._Nombre_usuario;
			}
			set
			{
				if ((this._Nombre_usuario != value))
				{
					this.OnNombre_usuarioChanging(value);
					this.SendPropertyChanging();
					this._Nombre_usuario = value;
					this.SendPropertyChanged("Nombre_usuario");
					this.OnNombre_usuarioChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.V_ventas")]
	public partial class V_ventas
	{
		
		private int _id_venta;
		
		private string _Nombre_producto;
		
		private System.Nullable<System.DateTime> _Fecha_venta;
		
		private string _usuario_inserta;
		
		public V_ventas()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_venta", DbType="Int NOT NULL")]
		public int id_venta
		{
			get
			{
				return this._id_venta;
			}
			set
			{
				if ((this._id_venta != value))
				{
					this._id_venta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre_producto", DbType="VarChar(30)")]
		public string Nombre_producto
		{
			get
			{
				return this._Nombre_producto;
			}
			set
			{
				if ((this._Nombre_producto != value))
				{
					this._Nombre_producto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_venta", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_venta
		{
			get
			{
				return this._Fecha_venta;
			}
			set
			{
				if ((this._Fecha_venta != value))
				{
					this._Fecha_venta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario_inserta", DbType="VarChar(50)")]
		public string usuario_inserta
		{
			get
			{
				return this._usuario_inserta;
			}
			set
			{
				if ((this._usuario_inserta != value))
				{
					this._usuario_inserta = value;
				}
			}
		}
	}
	
	public partial class SP_EditarUsuarioResult
	{
		
		private string _Error;
		
		public SP_EditarUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Error", DbType="NVarChar(4000)")]
		public string Error
		{
			get
			{
				return this._Error;
			}
			set
			{
				if ((this._Error != value))
				{
					this._Error = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
