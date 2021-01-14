using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:OBSTACLES
	/// </summary>
	public partial class OBSTACLES
	{
		public OBSTACLES()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("OBSTACLECODE", "OBSTACLES"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OBSTACLECODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OBSTACLES");
			strSql.Append(" where OBSTACLECODE=@OBSTACLECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLECODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.OBSTACLES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OBSTACLES(");
			strSql.Append("OBSTACLENATURECODE,DISTANCE,ELEVATION,LATERALDISTANCE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,QFUCODE,CRC)");
			strSql.Append(" values (");
			strSql.Append("@OBSTACLENATURECODE,@DISTANCE,@ELEVATION,@LATERALDISTANCE,@COMMENTS,@CREATIONDATE,@UPDATEDATE,@UPDATETIME,@LASTUPDATE,@QFUCODE,@CRC)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLENATURECODE", OleDbType.Integer,4),
					new OleDbParameter("@DISTANCE", OleDbType.Double),
					new OleDbParameter("@ELEVATION", OleDbType.Double),
					new OleDbParameter("@LATERALDISTANCE", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255)};
			parameters[0].Value = model.OBSTACLENATURECODE;
			parameters[1].Value = model.DISTANCE;
			parameters[2].Value = model.ELEVATION;
			parameters[3].Value = model.LATERALDISTANCE;
			parameters[4].Value = model.COMMENTS;
			parameters[5].Value = model.CREATIONDATE;
			parameters[6].Value = model.UPDATEDATE;
			parameters[7].Value = model.UPDATETIME;
			parameters[8].Value = model.LASTUPDATE;
			parameters[9].Value = model.QFUCODE;
			parameters[10].Value = model.CRC;

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
		public bool Update(AOC.Perf.Model.OBSTACLES model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OBSTACLES set ");
			strSql.Append("OBSTACLENATURECODE=@OBSTACLENATURECODE,");
			strSql.Append("DISTANCE=@DISTANCE,");
			strSql.Append("ELEVATION=@ELEVATION,");
			strSql.Append("LATERALDISTANCE=@LATERALDISTANCE,");
			strSql.Append("COMMENTS=@COMMENTS,");
			strSql.Append("CREATIONDATE=@CREATIONDATE,");
			strSql.Append("UPDATEDATE=@UPDATEDATE,");
			strSql.Append("UPDATETIME=@UPDATETIME,");
			strSql.Append("LASTUPDATE=@LASTUPDATE,");
			strSql.Append("QFUCODE=@QFUCODE,");
			strSql.Append("CRC=@CRC");
			strSql.Append(" where OBSTACLECODE=@OBSTACLECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLENATURECODE", OleDbType.Integer,4),
					new OleDbParameter("@DISTANCE", OleDbType.Double),
					new OleDbParameter("@ELEVATION", OleDbType.Double),
					new OleDbParameter("@LATERALDISTANCE", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255),
					new OleDbParameter("@OBSTACLECODE", OleDbType.Integer,4)};
			parameters[0].Value = model.OBSTACLENATURECODE;
			parameters[1].Value = model.DISTANCE;
			parameters[2].Value = model.ELEVATION;
			parameters[3].Value = model.LATERALDISTANCE;
			parameters[4].Value = model.COMMENTS;
			parameters[5].Value = model.CREATIONDATE;
			parameters[6].Value = model.UPDATEDATE;
			parameters[7].Value = model.UPDATETIME;
			parameters[8].Value = model.LASTUPDATE;
			parameters[9].Value = model.QFUCODE;
			parameters[10].Value = model.CRC;
			parameters[11].Value = model.OBSTACLECODE;

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
		public bool Delete(int OBSTACLECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OBSTACLES ");
			strSql.Append(" where OBSTACLECODE=@OBSTACLECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLECODE;

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
		public bool DeleteList(string OBSTACLECODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OBSTACLES ");
			strSql.Append(" where OBSTACLECODE in ("+OBSTACLECODElist + ")  ");
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
		public AOC.Perf.Model.OBSTACLES GetModel(int OBSTACLECODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select OBSTACLECODE,OBSTACLENATURECODE,DISTANCE,ELEVATION,LATERALDISTANCE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,QFUCODE,CRC from OBSTACLES ");
			strSql.Append(" where OBSTACLECODE=@OBSTACLECODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@OBSTACLECODE", OleDbType.Integer,4)
			};
			parameters[0].Value = OBSTACLECODE;

			AOC.Perf.Model.OBSTACLES model=new AOC.Perf.Model.OBSTACLES();
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
		public AOC.Perf.Model.OBSTACLES DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.OBSTACLES model=new AOC.Perf.Model.OBSTACLES();
			if (row != null)
			{
				if(row["OBSTACLECODE"]!=null && row["OBSTACLECODE"].ToString()!="")
				{
					model.OBSTACLECODE=int.Parse(row["OBSTACLECODE"].ToString());
				}
				if(row["OBSTACLENATURECODE"]!=null && row["OBSTACLENATURECODE"].ToString()!="")
				{
					model.OBSTACLENATURECODE=int.Parse(row["OBSTACLENATURECODE"].ToString());
				}
					//model.DISTANCE=row["DISTANCE"].ToString();
					//model.ELEVATION=row["ELEVATION"].ToString();
					//model.LATERALDISTANCE=row["LATERALDISTANCE"].ToString();
				if(row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
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
				if(row["LASTUPDATE"]!=null && row["LASTUPDATE"].ToString()!="")
				{
					model.LASTUPDATE=int.Parse(row["LASTUPDATE"].ToString());
				}
				if(row["QFUCODE"]!=null && row["QFUCODE"].ToString()!="")
				{
					model.QFUCODE=int.Parse(row["QFUCODE"].ToString());
				}
				if(row["CRC"]!=null)
				{
					model.CRC=row["CRC"].ToString();
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
			strSql.Append("select OBSTACLECODE,OBSTACLENATURECODE,DISTANCE,ELEVATION,LATERALDISTANCE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,QFUCODE,CRC ");
			strSql.Append(" FROM OBSTACLES ");
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
			strSql.Append("select count(1) FROM OBSTACLES ");
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
				strSql.Append("order by T.OBSTACLECODE desc");
			}
			strSql.Append(")AS Row, T.*  from OBSTACLES T ");
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
			parameters[0].Value = "OBSTACLES";
			parameters[1].Value = "OBSTACLECODE";
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

