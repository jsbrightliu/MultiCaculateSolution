using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// ENTRYANGLE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ENTRYANGLE
	{
		public ENTRYANGLE()
		{}
		#region Model
		private Single _id;
		private string _designation;
		/// <summary>
		/// 
		/// </summary>
		public Single Id
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

