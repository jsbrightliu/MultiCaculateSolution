using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:QFUSET
	/// </summary>
	public partial class QFUSET
	{
		public QFUSET()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("QFUSETCODE", "QFUSET"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int QFUSETCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QFUSET");
			strSql.Append(" where QFUSETCODE=@QFUSETCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUSETCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUSETCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.QFUSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QFUSET(");
			strSql.Append("NAME)");
			strSql.Append(" values (");
			strSql.Append("@NAME)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,30)};
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
		public bool Update(AOC.Perf.Model.QFUSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QFUSET set ");
			strSql.Append("NAME=@NAME");
			strSql.Append(" where QFUSETCODE=@QFUSETCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@NAME", OleDbType.VarChar,30),
					new OleDbParameter("@QFUSETCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.NAME;
			parameters[1].Value = model.QFUSETCODE;

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
		public bool Delete(int QFUSETCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFUSET ");
			strSql.Append(" where QFUSETCODE=@QFUSETCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUSETCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUSETCODE;

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
		public bool DeleteList(string QFUSETCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFUSET ");
			strSql.Append(" where QFUSETCODE in ("+QFUSETCODElist + ")  ");
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
		public AOC.Perf.Model.QFUSET GetModel(int QFUSETCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QFUSETCODE,NAME from QFUSET ");
			strSql.Append(" where QFUSETCODE=@QFUSETCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUSETCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUSETCODE;

			AOC.Perf.Model.QFUSET model=new AOC.Perf.Model.QFUSET();
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
		public AOC.Perf.Model.QFUSET DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.QFUSET model=new AOC.Perf.Model.QFUSET();
			if (row != null)
			{
				if(row["QFUSETCODE"]!=null && row["QFUSETCODE"].ToString()!="")
				{
					model.QFUSETCODE=int.Parse(row["QFUSETCODE"].ToString());
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
			strSql.Append("select QFUSETCODE,NAME ");
			strSql.Append(" FROM QFUSET ");
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
			strSql.Append("select count(1) FROM QFUSET ");
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
				strSql.Append("order by T.QFUSETCODE desc");
			}
			strSql.Append(")AS Row, T.*  from QFUSET T ");
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
			parameters[0].Value = "QFUSET";
			parameters[1].Value = "QFUSETCODE";
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

