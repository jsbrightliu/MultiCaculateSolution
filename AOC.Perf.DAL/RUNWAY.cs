using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:RUNWAY
	/// </summary>
	public partial class RUNWAY
	{
		public RUNWAY()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("RUNWAYCODE", "RUNWAY"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RUNWAYCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RUNWAY");
			strSql.Append(" where RUNWAYCODE=@RUNWAYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RUNWAYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = RUNWAYCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.RUNWAY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RUNWAY(");
			strSql.Append("MAGNETICHEADING,MAGNETICHEADINGDATE,STRENGTH,MAXLENGTH,WIDTH,SHOULDER,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,AIRPORTCODE,CRC)");
			strSql.Append(" values (");
			strSql.Append("@MAGNETICHEADING,@MAGNETICHEADINGDATE,@STRENGTH,@MAXLENGTH,@WIDTH,@SHOULDER,@COMMENTS,@CREATIONDATE,@UPDATEDATE,@UPDATETIME,@LASTUPDATE,@AIRPORTCODE,@CRC)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@MAGNETICHEADING", OleDbType.Integer,4),
					new OleDbParameter("@MAGNETICHEADINGDATE", OleDbType.Integer,4),
					new OleDbParameter("@STRENGTH", OleDbType.VarChar,30),
					new OleDbParameter("@MAXLENGTH", OleDbType.Double),
					new OleDbParameter("@WIDTH", OleDbType.Double),
					new OleDbParameter("@SHOULDER", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255)};
			parameters[0].Value = model.MAGNETICHEADING;
			parameters[1].Value = model.MAGNETICHEADINGDATE;
			parameters[2].Value = model.STRENGTH;
			parameters[3].Value = model.MAXLENGTH;
			parameters[4].Value = model.WIDTH;
			parameters[5].Value = model.SHOULDER;
			parameters[6].Value = model.COMMENTS;
			parameters[7].Value = model.CREATIONDATE;
			parameters[8].Value = model.UPDATEDATE;
			parameters[9].Value = model.UPDATETIME;
			parameters[10].Value = model.LASTUPDATE;
			parameters[11].Value = model.AIRPORTCODE;
			parameters[12].Value = model.CRC;

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
		public bool Update(AOC.Perf.Model.RUNWAY model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RUNWAY set ");
			strSql.Append("MAGNETICHEADING=@MAGNETICHEADING,");
			strSql.Append("MAGNETICHEADINGDATE=@MAGNETICHEADINGDATE,");
			strSql.Append("STRENGTH=@STRENGTH,");
			strSql.Append("MAXLENGTH=@MAXLENGTH,");
			strSql.Append("WIDTH=@WIDTH,");
			strSql.Append("SHOULDER=@SHOULDER,");
			strSql.Append("COMMENTS=@COMMENTS,");
			strSql.Append("CREATIONDATE=@CREATIONDATE,");
			strSql.Append("UPDATEDATE=@UPDATEDATE,");
			strSql.Append("UPDATETIME=@UPDATETIME,");
			strSql.Append("LASTUPDATE=@LASTUPDATE,");
			strSql.Append("AIRPORTCODE=@AIRPORTCODE,");
			strSql.Append("CRC=@CRC");
			strSql.Append(" where RUNWAYCODE=@RUNWAYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@MAGNETICHEADING", OleDbType.Integer,4),
					new OleDbParameter("@MAGNETICHEADINGDATE", OleDbType.Integer,4),
					new OleDbParameter("@STRENGTH", OleDbType.VarChar,30),
					new OleDbParameter("@MAXLENGTH", OleDbType.Double),
					new OleDbParameter("@WIDTH", OleDbType.Double),
					new OleDbParameter("@SHOULDER", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255),
					new OleDbParameter("@RUNWAYCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.MAGNETICHEADING;
			parameters[1].Value = model.MAGNETICHEADINGDATE;
			parameters[2].Value = model.STRENGTH;
			parameters[3].Value = model.MAXLENGTH;
			parameters[4].Value = model.WIDTH;
			parameters[5].Value = model.SHOULDER;
			parameters[6].Value = model.COMMENTS;
			parameters[7].Value = model.CREATIONDATE;
			parameters[8].Value = model.UPDATEDATE;
			parameters[9].Value = model.UPDATETIME;
			parameters[10].Value = model.LASTUPDATE;
			parameters[11].Value = model.AIRPORTCODE;
			parameters[12].Value = model.CRC;
			parameters[13].Value = model.RUNWAYCODE;

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
		public bool Delete(int RUNWAYCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RUNWAY ");
			strSql.Append(" where RUNWAYCODE=@RUNWAYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RUNWAYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = RUNWAYCODE;

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
		public bool DeleteList(string RUNWAYCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RUNWAY ");
			strSql.Append(" where RUNWAYCODE in ("+RUNWAYCODElist + ")  ");
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
		public AOC.Perf.Model.RUNWAY GetModel(int RUNWAYCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RUNWAYCODE,MAGNETICHEADING,MAGNETICHEADINGDATE,STRENGTH,MAXLENGTH,WIDTH,SHOULDER,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,AIRPORTCODE,CRC from RUNWAY ");
			strSql.Append(" where RUNWAYCODE=@RUNWAYCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@RUNWAYCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = RUNWAYCODE;

			AOC.Perf.Model.RUNWAY model=new AOC.Perf.Model.RUNWAY();
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
		public AOC.Perf.Model.RUNWAY DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.RUNWAY model=new AOC.Perf.Model.RUNWAY();
			if (row != null)
			{
				if(row["RUNWAYCODE"]!=null && row["RUNWAYCODE"].ToString()!="")
				{
					model.RUNWAYCODE=int.Parse(row["RUNWAYCODE"].ToString());
				}
				if(row["MAGNETICHEADING"]!=null && row["MAGNETICHEADING"].ToString()!="")
				{
					model.MAGNETICHEADING=int.Parse(row["MAGNETICHEADING"].ToString());
				}
				if(row["MAGNETICHEADINGDATE"]!=null && row["MAGNETICHEADINGDATE"].ToString()!="")
				{
					model.MAGNETICHEADINGDATE=int.Parse(row["MAGNETICHEADINGDATE"].ToString());
				}
				if(row["STRENGTH"]!=null)
				{
					model.STRENGTH=row["STRENGTH"].ToString();
				}
                if (row["MAXLENGTH"] != null && row["MAXLENGTH"].ToString() != "")
                {
                    model.MAXLENGTH = double.Parse(row["MAXLENGTH"].ToString());
                }
                if (row["WIDTH"] != null && row["WIDTH"].ToString() != "")
                {
                    model.WIDTH = double.Parse(row["WIDTH"].ToString());
                }
                if (row["SHOULDER"] != null && row["SHOULDER"].ToString() != "")
                {
                    model.SHOULDER = double.Parse(row["SHOULDER"].ToString());
                }
                //model.MAXLENGTH=row["MAXLENGTH"].ToString();
                //model.WIDTH=row["WIDTH"].ToString();
                //model.SHOULDER=row["SHOULDER"].ToString();
                if (row["COMMENTS"]!=null)
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
				if(row["AIRPORTCODE"]!=null && row["AIRPORTCODE"].ToString()!="")
				{
					model.AIRPORTCODE=int.Parse(row["AIRPORTCODE"].ToString());
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
			strSql.Append("select RUNWAYCODE,MAGNETICHEADING,MAGNETICHEADINGDATE,STRENGTH,MAXLENGTH,WIDTH,SHOULDER,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,AIRPORTCODE,CRC ");
			strSql.Append(" FROM RUNWAY ");
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
			strSql.Append("select count(1) FROM RUNWAY ");
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
				strSql.Append("order by T.RUNWAYCODE desc");
			}
			strSql.Append(")AS Row, T.*  from RUNWAY T ");
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
			parameters[0].Value = "RUNWAY";
			parameters[1].Value = "RUNWAYCODE";
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

