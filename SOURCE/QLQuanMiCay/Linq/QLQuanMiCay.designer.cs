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

namespace Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLQuanMiCay")]
	public partial class QLQuanMiCayDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMon(Mon instance);
    partial void UpdateMon(Mon instance);
    partial void DeleteMon(Mon instance);
    #endregion
		
		public QLQuanMiCayDataContext() : 
				base(global::Linq.Properties.Settings.Default.QLQuanMiCayConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLQuanMiCayDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLQuanMiCayDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLQuanMiCayDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLQuanMiCayDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mon> Mons
		{
			get
			{
				return this.GetTable<Mon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mon")]
	public partial class Mon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _M_Ten;
		
		private int _DM_Id;
		
		private int _M_Gia;
		
		private string _M_IMG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnM_TenChanging(string value);
    partial void OnM_TenChanged();
    partial void OnDM_IdChanging(int value);
    partial void OnDM_IdChanged();
    partial void OnM_GiaChanging(int value);
    partial void OnM_GiaChanged();
    partial void OnM_IMGChanging(string value);
    partial void OnM_IMGChanged();
    #endregion
		
		public Mon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M_Ten", DbType="NVarChar(128) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string M_Ten
		{
			get
			{
				return this._M_Ten;
			}
			set
			{
				if ((this._M_Ten != value))
				{
					this.OnM_TenChanging(value);
					this.SendPropertyChanging();
					this._M_Ten = value;
					this.SendPropertyChanged("M_Ten");
					this.OnM_TenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DM_Id", DbType="Int NOT NULL")]
		public int DM_Id
		{
			get
			{
				return this._DM_Id;
			}
			set
			{
				if ((this._DM_Id != value))
				{
					this.OnDM_IdChanging(value);
					this.SendPropertyChanging();
					this._DM_Id = value;
					this.SendPropertyChanged("DM_Id");
					this.OnDM_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M_Gia", DbType="Int NOT NULL")]
		public int M_Gia
		{
			get
			{
				return this._M_Gia;
			}
			set
			{
				if ((this._M_Gia != value))
				{
					this.OnM_GiaChanging(value);
					this.SendPropertyChanging();
					this._M_Gia = value;
					this.SendPropertyChanged("M_Gia");
					this.OnM_GiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_M_IMG", DbType="NVarChar(MAX)")]
		public string M_IMG
		{
			get
			{
				return this._M_IMG;
			}
			set
			{
				if ((this._M_IMG != value))
				{
					this.OnM_IMGChanging(value);
					this.SendPropertyChanging();
					this._M_IMG = value;
					this.SendPropertyChanged("M_IMG");
					this.OnM_IMGChanged();
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
