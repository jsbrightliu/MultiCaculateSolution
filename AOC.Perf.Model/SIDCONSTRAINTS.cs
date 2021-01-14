using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// SIDCONSTRAINTS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SIDCONSTRAINTS
	{
		public SIDCONSTRAINTS()
		{}
		#region Model
		private int _sidconstraintscode;
		private string _targetaltitude;
		private double? _gradient;
		private string _comments;
		private int? _lastupdate;
		private int? _qfucode;
		private int? _creationdate;
		private int? _updatedate;
		private int? _updatetime;
		/// <summary>
		/// 
		/// </summary>
		public int SIDCONSTRAINTSCODE
		{
			set{ _sidconstraintscode=value;}
			get{return _sidconstraintscode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TARGETALTITUDE
		{
			set{ _targetaltitude=value;}
			get{return _targetaltitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? GRADIENT
		{
			set{ _gradient=value;}
			get{return _gradient;}
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
		#endregion Model

	}
}

