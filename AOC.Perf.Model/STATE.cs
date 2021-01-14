using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// STATE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STATE
	{
		public STATE()
		{}
		#region Model
		private int _statecode;
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public int STATECODE
		{
			set{ _statecode=value;}
			get{return _statecode;}
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

