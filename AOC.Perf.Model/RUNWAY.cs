using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// RUNWAY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RUNWAY
	{
		public RUNWAY()
		{}
		#region Model
		private int _runwaycode;
		private int? _magneticheading;
		private int? _magneticheadingdate;
		private string _strength;
		private double? _maxlength;
		private double? _width;
		private double? _shoulder;
		private string _comments;
		private int? _creationdate;
		private int? _updatedate;
		private int? _updatetime;
		private int? _lastupdate;
		private int? _airportcode;
		private string _crc;
		/// <summary>
		/// 
		/// </summary>
		public int RUNWAYCODE
		{
			set{ _runwaycode=value;}
			get{return _runwaycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAGNETICHEADING
		{
			set{ _magneticheading=value;}
			get{return _magneticheading;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAGNETICHEADINGDATE
		{
			set{ _magneticheadingdate=value;}
			get{return _magneticheadingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STRENGTH
		{
			set{ _strength=value;}
			get{return _strength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MAXLENGTH
		{
			set{ _maxlength=value;}
			get{return _maxlength;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? WIDTH
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? SHOULDER
		{
			set{ _shoulder=value;}
			get{return _shoulder;}
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
		public int? AIRPORTCODE
		{
			set{ _airportcode=value;}
			get{return _airportcode;}
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

