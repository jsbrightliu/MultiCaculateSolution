using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// QFU:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QFU
	{
		public QFU()
		{}
		#region Model
		private int _qfucode;
		private string _ident;
		private double? _tora;
		private double? _asda;
		private double? _lda;
		private double? _toda;
		private int? _entryangle;
		private double? _slope;
		private int? _thresholdlatitude;
		private int? _thresholdlongitude;
		private double? _thresholdelevation;
		private double? _approachslope;
		private string _comments;
		private string _tocomments;
		private string _ldcomments;
		private int? _creationdate;
		private int? _updatedate;
		private int? _updatetime;
		private int? _lastupdate;
		private double? _takeoffshift;
		private bool _groovedpfcsurfaceto= false;
		private bool _groovedpfcsurfaceld= false;
		private double? _glideslope;
		private double? _incrementgaheight;
		private bool _groovedpfcstopway= false;
		private bool _runwaypavement= false;
		private double? _minkvs;
		private double? _maxkvs;
		private int? _applicability;
		private double? _runwaypavementcbr;
		private string _crc;
		private double? _thrustreductionheight;
		private double? _accelerationheight;
		private bool _climbspeedlimitstatus;
		private double? _initialclimbspeed;
		private string _speedlimitalt;
		private double? _finalclimbspeed;
		/// <summary>
		/// 
		/// </summary>
		public int QFUCODE
		{
			set{ _qfucode=value;}
			get{return _qfucode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDENT
		{
			set{ _ident=value;}
			get{return _ident;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? TORA
		{
			set{ _tora=value;}
			get{return _tora;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? ASDA
		{
			set{ _asda=value;}
			get{return _asda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? LDA
		{
			set{ _lda=value;}
			get{return _lda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? TODA
		{
			set{ _toda=value;}
			get{return _toda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ENTRYANGLE
		{
			set{ _entryangle=value;}
			get{return _entryangle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? SLOPE
		{
			set{ _slope=value;}
			get{return _slope;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? THRESHOLDLATITUDE
		{
			set{ _thresholdlatitude=value;}
			get{return _thresholdlatitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? THRESHOLDLONGITUDE
		{
			set{ _thresholdlongitude=value;}
			get{return _thresholdlongitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? THRESHOLDELEVATION
		{
			set{ _thresholdelevation=value;}
			get{return _thresholdelevation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? APPROACHSLOPE
		{
			set{ _approachslope=value;}
			get{return _approachslope;}
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
		public string TOCOMMENTS
		{
			set{ _tocomments=value;}
			get{return _tocomments;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LDCOMMENTS
		{
			set{ _ldcomments=value;}
			get{return _ldcomments;}
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
		public double? TAKEOFFSHIFT
		{
			set{ _takeoffshift=value;}
			get{return _takeoffshift;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GROOVEDPFCSURFACETO
		{
			set{ _groovedpfcsurfaceto=value;}
			get{return _groovedpfcsurfaceto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GROOVEDPFCSURFACELD
		{
			set{ _groovedpfcsurfaceld=value;}
			get{return _groovedpfcsurfaceld;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? GLIDESLOPE
		{
			set{ _glideslope=value;}
			get{return _glideslope;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? IncrementGAHeight
		{
			set{ _incrementgaheight=value;}
			get{return _incrementgaheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GROOVEDPFCSTOPWAY
		{
			set{ _groovedpfcstopway=value;}
			get{return _groovedpfcstopway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool RUNWAYPAVEMENT
		{
			set{ _runwaypavement=value;}
			get{return _runwaypavement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MinKVs
		{
			set{ _minkvs=value;}
			get{return _minkvs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? MaxKVs
		{
			set{ _maxkvs=value;}
			get{return _maxkvs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? APPLICABILITY
		{
			set{ _applicability=value;}
			get{return _applicability;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? RUNWAYPAVEMENTCBR
		{
			set{ _runwaypavementcbr=value;}
			get{return _runwaypavementcbr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CRC
		{
			set{ _crc=value;}
			get{return _crc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? THRUSTREDUCTIONHEIGHT
		{
			set{ _thrustreductionheight=value;}
			get{return _thrustreductionheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? ACCELERATIONHEIGHT
		{
			set{ _accelerationheight=value;}
			get{return _accelerationheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool CLIMBSPEEDLIMITSTATUS
		{
			set{ _climbspeedlimitstatus=value;}
			get{return _climbspeedlimitstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? INITIALCLIMBSPEED
		{
			set{ _initialclimbspeed=value;}
			get{return _initialclimbspeed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPEEDLIMITALT
		{
			set{ _speedlimitalt=value;}
			get{return _speedlimitalt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? FINALCLIMBSPEED
		{
			set{ _finalclimbspeed=value;}
			get{return _finalclimbspeed;}
		}
		#endregion Model

	}
}

