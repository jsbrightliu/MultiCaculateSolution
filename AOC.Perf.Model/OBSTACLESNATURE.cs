using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// OBSTACLESNATURE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OBSTACLESNATURE
	{
		public OBSTACLESNATURE()
		{}
		#region Model
		private int _obstaclesnaturecode;
		private string _designation;
		/// <summary>
		/// 
		/// </summary>
		public int OBSTACLESNATURECODE
		{
			set{ _obstaclesnaturecode=value;}
			get{return _obstaclesnaturecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESIGNATION
		{
			set{ _designation=value;}
			get{return _designation;}
		}
		#endregion Model

	}
}

