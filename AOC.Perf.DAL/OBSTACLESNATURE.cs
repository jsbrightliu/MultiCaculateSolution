using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:OBSTACLESNATURE
	/// </summary>
	public partial class OBSTACLESNATURE
	{
		public OBSTACLESNATURE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("OBSTACLESNATURECODE", "OBSTACLESNATURE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OBSTACLESNATURECODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OBSTACLESNATURE");
			strSql.Append(" where OBSTACLESNATURECODE=@OBSTACLESNATURECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLESNATURECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLESNATURECODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.OBSTACLESNATURE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OBSTACLESNATURE(");
			strSql.Append("DESIGNATION)");
			strSql.Append(" values (");
			strSql.Append("@DESIGNATION)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@DESIGNATION", OleDbType.VarChar,20)};
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
		public bool Update(AOC.Perf.Model.OBSTACLESNATURE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OBSTACLESNATURE set ");
			strSql.Append("DESIGNATION=@DESIGNATION");
			strSql.Append(" where OBSTACLESNATURECODE=@OBSTACLESNATURECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@DESIGNATION", OleDbType.VarChar,20),
					new OleDbParameter("@OBSTACLESNATURECODE", OleDbType.Integer,4)};
			parameters[0].Value = model.DESIGNATION;
			parameters[1].Value = model.OBSTACLESNATURECODE;

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
		public bool Delete(int OBSTACLESNATURECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OBSTACLESNATURE ");
			strSql.Append(" where OBSTACLESNATURECODE=@OBSTACLESNATURECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLESNATURECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLESNATURECODE;

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
		public bool DeleteList(string OBSTACLESNATURECODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OBSTACLESNATURE ");
			strSql.Append(" where OBSTACLESNATURECODE in ("+OBSTACLESNATURECODElist + ")  ");
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
		public AOC.Perf.Model.OBSTACLESNATURE GetModel(int OBSTACLESNATURECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OBSTACLESNATURECODE,DESIGNATION from OBSTACLESNATURE ");
			strSql.Append(" where OBSTACLESNATURECODE=@OBSTACLESNATURECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLESNATURECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLESNATURECODE;

			AOC.Perf.Model.OBSTACLESNATURE model=new AOC.Perf.Model.OBSTACLESNATURE();
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
		public AOC.Perf.Model.OBSTACLESNATURE DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.OBSTACLESNATURE model=new AOC.Perf.Model.OBSTACLESNATURE();
			if (row != null)
			{
				if(row["OBSTACLESNATURECODE"]!=null && row["OBSTACLESNATURECODE"].ToString()!="")
				{
					model.OBSTACLESNATURECODE=int.Parse(row["OBSTACLESNATURECODE"].ToString());
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
			strSql.Append("select OBSTACLESNATURECODE,DESIGNATION ");
			strSql.Append(" FROM OBSTACLESNATURE ");
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
			strSql.Append("select count(1) FROM OBSTACLESNATURE ");
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
				strSql.Append("order by T.OBSTACLESNATURECODE desc");
			}
			strSql.Append(")AS Row, T.*  from OBSTACLESNATURE T ");
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
			parameters[0].Value = "OBSTACLESNATURE";
			parameters[1].Value = "OBSTACLESNATURECODE";
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

