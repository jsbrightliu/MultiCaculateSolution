using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// AIRPORT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AIRPORT
	{
		public AIRPORT()
		{}
		#region Model
		private int _airportcode;
		private string _icaocode;
		private string _iatacode;
		private string _name;
		private double? _elevation;
		private int? _magneticvariation;
		private int? _latitude;
		private int? _longitude;
		private string _comments;
		private int? _creationdate;
		private int? _updatedate;
		private int? _updatetime;
		private int? _lastupdate;
		private int _citycode;
		private string _crc;
		/// <summary>
		/// 
		/// </summary>
		public int AIRPORTCODE
		{
			set{ _airportcode=value;}
			get{return _airportcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ICAOCODE
		{
			set{ _icaocode=value;}
			get{return _icaocode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IATACODE
		{
			set{ _iatacode=value;}
			get{return _iatacode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? ELEVATION
		{
			set{ _elevation=value;}
			get{return _elevation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAGNETICVARIATION
		{
			set{ _magneticvariation=value;}
			get{return _magneticvariation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LATITUDE
		{
			set{ _latitude=value;}
			get{return _latitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LONGITUDE
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMMENTS
		{
			set{ _comments=value;}
			get{return _comments;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CREATIONDATE
		{
			set{ _creationdate=value;}
			get{return _creationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UPDATEDATE
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UPDATETIME
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LASTUPDATE
		{
			set{ _lastupdate=value;}
			get{return _lastupdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CITYCODE
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRC
		{
			set{ _crc=value;}
			get{return _crc;}
		}
		#endregion Model

	}
}

