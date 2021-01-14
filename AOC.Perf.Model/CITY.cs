using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// CITY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CITY
	{
		public CITY()
		{}
		#region Model
		private int _citycode;
		private string _name;
		private int? _statecode;
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
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STATECODE
		{
			set{ _statecode=value;}
			get{return _statecode;}
		}
		#endregion Model

	}
}

