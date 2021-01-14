using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// OBSTACLES:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OBSTACLES
	{
		public OBSTACLES()
		{}
		#region Model
		private int _obstaclecode;
		private int? _obstaclenaturecode;
		private double? _distance;
		private double? _elevation;
		private double? _lateraldistance;
		private string _comments;
		private int? _creationdate;
		private int? _updatedate;
		private int? _updatetime;
		private int? _lastupdate;
		private int? _qfucode;
		private string _crc;
		/// <summary>
		/// 
		/// </summary>
		public int OBSTACLECODE
		{
			set{ _obstaclecode=value;}
			get{return _obstaclecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OBSTACLENATURECODE
		{
			set{ _obstaclenaturecode=value;}
			get{return _obstaclenaturecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? DISTANCE
		{
			set{ _distance=value;}
			get{return _distance;}
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
		public double? LATERALDISTANCE
		{
			set{ _lateraldistance=value;}
			get{return _lateraldistance;}
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
		public int? QFUCODE
		{
			set{ _qfucode=value;}
			get{return _qfucode;}
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

