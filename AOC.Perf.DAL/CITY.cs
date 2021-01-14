using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:CITY
	/// </summary>
	public partial class CITY
	{
		public CITY()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("CITYCODE", "CITY"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CITYCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CITY");
			strSql.Append(" where CITYCODE=@CITYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = CITYCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.CITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CITY(");
			strSql.Append("NAME,STATECODE)");
			strSql.Append(" values (");
			strSql.Append("@NAME,@STATECODE)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,20),
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
		/// 更新一条数据
		/// </summary>
		public bool Update(AOC.Perf.Model.CITY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CITY set ");
			strSql.Append("NAME=@NAME,");
			strSql.Append("STATECODE=@STATECODE");
			strSql.Append(" where CITYCODE=@CITYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,20),
					new OleDbParameter("@STATECODE", OleDbType.Integer,4),
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.NAME;
			parameters[1].Value = model.STATECODE;
			parameters[2].Value = model.CITYCODE;

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
		public bool Delete(int CITYCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CITY ");
			strSql.Append(" where CITYCODE=@CITYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = CITYCODE;

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
		public bool DeleteList(string CITYCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CITY ");
			strSql.Append(" where CITYCODE in ("+CITYCODElist + ")  ");
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
		public AOC.Perf.Model.CITY GetModel(int CITYCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CITYCODE,NAME,STATECODE from CITY ");
			strSql.Append(" where CITYCODE=@CITYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = CITYCODE;

			AOC.Perf.Model.CITY model=new AOC.Perf.Model.CITY();
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
		public AOC.Perf.Model.CITY DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.CITY model=new AOC.Perf.Model.CITY();
			if (row != null)
			{
				if(row["CITYCODE"]!=null && row["CITYCODE"].ToString()!="")
				{
					model.CITYCODE=int.Parse(row["CITYCODE"].ToString());
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["STATECODE"]!=null && row["STATECODE"].ToString()!="")
				{
					model.STATECODE=int.Parse(row["STATECODE"].ToString());
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
			strSql.Append("select CITYCODE,NAME,STATECODE ");
			strSql.Append(" FROM CITY ");
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
			strSql.Append("select count(1) FROM CITY ");
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
				strSql.Append("order by T.CITYCODE desc");
			}
			strSql.Append(")AS Row, T.*  from CITY T ");
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
			parameters[0].Value = "CITY";
			parameters[1].Value = "CITYCODE";
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

