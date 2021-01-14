using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:SIDCONSTRAINTS
	/// </summary>
	public partial class SIDCONSTRAINTS
	{
		public SIDCONSTRAINTS()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.SIDCONSTRAINTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SIDCONSTRAINTS(");
			strSql.Append("TARGETALTITUDE,GRADIENT,COMMENTS,LASTUPDATE,QFUCODE,CREATIONDATE,UPDATEDATE,UPDATETIME)");
			strSql.Append(" values (");
			strSql.Append("@TARGETALTITUDE,@GRADIENT,@COMMENTS,@LASTUPDATE,@QFUCODE,@CREATIONDATE,@UPDATEDATE,@UPDATETIME)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@TARGETALTITUDE", OleDbType.VarChar,20),
					new OleDbParameter("@GRADIENT", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4)};
			parameters[0].Value = model.TARGETALTITUDE;
			parameters[1].Value = model.GRADIENT;
			parameters[2].Value = model.COMMENTS;
			parameters[3].Value = model.LASTUPDATE;
			parameters[4].Value = model.QFUCODE;
			parameters[5].Value = model.CREATIONDATE;
			parameters[6].Value = model.UPDATEDATE;
			parameters[7].Value = model.UPDATETIME;

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
		public bool Update(AOC.Perf.Model.SIDCONSTRAINTS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SIDCONSTRAINTS set ");
			strSql.Append("TARGETALTITUDE=@TARGETALTITUDE,");
			strSql.Append("GRADIENT=@GRADIENT,");
			strSql.Append("COMMENTS=@COMMENTS,");
			strSql.Append("LASTUPDATE=@LASTUPDATE,");
			strSql.Append("QFUCODE=@QFUCODE,");
			strSql.Append("CREATIONDATE=@CREATIONDATE,");
			strSql.Append("UPDATEDATE=@UPDATEDATE,");
			strSql.Append("UPDATETIME=@UPDATETIME");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@TARGETALTITUDE", OleDbType.VarChar,20),
					new OleDbParameter("@GRADIENT", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@SIDCONSTRAINTSCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.TARGETALTITUDE;
			parameters[1].Value = model.GRADIENT;
			parameters[2].Value = model.COMMENTS;
			parameters[3].Value = model.LASTUPDATE;
			parameters[4].Value = model.QFUCODE;
			parameters[5].Value = model.CREATIONDATE;
			parameters[6].Value = model.UPDATEDATE;
			parameters[7].Value = model.UPDATETIME;
			parameters[8].Value = model.SIDCONSTRAINTSCODE;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SIDCONSTRAINTS ");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public AOC.Perf.Model.SIDCONSTRAINTS GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SIDCONSTRAINTSCODE,TARGETALTITUDE,GRADIENT,COMMENTS,LASTUPDATE,QFUCODE,CREATIONDATE,UPDATEDATE,UPDATETIME from SIDCONSTRAINTS ");
			strSql.Append(" where ");
			OleDbParameter[] parameters = {
			};

			AOC.Perf.Model.SIDCONSTRAINTS model=new AOC.Perf.Model.SIDCONSTRAINTS();
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
		public AOC.Perf.Model.SIDCONSTRAINTS DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.SIDCONSTRAINTS model=new AOC.Perf.Model.SIDCONSTRAINTS();
			if (row != null)
			{
				if(row["SIDCONSTRAINTSCODE"]!=null && row["SIDCONSTRAINTSCODE"].ToString()!="")
				{
					model.SIDCONSTRAINTSCODE=int.Parse(row["SIDCONSTRAINTSCODE"].ToString());
				}
				if(row["TARGETALTITUDE"]!=null)
				{
					model.TARGETALTITUDE=row["TARGETALTITUDE"].ToString();
				}
					//model.GRADIENT=row["GRADIENT"].ToString();
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["LASTUPDATE"]!=null && row["LASTUPDATE"].ToString()!="")
				{
					model.LASTUPDATE=int.Parse(row["LASTUPDATE"].ToString());
				}
				if(row["QFUCODE"]!=null && row["QFUCODE"].ToString()!="")
				{
					model.QFUCODE=int.Parse(row["QFUCODE"].ToString());
				}
				if(row["CREATIONDATE"]!=null && row["CREATIONDATE"].ToString()!="")
				{
					model.CREATIONDATE=int.Parse(row["CREATIONDATE"].ToString());
				}
				if(row["UPDATEDATE"]!=null && row["UPDATEDATE"].ToString()!="")
				{
					model.UPDATEDATE=int.Parse(row["UPDATEDATE"].ToString());
				}
				if(row["UPDATETIME"]!=null && row["UPDATETIME"].ToString()!="")
				{
					model.UPDATETIME=int.Parse(row["UPDATETIME"].ToString());
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
			strSql.Append("select SIDCONSTRAINTSCODE,TARGETALTITUDE,GRADIENT,COMMENTS,LASTUPDATE,QFUCODE,CREATIONDATE,UPDATEDATE,UPDATETIME ");
			strSql.Append(" FROM SIDCONSTRAINTS ");
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
			strSql.Append("select count(1) FROM SIDCONSTRAINTS ");
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
			strSql.Append(")AS Row, T.*  from SIDCONSTRAINTS T ");
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
			parameters[0].Value = "SIDCONSTRAINTS";
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

