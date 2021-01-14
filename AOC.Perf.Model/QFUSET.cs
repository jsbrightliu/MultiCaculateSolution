using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// QFUSET:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QFUSET
	{
		public QFUSET()
		{}
		#region Model
		private int _qfusetcode;
		private string _name;
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
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

