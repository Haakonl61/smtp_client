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

namespace smtp_client
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ABGSC_DW")]
	public partial class SQLDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertsmtp_mail_batch(smtp_mail_batch instance);
    partial void Updatesmtp_mail_batch(smtp_mail_batch instance);
    partial void Deletesmtp_mail_batch(smtp_mail_batch instance);
    partial void Insertsmtp_mail_detail(smtp_mail_detail instance);
    partial void Updatesmtp_mail_detail(smtp_mail_detail instance);
    partial void Deletesmtp_mail_detail(smtp_mail_detail instance);
    partial void Insertsmtp_mail_batch_detail(smtp_mail_batch_detail instance);
    partial void Updatesmtp_mail_batch_detail(smtp_mail_batch_detail instance);
    partial void Deletesmtp_mail_batch_detail(smtp_mail_batch_detail instance);
    #endregion
		
		public SQLDataClassesDataContext() : 
				base(global::smtp_client.Settings.Default.ABGSC_DWConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<smtp_mail_batch> smtp_mail_batches
		{
			get
			{
				return this.GetTable<smtp_mail_batch>();
			}
		}
		
		public System.Data.Linq.Table<smtp_mail_detail> smtp_mail_details
		{
			get
			{
				return this.GetTable<smtp_mail_detail>();
			}
		}
		
		public System.Data.Linq.Table<smtp_mail_batch_detail> smtp_mail_batch_details
		{
			get
			{
				return this.GetTable<smtp_mail_batch_detail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.smtp_mail_batch")]
	public partial class smtp_mail_batch : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _smtp_server_host;
		
		private System.Nullable<int> _smtp_port;
		
		private string _smtp_user;
		
		private string _smtp_password;
		
		private string _description;
		
		private EntitySet<smtp_mail_detail> _smtp_mail_details;
		
		private EntitySet<smtp_mail_batch_detail> _smtp_mail_batch_details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void Onsmtp_server_hostChanging(string value);
    partial void Onsmtp_server_hostChanged();
    partial void Onsmtp_portChanging(System.Nullable<int> value);
    partial void Onsmtp_portChanged();
    partial void Onsmtp_userChanging(string value);
    partial void Onsmtp_userChanged();
    partial void Onsmtp_passwordChanging(string value);
    partial void Onsmtp_passwordChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public smtp_mail_batch()
		{
			this._smtp_mail_details = new EntitySet<smtp_mail_detail>(new Action<smtp_mail_detail>(this.attach_smtp_mail_details), new Action<smtp_mail_detail>(this.detach_smtp_mail_details));
			this._smtp_mail_batch_details = new EntitySet<smtp_mail_batch_detail>(new Action<smtp_mail_batch_detail>(this.attach_smtp_mail_batch_details), new Action<smtp_mail_batch_detail>(this.detach_smtp_mail_batch_details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smtp_server_host", DbType="VarChar(1024)")]
		public string smtp_server_host
		{
			get
			{
				return this._smtp_server_host;
			}
			set
			{
				if ((this._smtp_server_host != value))
				{
					this.Onsmtp_server_hostChanging(value);
					this.SendPropertyChanging();
					this._smtp_server_host = value;
					this.SendPropertyChanged("smtp_server_host");
					this.Onsmtp_server_hostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smtp_port", DbType="Int")]
		public System.Nullable<int> smtp_port
		{
			get
			{
				return this._smtp_port;
			}
			set
			{
				if ((this._smtp_port != value))
				{
					this.Onsmtp_portChanging(value);
					this.SendPropertyChanging();
					this._smtp_port = value;
					this.SendPropertyChanged("smtp_port");
					this.Onsmtp_portChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smtp_user", DbType="VarChar(1024)")]
		public string smtp_user
		{
			get
			{
				return this._smtp_user;
			}
			set
			{
				if ((this._smtp_user != value))
				{
					this.Onsmtp_userChanging(value);
					this.SendPropertyChanging();
					this._smtp_user = value;
					this.SendPropertyChanged("smtp_user");
					this.Onsmtp_userChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smtp_password", DbType="VarChar(1024)")]
		public string smtp_password
		{
			get
			{
				return this._smtp_password;
			}
			set
			{
				if ((this._smtp_password != value))
				{
					this.Onsmtp_passwordChanging(value);
					this.SendPropertyChanging();
					this._smtp_password = value;
					this.SendPropertyChanged("smtp_password");
					this.Onsmtp_passwordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(1024)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="smtp_mail_batch_smtp_mail_detail", Storage="_smtp_mail_details", ThisKey="ID", OtherKey="smtp_mail_batch_id")]
		public EntitySet<smtp_mail_detail> smtp_mail_details
		{
			get
			{
				return this._smtp_mail_details;
			}
			set
			{
				this._smtp_mail_details.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="smtp_mail_batch_smtp_mail_batch_detail", Storage="_smtp_mail_batch_details", ThisKey="ID", OtherKey="batch_ID")]
		public EntitySet<smtp_mail_batch_detail> smtp_mail_batch_details
		{
			get
			{
				return this._smtp_mail_batch_details;
			}
			set
			{
				this._smtp_mail_batch_details.Assign(value);
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
		
		private void attach_smtp_mail_details(smtp_mail_detail entity)
		{
			this.SendPropertyChanging();
			entity.smtp_mail_batch = this;
		}
		
		private void detach_smtp_mail_details(smtp_mail_detail entity)
		{
			this.SendPropertyChanging();
			entity.smtp_mail_batch = null;
		}
		
		private void attach_smtp_mail_batch_details(smtp_mail_batch_detail entity)
		{
			this.SendPropertyChanging();
			entity.smtp_mail_batch = this;
		}
		
		private void detach_smtp_mail_batch_details(smtp_mail_batch_detail entity)
		{
			this.SendPropertyChanging();
			entity.smtp_mail_batch = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.smtp_mail_details")]
	public partial class smtp_mail_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _smtp_mail_batch_id;
		
		private string _mime_mail_to_list;
		
		private string _mime_mail_to_name_list;
		
		private string _mime_attachment_list;
		
		private EntityRef<smtp_mail_batch> _smtp_mail_batch;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void Onsmtp_mail_batch_idChanging(System.Nullable<int> value);
    partial void Onsmtp_mail_batch_idChanged();
    partial void Onmime_mail_to_listChanging(string value);
    partial void Onmime_mail_to_listChanged();
    partial void Onmime_mail_to_name_listChanging(string value);
    partial void Onmime_mail_to_name_listChanged();
    partial void Onmime_attachment_listChanging(string value);
    partial void Onmime_attachment_listChanged();
    #endregion
		
		public smtp_mail_detail()
		{
			this._smtp_mail_batch = default(EntityRef<smtp_mail_batch>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smtp_mail_batch_id", DbType="Int")]
		public System.Nullable<int> smtp_mail_batch_id
		{
			get
			{
				return this._smtp_mail_batch_id;
			}
			set
			{
				if ((this._smtp_mail_batch_id != value))
				{
					if (this._smtp_mail_batch.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsmtp_mail_batch_idChanging(value);
					this.SendPropertyChanging();
					this._smtp_mail_batch_id = value;
					this.SendPropertyChanged("smtp_mail_batch_id");
					this.Onsmtp_mail_batch_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_mail_to_list", DbType="VarChar(1024)")]
		public string mime_mail_to_list
		{
			get
			{
				return this._mime_mail_to_list;
			}
			set
			{
				if ((this._mime_mail_to_list != value))
				{
					this.Onmime_mail_to_listChanging(value);
					this.SendPropertyChanging();
					this._mime_mail_to_list = value;
					this.SendPropertyChanged("mime_mail_to_list");
					this.Onmime_mail_to_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_mail_to_name_list", DbType="VarChar(1024)")]
		public string mime_mail_to_name_list
		{
			get
			{
				return this._mime_mail_to_name_list;
			}
			set
			{
				if ((this._mime_mail_to_name_list != value))
				{
					this.Onmime_mail_to_name_listChanging(value);
					this.SendPropertyChanging();
					this._mime_mail_to_name_list = value;
					this.SendPropertyChanged("mime_mail_to_name_list");
					this.Onmime_mail_to_name_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_attachment_list", DbType="VarChar(1024)")]
		public string mime_attachment_list
		{
			get
			{
				return this._mime_attachment_list;
			}
			set
			{
				if ((this._mime_attachment_list != value))
				{
					this.Onmime_attachment_listChanging(value);
					this.SendPropertyChanging();
					this._mime_attachment_list = value;
					this.SendPropertyChanged("mime_attachment_list");
					this.Onmime_attachment_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="smtp_mail_batch_smtp_mail_detail", Storage="_smtp_mail_batch", ThisKey="smtp_mail_batch_id", OtherKey="ID", IsForeignKey=true)]
		public smtp_mail_batch smtp_mail_batch
		{
			get
			{
				return this._smtp_mail_batch.Entity;
			}
			set
			{
				smtp_mail_batch previousValue = this._smtp_mail_batch.Entity;
				if (((previousValue != value) 
							|| (this._smtp_mail_batch.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._smtp_mail_batch.Entity = null;
						previousValue.smtp_mail_details.Remove(this);
					}
					this._smtp_mail_batch.Entity = value;
					if ((value != null))
					{
						value.smtp_mail_details.Add(this);
						this._smtp_mail_batch_id = value.ID;
					}
					else
					{
						this._smtp_mail_batch_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("smtp_mail_batch");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.smtp_mail_batch_details")]
	public partial class smtp_mail_batch_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _batch_ID;
		
		private string _mime_sender;
		
		private string _mime_sender_name;
		
		private string _mime_from_list;
		
		private string _mime_from_name_list;
		
		private string _mime_cc_list;
		
		private string _mime_bcc_list;
		
		private string _mime_textpart;
		
		private string _mime_htmlpart;
		
		private string _mime_subject;
		
		private EntityRef<smtp_mail_batch> _smtp_mail_batch;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void Onbatch_IDChanging(System.Nullable<int> value);
    partial void Onbatch_IDChanged();
    partial void Onmime_senderChanging(string value);
    partial void Onmime_senderChanged();
    partial void Onmime_sender_nameChanging(string value);
    partial void Onmime_sender_nameChanged();
    partial void Onmime_from_listChanging(string value);
    partial void Onmime_from_listChanged();
    partial void Onmime_from_name_listChanging(string value);
    partial void Onmime_from_name_listChanged();
    partial void Onmime_cc_listChanging(string value);
    partial void Onmime_cc_listChanged();
    partial void Onmime_bcc_listChanging(string value);
    partial void Onmime_bcc_listChanged();
    partial void Onmime_textpartChanging(string value);
    partial void Onmime_textpartChanged();
    partial void Onmime_htmlpartChanging(string value);
    partial void Onmime_htmlpartChanged();
    partial void Onmime_subjectChanging(string value);
    partial void Onmime_subjectChanged();
    #endregion
		
		public smtp_mail_batch_detail()
		{
			this._smtp_mail_batch = default(EntityRef<smtp_mail_batch>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_batch_ID", DbType="Int")]
		public System.Nullable<int> batch_ID
		{
			get
			{
				return this._batch_ID;
			}
			set
			{
				if ((this._batch_ID != value))
				{
					if (this._smtp_mail_batch.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onbatch_IDChanging(value);
					this.SendPropertyChanging();
					this._batch_ID = value;
					this.SendPropertyChanged("batch_ID");
					this.Onbatch_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_sender", DbType="VarChar(1024)")]
		public string mime_sender
		{
			get
			{
				return this._mime_sender;
			}
			set
			{
				if ((this._mime_sender != value))
				{
					this.Onmime_senderChanging(value);
					this.SendPropertyChanging();
					this._mime_sender = value;
					this.SendPropertyChanged("mime_sender");
					this.Onmime_senderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_sender_name", DbType="VarChar(1024)")]
		public string mime_sender_name
		{
			get
			{
				return this._mime_sender_name;
			}
			set
			{
				if ((this._mime_sender_name != value))
				{
					this.Onmime_sender_nameChanging(value);
					this.SendPropertyChanging();
					this._mime_sender_name = value;
					this.SendPropertyChanged("mime_sender_name");
					this.Onmime_sender_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_from_list", DbType="VarChar(1024)")]
		public string mime_from_list
		{
			get
			{
				return this._mime_from_list;
			}
			set
			{
				if ((this._mime_from_list != value))
				{
					this.Onmime_from_listChanging(value);
					this.SendPropertyChanging();
					this._mime_from_list = value;
					this.SendPropertyChanged("mime_from_list");
					this.Onmime_from_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_from_name_list", DbType="VarChar(1024)")]
		public string mime_from_name_list
		{
			get
			{
				return this._mime_from_name_list;
			}
			set
			{
				if ((this._mime_from_name_list != value))
				{
					this.Onmime_from_name_listChanging(value);
					this.SendPropertyChanging();
					this._mime_from_name_list = value;
					this.SendPropertyChanged("mime_from_name_list");
					this.Onmime_from_name_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_cc_list", DbType="VarChar(1024)")]
		public string mime_cc_list
		{
			get
			{
				return this._mime_cc_list;
			}
			set
			{
				if ((this._mime_cc_list != value))
				{
					this.Onmime_cc_listChanging(value);
					this.SendPropertyChanging();
					this._mime_cc_list = value;
					this.SendPropertyChanged("mime_cc_list");
					this.Onmime_cc_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_bcc_list", DbType="VarChar(1024)")]
		public string mime_bcc_list
		{
			get
			{
				return this._mime_bcc_list;
			}
			set
			{
				if ((this._mime_bcc_list != value))
				{
					this.Onmime_bcc_listChanging(value);
					this.SendPropertyChanging();
					this._mime_bcc_list = value;
					this.SendPropertyChanged("mime_bcc_list");
					this.Onmime_bcc_listChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_textpart", DbType="VarChar(2048)")]
		public string mime_textpart
		{
			get
			{
				return this._mime_textpart;
			}
			set
			{
				if ((this._mime_textpart != value))
				{
					this.Onmime_textpartChanging(value);
					this.SendPropertyChanging();
					this._mime_textpart = value;
					this.SendPropertyChanged("mime_textpart");
					this.Onmime_textpartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_htmlpart", DbType="VarChar(2048)")]
		public string mime_htmlpart
		{
			get
			{
				return this._mime_htmlpart;
			}
			set
			{
				if ((this._mime_htmlpart != value))
				{
					this.Onmime_htmlpartChanging(value);
					this.SendPropertyChanging();
					this._mime_htmlpart = value;
					this.SendPropertyChanged("mime_htmlpart");
					this.Onmime_htmlpartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mime_subject", DbType="VarChar(1024)")]
		public string mime_subject
		{
			get
			{
				return this._mime_subject;
			}
			set
			{
				if ((this._mime_subject != value))
				{
					this.Onmime_subjectChanging(value);
					this.SendPropertyChanging();
					this._mime_subject = value;
					this.SendPropertyChanged("mime_subject");
					this.Onmime_subjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="smtp_mail_batch_smtp_mail_batch_detail", Storage="_smtp_mail_batch", ThisKey="batch_ID", OtherKey="ID", IsForeignKey=true)]
		public smtp_mail_batch smtp_mail_batch
		{
			get
			{
				return this._smtp_mail_batch.Entity;
			}
			set
			{
				smtp_mail_batch previousValue = this._smtp_mail_batch.Entity;
				if (((previousValue != value) 
							|| (this._smtp_mail_batch.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._smtp_mail_batch.Entity = null;
						previousValue.smtp_mail_batch_details.Remove(this);
					}
					this._smtp_mail_batch.Entity = value;
					if ((value != null))
					{
						value.smtp_mail_batch_details.Add(this);
						this._batch_ID = value.ID;
					}
					else
					{
						this._batch_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("smtp_mail_batch");
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
