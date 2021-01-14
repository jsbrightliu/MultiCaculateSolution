using System;
using System.Data;
using System.Collections.Generic;
using AOC.Perf.Common;
using AOC.Perf.Model;
namespace AOC.Perf.BLL
{
	/// <summary>
	/// APPLICABILITY
	/// </summary>
	public partial class APPLICABILITY
	{
		private readonly AOC.Perf.DAL.APPLICABILITY dal=new AOC.Perf.DAL.APPLICABILITY();
		public APPLICABILITY()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.APPLICABILITY model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AOC.Perf.Model.APPLICABILITY model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(AOC.Perf.Common.PageValidate.SafeLongFilter(Idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AOC.Perf.Model.APPLICABILITY GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AOC.Perf.Model.APPLICABILITY GetModelByCache(int Id)
		{
			
			string CacheKey = "APPLICABILITYModel-" + Id;
			object objModel = AOC.Perf.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = AOC.Perf.Common.ConfigHelper.GetConfigInt("ModelCache");
						AOC.Perf.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AOC.Perf.Model.APPLICABILITY)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AOC.Perf.Model.APPLICABILITY> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AOC.Perf.Model.APPLICABILITY> DataTableToList(DataTable dt)
		{
			List<AOC.Perf.Model.APPLICABILITY> modelList = new List<AOC.Perf.Model.APPLICABILITY>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AOC.Perf.Model.APPLICABILITY model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

