using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:AIRPORT
	/// </summary>
	public partial class AIRPORT
	{
		public AIRPORT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("AIRPORTCODE", "AIRPORT"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AIRPORTCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AIRPORT");
			strSql.Append(" where AIRPORTCODE=@AIRPORTCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = AIRPORTCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.AIRPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AIRPORT(");
			strSql.Append("ICAOCODE,IATACODE,NAME,ELEVATION,MAGNETICVARIATION,LATITUDE,LONGITUDE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,CITYCODE,CRC)");
			strSql.Append(" values (");
			strSql.Append("@ICAOCODE,@IATACODE,@NAME,@ELEVATION,@MAGNETICVARIATION,@LATITUDE,@LONGITUDE,@COMMENTS,@CREATIONDATE,@UPDATEDATE,@UPDATETIME,@LASTUPDATE,@CITYCODE,@CRC)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ICAOCODE", OleDbType.VarChar,4),
					new OleDbParameter("@IATACODE", OleDbType.VarChar,3),
					new OleDbParameter("@NAME", OleDbType.VarChar,36),
					new OleDbParameter("@ELEVATION", OleDbType.Double),
					new OleDbParameter("@MAGNETICVARIATION", OleDbType.Integer,4),
					new OleDbParameter("@LATITUDE", OleDbType.Integer,4),
					new OleDbParameter("@LONGITUDE", OleDbType.Integer,4),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255)};
			parameters[0].Value = model.ICAOCODE;
			parameters[1].Value = model.IATACODE;
			parameters[2].Value = model.NAME;
			parameters[3].Value = model.ELEVATION;
			parameters[4].Value = model.MAGNETICVARIATION;
			parameters[5].Value = model.LATITUDE;
			parameters[6].Value = model.LONGITUDE;
			parameters[7].Value = model.COMMENTS;
			parameters[8].Value = model.CREATIONDATE;
			parameters[9].Value = model.UPDATEDATE;
			parameters[10].Value = model.UPDATETIME;
			parameters[11].Value = model.LASTUPDATE;
			parameters[12].Value = model.CITYCODE;
			parameters[13].Value = model.CRC;

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
		public bool Update(AOC.Perf.Model.AIRPORT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AIRPORT set ");
			strSql.Append("ICAOCODE=@ICAOCODE,");
			strSql.Append("IATACODE=@IATACODE,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("ELEVATION=@ELEVATION,");
			strSql.Append("MAGNETICVARIATION=@MAGNETICVARIATION,");
			strSql.Append("LATITUDE=@LATITUDE,");
			strSql.Append("LONGITUDE=@LONGITUDE,");
			strSql.Append("COMMENTS=@COMMENTS,");
			strSql.Append("CREATIONDATE=@CREATIONDATE,");
			strSql.Append("UPDATEDATE=@UPDATEDATE,");
			strSql.Append("UPDATETIME=@UPDATETIME,");
			strSql.Append("LASTUPDATE=@LASTUPDATE,");
			strSql.Append("CITYCODE=@CITYCODE,");
			strSql.Append("CRC=@CRC");
			strSql.Append(" where AIRPORTCODE=@AIRPORTCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ICAOCODE", OleDbType.VarChar,4),
					new OleDbParameter("@IATACODE", OleDbType.VarChar,3),
					new OleDbParameter("@NAME", OleDbType.VarChar,36),
					new OleDbParameter("@ELEVATION", OleDbType.Double),
					new OleDbParameter("@MAGNETICVARIATION", OleDbType.Integer,4),
					new OleDbParameter("@LATITUDE", OleDbType.Integer,4),
					new OleDbParameter("@LONGITUDE", OleDbType.Integer,4),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@CITYCODE", OleDbType.Integer,4),
					new OleDbParameter("@CRC", OleDbType.VarChar,255),
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.ICAOCODE;
			parameters[1].Value = model.IATACODE;
			parameters[2].Value = model.NAME;
			parameters[3].Value = model.ELEVATION;
			parameters[4].Value = model.MAGNETICVARIATION;
			parameters[5].Value = model.LATITUDE;
			parameters[6].Value = model.LONGITUDE;
			parameters[7].Value = model.COMMENTS;
			parameters[8].Value = model.CREATIONDATE;
			parameters[9].Value = model.UPDATEDATE;
			parameters[10].Value = model.UPDATETIME;
			parameters[11].Value = model.LASTUPDATE;
			parameters[12].Value = model.CITYCODE;
			parameters[13].Value = model.CRC;
			parameters[14].Value = model.AIRPORTCODE;

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
		public bool Delete(int AIRPORTCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRPORT ");
			strSql.Append(" where AIRPORTCODE=@AIRPORTCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = AIRPORTCODE;

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
		public bool DeleteList(string AIRPORTCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AIRPORT ");
			strSql.Append(" where AIRPORTCODE in ("+AIRPORTCODElist + ")  ");
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
		public AOC.Perf.Model.AIRPORT GetModel(int AIRPORTCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AIRPORTCODE,ICAOCODE,IATACODE,NAME,ELEVATION,MAGNETICVARIATION,LATITUDE,LONGITUDE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,CITYCODE,CRC from AIRPORT ");
			strSql.Append(" where AIRPORTCODE=@AIRPORTCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@AIRPORTCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = AIRPORTCODE;

			AOC.Perf.Model.AIRPORT model=new AOC.Perf.Model.AIRPORT();
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
		public AOC.Perf.Model.AIRPORT DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.AIRPORT model=new AOC.Perf.Model.AIRPORT();
			if (row != null)
			{
				if(row["AIRPORTCODE"]!=null && row["AIRPORTCODE"].ToString()!="")
				{
					model.AIRPORTCODE=int.Parse(row["AIRPORTCODE"].ToString());
				}
				if(row["ICAOCODE"]!=null)
				{
					model.ICAOCODE=row["ICAOCODE"].ToString();
				}
				if(row["IATACODE"]!=null)
				{
					model.IATACODE=row["IATACODE"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
                if (row["ELEVATION"] != null && row["ELEVATION"].ToString() != "")
                {
                    model.ELEVATION = double.Parse(row["ELEVATION"].ToString());
                }
                //model.ELEVATION=row["ELEVATION"].ToString();
                if (row["MAGNETICVARIATION"]!=null && row["MAGNETICVARIATION"].ToString()!="")
				{
					model.MAGNETICVARIATION=int.Parse(row["MAGNETICVARIATION"].ToString());
				}
				if(row["LATITUDE"]!=null && row["LATITUDE"].ToString()!="")
				{
					model.LATITUDE=int.Parse(row["LATITUDE"].ToString());
				}
				if(row["LONGITUDE"]!=null && row["LONGITUDE"].ToString()!="")
				{
					model.LONGITUDE=int.Parse(row["LONGITUDE"].ToString());
				}
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
				if(row["CITYCODE"]!=null && row["CITYCODE"].ToString()!="")
				{
					model.CITYCODE=int.Parse(row["CITYCODE"].ToString());
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
			strSql.Append("select AIRPORTCODE,ICAOCODE,IATACODE,NAME,ELEVATION,MAGNETICVARIATION,LATITUDE,LONGITUDE,COMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,CITYCODE,CRC ");
			strSql.Append(" FROM AIRPORT ");
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
			strSql.Append("select count(1) FROM AIRPORT ");
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
				strSql.Append("order by T.AIRPORTCODE desc");
			}
			strSql.Append(")AS Row, T.*  from AIRPORT T ");
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
			parameters[0].Value = "AIRPORT";
			parameters[1].Value = "AIRPORTCODE";
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

