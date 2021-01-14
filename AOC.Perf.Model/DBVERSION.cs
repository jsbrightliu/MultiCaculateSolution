using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// DBVERSION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DBVERSION
	{
		public DBVERSION()
		{}
		#region Model
		private string _version;
		/// <summary>
		/// 
		/// </summary>
		public string Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		#endregion Model

	}
}

