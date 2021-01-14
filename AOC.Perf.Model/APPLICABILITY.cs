using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// APPLICABILITY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class APPLICABILITY
	{
		public APPLICABILITY()
		{}
		#region Model
		private int _id;
		private string _designation;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Designation
		{
			set{ _designation=value;}
			get{return _designation;}
		}
		#endregion Model

	}
}

