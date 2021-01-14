using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// QFUSETSELEMENTS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QFUSETSELEMENTS
	{
		public QFUSETSELEMENTS()
		{}
		#region Model
		private int _qfusetcode;
		private int? _qfucode;
		/// <summary>
		/// 
		/// </summary>
		public int QFUSETCODE
		{
			set{ _qfusetcode=value;}
			get{return _qfusetcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? QFUCODE
		{
			set{ _qfucode=value;}
			get{return _qfucode;}
		}
		#endregion Model

	}
}

