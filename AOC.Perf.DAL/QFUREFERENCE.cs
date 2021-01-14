﻿using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:QFUREFERENCE
	/// </summary>
	public partial class QFUREFERENCE
	{
		public QFUREFERENCE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("QFUREFCODE", "QFUREFERENCE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int QFUREFCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QFUREFERENCE");
			strSql.Append(" where QFUREFCODE=@QFUREFCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUREFCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUREFCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.QFUREFERENCE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QFUREFERENCE(");
			strSql.Append("DESIGNATION)");
			strSql.Append(" values (");
			strSql.Append("@DESIGNATION)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@DESIGNATION", OleDbType.VarChar,3)};
			parameters[0].Value = model.DESIGNATION;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(AOC.Perf.Model.QFUREFERENCE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QFUREFERENCE set ");
			strSql.Append("DESIGNATION=@DESIGNATION");
			strSql.Append(" where QFUREFCODE=@QFUREFCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@DESIGNATION", OleDbType.VarChar,3),
					new OleDbParameter("@QFUREFCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.DESIGNATION;
			parameters[1].Value = model.QFUREFCODE;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int QFUREFCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFUREFERENCE ");
			strSql.Append(" where QFUREFCODE=@QFUREFCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUREFCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUREFCODE;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string QFUREFCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFUREFERENCE ");
			strSql.Append(" where QFUREFCODE in ("+QFUREFCODElist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AOC.Perf.Model.QFUREFERENCE GetModel(int QFUREFCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QFUREFCODE,DESIGNATION from QFUREFERENCE ");
			strSql.Append(" where QFUREFCODE=@QFUREFCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUREFCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUREFCODE;

			AOC.Perf.Model.QFUREFERENCE model=new AOC.Perf.Model.QFUREFERENCE();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AOC.Perf.Model.QFUREFERENCE DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.QFUREFERENCE model=new AOC.Perf.Model.QFUREFERENCE();
			if (row != null)
			{
				if(row["QFUREFCODE"]!=null && row["QFUREFCODE"].ToString()!="")
				{
					model.QFUREFCODE=int.Parse(row["QFUREFCODE"].ToString());
				}
				if(row["DESIGNATION"]!=null)
				{
					model.DESIGNATION=row["DESIGNATION"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QFUREFCODE,DESIGNATION ");
			strSql.Append(" FROM QFUREFERENCE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM QFUREFERENCE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.QFUREFCODE desc");
			}
			strSql.Append(")AS Row, T.*  from QFUREFERENCE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "QFUREFERENCE";
			parameters[1].Value = "QFUREFCODE";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

