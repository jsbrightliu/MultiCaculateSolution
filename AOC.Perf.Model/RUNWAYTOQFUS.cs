using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// RUNWAYTOQFUS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RUNWAYTOQFUS
	{
		public RUNWAYTOQFUS()
		{}
		#region Model
		private int _qfurefcode;
		private int _qfucode;
		private int _runwaycode;
		/// <summary>
		/// 
		/// </summary>
		public int QFUREFCODE
		{
			set{ _qfurefcode=value;}
			get{return _qfurefcode;}
		}
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
		public int RUNWAYCODE
		{
			set{ _runwaycode=value;}
			get{return _runwaycode;}
		}
		#endregion Model

	}
}

