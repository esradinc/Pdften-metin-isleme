﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yazlab3
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="yazlab")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertpdflertablosu2(pdflertablosu2 instance);
    partial void Updatepdflertablosu2(pdflertablosu2 instance);
    partial void Deletepdflertablosu2(pdflertablosu2 instance);
    partial void Insertkullanicilartablosu(kullanicilartablosu instance);
    partial void Updatekullanicilartablosu(kullanicilartablosu instance);
    partial void Deletekullanicilartablosu(kullanicilartablosu instance);
    partial void Insertpdflertablosu(pdflertablosu instance);
    partial void Updatepdflertablosu(pdflertablosu instance);
    partial void Deletepdflertablosu(pdflertablosu instance);
    partial void Insertbolumlertablosu(bolumlertablosu instance);
    partial void Updatebolumlertablosu(bolumlertablosu instance);
    partial void Deletebolumlertablosu(bolumlertablosu instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["yazlabConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<pdflertablosu2> pdflertablosu2
		{
			get
			{
				return this.GetTable<pdflertablosu2>();
			}
		}
		
		public System.Data.Linq.Table<kullanicilartablosu> kullanicilartablosu
		{
			get
			{
				return this.GetTable<kullanicilartablosu>();
			}
		}
		
		public System.Data.Linq.Table<pdflertablosu> pdflertablosu
		{
			get
			{
				return this.GetTable<pdflertablosu>();
			}
		}
		
		public System.Data.Linq.Table<bolumlertablosu> bolumlertablosu
		{
			get
			{
				return this.GetTable<bolumlertablosu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pdflertablosu2")]
	public partial class pdflertablosu2 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pdfid;
		
		private string _dosyaadi;
		
		private string _dosyakonumu;
		
		private string _kullaniciid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpdfidChanging(int value);
    partial void OnpdfidChanged();
    partial void OndosyaadiChanging(string value);
    partial void OndosyaadiChanged();
    partial void OndosyakonumuChanging(string value);
    partial void OndosyakonumuChanged();
    partial void OnkullaniciidChanging(string value);
    partial void OnkullaniciidChanged();
    #endregion
		
		public pdflertablosu2()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pdfid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pdfid
		{
			get
			{
				return this._pdfid;
			}
			set
			{
				if ((this._pdfid != value))
				{
					this.OnpdfidChanging(value);
					this.SendPropertyChanging();
					this._pdfid = value;
					this.SendPropertyChanged("pdfid");
					this.OnpdfidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosyaadi", DbType="NVarChar(50)")]
		public string dosyaadi
		{
			get
			{
				return this._dosyaadi;
			}
			set
			{
				if ((this._dosyaadi != value))
				{
					this.OndosyaadiChanging(value);
					this.SendPropertyChanging();
					this._dosyaadi = value;
					this.SendPropertyChanged("dosyaadi");
					this.OndosyaadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosyakonumu", DbType="NVarChar(1000)")]
		public string dosyakonumu
		{
			get
			{
				return this._dosyakonumu;
			}
			set
			{
				if ((this._dosyakonumu != value))
				{
					this.OndosyakonumuChanging(value);
					this.SendPropertyChanging();
					this._dosyakonumu = value;
					this.SendPropertyChanged("dosyakonumu");
					this.OndosyakonumuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullaniciid", DbType="NVarChar(50)")]
		public string kullaniciid
		{
			get
			{
				return this._kullaniciid;
			}
			set
			{
				if ((this._kullaniciid != value))
				{
					this.OnkullaniciidChanging(value);
					this.SendPropertyChanging();
					this._kullaniciid = value;
					this.SendPropertyChanged("kullaniciid");
					this.OnkullaniciidChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.kullanicilartablosu")]
	public partial class kullanicilartablosu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _kullaniciid;
		
		private string _kullaniciadi;
		
		private string _sifre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnkullaniciidChanging(string value);
    partial void OnkullaniciidChanged();
    partial void OnkullaniciadiChanging(string value);
    partial void OnkullaniciadiChanged();
    partial void OnsifreChanging(string value);
    partial void OnsifreChanged();
    #endregion
		
		public kullanicilartablosu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullaniciid", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string kullaniciid
		{
			get
			{
				return this._kullaniciid;
			}
			set
			{
				if ((this._kullaniciid != value))
				{
					this.OnkullaniciidChanging(value);
					this.SendPropertyChanging();
					this._kullaniciid = value;
					this.SendPropertyChanged("kullaniciid");
					this.OnkullaniciidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullaniciadi", DbType="VarChar(50)")]
		public string kullaniciadi
		{
			get
			{
				return this._kullaniciadi;
			}
			set
			{
				if ((this._kullaniciadi != value))
				{
					this.OnkullaniciadiChanging(value);
					this.SendPropertyChanging();
					this._kullaniciadi = value;
					this.SendPropertyChanged("kullaniciadi");
					this.OnkullaniciadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sifre", DbType="VarChar(50)")]
		public string sifre
		{
			get
			{
				return this._sifre;
			}
			set
			{
				if ((this._sifre != value))
				{
					this.OnsifreChanging(value);
					this.SendPropertyChanging();
					this._sifre = value;
					this.SendPropertyChanged("sifre");
					this.OnsifreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.pdflertablosu")]
	public partial class pdflertablosu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _pdfid;
		
		private string _dosyaadi;
		
		private string _dosyakonumu;
		
		private string _kullaniciid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpdfidChanging(string value);
    partial void OnpdfidChanged();
    partial void OndosyaadiChanging(string value);
    partial void OndosyaadiChanged();
    partial void OndosyakonumuChanging(string value);
    partial void OndosyakonumuChanged();
    partial void OnkullaniciidChanging(string value);
    partial void OnkullaniciidChanged();
    #endregion
		
		public pdflertablosu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pdfid", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string pdfid
		{
			get
			{
				return this._pdfid;
			}
			set
			{
				if ((this._pdfid != value))
				{
					this.OnpdfidChanging(value);
					this.SendPropertyChanging();
					this._pdfid = value;
					this.SendPropertyChanged("pdfid");
					this.OnpdfidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosyaadi", DbType="NVarChar(50)")]
		public string dosyaadi
		{
			get
			{
				return this._dosyaadi;
			}
			set
			{
				if ((this._dosyaadi != value))
				{
					this.OndosyaadiChanging(value);
					this.SendPropertyChanging();
					this._dosyaadi = value;
					this.SendPropertyChanged("dosyaadi");
					this.OndosyaadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dosyakonumu", DbType="NVarChar(1000)")]
		public string dosyakonumu
		{
			get
			{
				return this._dosyakonumu;
			}
			set
			{
				if ((this._dosyakonumu != value))
				{
					this.OndosyakonumuChanging(value);
					this.SendPropertyChanging();
					this._dosyakonumu = value;
					this.SendPropertyChanged("dosyakonumu");
					this.OndosyakonumuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kullaniciid", DbType="NVarChar(50)")]
		public string kullaniciid
		{
			get
			{
				return this._kullaniciid;
			}
			set
			{
				if ((this._kullaniciid != value))
				{
					this.OnkullaniciidChanging(value);
					this.SendPropertyChanging();
					this._kullaniciid = value;
					this.SendPropertyChanged("kullaniciid");
					this.OnkullaniciidChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bolumlertablosu")]
	public partial class bolumlertablosu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _projeid;
		
		private string _adisoyadi;
		
		private string _ograncino;
		
		private string _dersadi;
		
		private string _ozet;
		
		private string _tarih;
		
		private string _anahtarkelimeler;
		
		private string _danisman;
		
		private string _juri;
		
		private string _baslik;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnprojeidChanging(int value);
    partial void OnprojeidChanged();
    partial void OnadisoyadiChanging(string value);
    partial void OnadisoyadiChanged();
    partial void OnograncinoChanging(string value);
    partial void OnograncinoChanged();
    partial void OndersadiChanging(string value);
    partial void OndersadiChanged();
    partial void OnozetChanging(string value);
    partial void OnozetChanged();
    partial void OntarihChanging(string value);
    partial void OntarihChanged();
    partial void OnanahtarkelimelerChanging(string value);
    partial void OnanahtarkelimelerChanged();
    partial void OndanismanChanging(string value);
    partial void OndanismanChanged();
    partial void OnjuriChanging(string value);
    partial void OnjuriChanged();
    partial void OnbaslikChanging(string value);
    partial void OnbaslikChanged();
    #endregion
		
		public bolumlertablosu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projeid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int projeid
		{
			get
			{
				return this._projeid;
			}
			set
			{
				if ((this._projeid != value))
				{
					this.OnprojeidChanging(value);
					this.SendPropertyChanging();
					this._projeid = value;
					this.SendPropertyChanged("projeid");
					this.OnprojeidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adisoyadi", DbType="NVarChar(50)")]
		public string adisoyadi
		{
			get
			{
				return this._adisoyadi;
			}
			set
			{
				if ((this._adisoyadi != value))
				{
					this.OnadisoyadiChanging(value);
					this.SendPropertyChanging();
					this._adisoyadi = value;
					this.SendPropertyChanged("adisoyadi");
					this.OnadisoyadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ograncino", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ograncino
		{
			get
			{
				return this._ograncino;
			}
			set
			{
				if ((this._ograncino != value))
				{
					this.OnograncinoChanging(value);
					this.SendPropertyChanging();
					this._ograncino = value;
					this.SendPropertyChanged("ograncino");
					this.OnograncinoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dersadi", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string dersadi
		{
			get
			{
				return this._dersadi;
			}
			set
			{
				if ((this._dersadi != value))
				{
					this.OndersadiChanging(value);
					this.SendPropertyChanging();
					this._dersadi = value;
					this.SendPropertyChanged("dersadi");
					this.OndersadiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ozet", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string ozet
		{
			get
			{
				return this._ozet;
			}
			set
			{
				if ((this._ozet != value))
				{
					this.OnozetChanging(value);
					this.SendPropertyChanging();
					this._ozet = value;
					this.SendPropertyChanged("ozet");
					this.OnozetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tarih", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string tarih
		{
			get
			{
				return this._tarih;
			}
			set
			{
				if ((this._tarih != value))
				{
					this.OntarihChanging(value);
					this.SendPropertyChanging();
					this._tarih = value;
					this.SendPropertyChanged("tarih");
					this.OntarihChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anahtarkelimeler", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string anahtarkelimeler
		{
			get
			{
				return this._anahtarkelimeler;
			}
			set
			{
				if ((this._anahtarkelimeler != value))
				{
					this.OnanahtarkelimelerChanging(value);
					this.SendPropertyChanging();
					this._anahtarkelimeler = value;
					this.SendPropertyChanged("anahtarkelimeler");
					this.OnanahtarkelimelerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_danisman", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string danisman
		{
			get
			{
				return this._danisman;
			}
			set
			{
				if ((this._danisman != value))
				{
					this.OndanismanChanging(value);
					this.SendPropertyChanging();
					this._danisman = value;
					this.SendPropertyChanged("danisman");
					this.OndanismanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_juri", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string juri
		{
			get
			{
				return this._juri;
			}
			set
			{
				if ((this._juri != value))
				{
					this.OnjuriChanging(value);
					this.SendPropertyChanging();
					this._juri = value;
					this.SendPropertyChanged("juri");
					this.OnjuriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_baslik", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string baslik
		{
			get
			{
				return this._baslik;
			}
			set
			{
				if ((this._baslik != value))
				{
					this.OnbaslikChanging(value);
					this.SendPropertyChanging();
					this._baslik = value;
					this.SendPropertyChanged("baslik");
					this.OnbaslikChanged();
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