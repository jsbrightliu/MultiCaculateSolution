﻿using System;
using System.Data;
using System.Collections.Generic;
using AOC.Perf.Common;
using AOC.Perf.Model;
namespace AOC.Perf.BLL
{
	/// <summary>
	/// SIDCONSTRAINTS
	/// </summary>
	public partial class SIDCONSTRAINTS
	{
		private readonly AOC.Perf.DAL.SIDCONSTRAINTS dal=new AOC.Perf.DAL.SIDCONSTRAINTS();
		public SIDCONSTRAINTS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.SIDCONSTRAINTS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AOC.Perf.Model.SIDCONSTRAINTS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AOC.Perf.Model.SIDCONSTRAINTS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public AOC.Perf.Model.SIDCONSTRAINTS GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "SIDCONSTRAINTSModel-" ;
			object objModel = AOC.Perf.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = AOC.Perf.Common.ConfigHelper.GetConfigInt("ModelCache");
						AOC.Perf.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (AOC.Perf.Model.SIDCONSTRAINTS)objModel;
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
		public List<AOC.Perf.Model.SIDCONSTRAINTS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<AOC.Perf.Model.SIDCONSTRAINTS> DataTableToList(DataTable dt)
		{
			List<AOC.Perf.Model.SIDCONSTRAINTS> modelList = new List<AOC.Perf.Model.SIDCONSTRAINTS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				AOC.Perf.Model.SIDCONSTRAINTS model;
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

