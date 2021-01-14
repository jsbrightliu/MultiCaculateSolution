using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:STATE
	/// </summary>
	public partial class STATE
	{
		public STATE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("STATECODE", "STATE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int STATECODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STATE");
			strSql.Append(" where STATECODE=@STATECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@STATECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = STATECODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.STATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STATE(");
			strSql.Append("NAME)");
			strSql.Append(" values (");
			strSql.Append("@NAME)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,25)};
			parameters[0].Value = model.NAME;

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
		public bool Update(AOC.Perf.Model.STATE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STATE set ");
			strSql.Append("NAME=@NAME");
			strSql.Append(" where STATECODE=@STATECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,25),
					new OleDbParameter("@STATECODE", OleDbType.Integer,4)};
			parameters[0].Value = model.NAME;
			parameters[1].Value = model.STATECODE;

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
		public bool Delete(int STATECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STATE ");
			strSql.Append(" where STATECODE=@STATECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@STATECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = STATECODE;

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
		public bool DeleteList(string STATECODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STATE ");
			strSql.Append(" where STATECODE in ("+STATECODElist + ")  ");
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
		public AOC.Perf.Model.STATE GetModel(int STATECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select STATECODE,NAME from STATE ");
			strSql.Append(" where STATECODE=@STATECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@STATECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = STATECODE;

			AOC.Perf.Model.STATE model=new AOC.Perf.Model.STATE();
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
		public AOC.Perf.Model.STATE DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.STATE model=new AOC.Perf.Model.STATE();
			if (row != null)
			{
				if(row["STATECODE"]!=null && row["STATECODE"].ToString()!="")
				{
					model.STATECODE=int.Parse(row["STATECODE"].ToString());
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
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
			strSql.Append("select STATECODE,NAME ");
			strSql.Append(" FROM STATE ");
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
			strSql.Append("select count(1) FROM STATE ");
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
				strSql.Append("order by T.STATECODE desc");
			}
			strSql.Append(")AS Row, T.*  from STATE T ");
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
			parameters[0].Value = "STATE";
			parameters[1].Value = "STATECODE";
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

