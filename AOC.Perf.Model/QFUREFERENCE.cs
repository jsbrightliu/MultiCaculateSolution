using System;
namespace AOC.Perf.Model
{
	/// <summary>
	/// QFUREFERENCE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class QFUREFERENCE
	{
		public QFUREFERENCE()
		{}
		#region Model
		private int _qfurefcode;
		private string _designation;
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
		public string DESIGNATION
		{
			set{ _designation=value;}
			get{return _designation;}
		}
		#endregion Model

	}
}

