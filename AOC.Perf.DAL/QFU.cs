using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using AOC.Perf.DBUtility;//Please add references
namespace AOC.Perf.DAL
{
	/// <summary>
	/// 数据访问类:QFU
	/// </summary>
	public partial class QFU
	{
		public QFU()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("QFUCODE", "QFU"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int QFUCODE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from QFU");
			strSql.Append(" where QFUCODE=@QFUCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUCODE;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(AOC.Perf.Model.QFU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into QFU(");
			strSql.Append("IDENT,TORA,ASDA,LDA,TODA,ENTRYANGLE,SLOPE,THRESHOLDLATITUDE,THRESHOLDLONGITUDE,THRESHOLDELEVATION,APPROACHSLOPE,COMMENTS,TOCOMMENTS,LDCOMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,TAKEOFFSHIFT,GROOVEDPFCSURFACETO,GROOVEDPFCSURFACELD,GLIDESLOPE,IncrementGAHeight,GROOVEDPFCSTOPWAY,RUNWAYPAVEMENT,MinKVs,MaxKVs,APPLICABILITY,RUNWAYPAVEMENTCBR,CRC,THRUSTREDUCTIONHEIGHT,ACCELERATIONHEIGHT,CLIMBSPEEDLIMITSTATUS,INITIALCLIMBSPEED,SPEEDLIMITALT,FINALCLIMBSPEED)");
			strSql.Append(" values (");
			strSql.Append("@IDENT,@TORA,@ASDA,@LDA,@TODA,@ENTRYANGLE,@SLOPE,@THRESHOLDLATITUDE,@THRESHOLDLONGITUDE,@THRESHOLDELEVATION,@APPROACHSLOPE,@COMMENTS,@TOCOMMENTS,@LDCOMMENTS,@CREATIONDATE,@UPDATEDATE,@UPDATETIME,@LASTUPDATE,@TAKEOFFSHIFT,@GROOVEDPFCSURFACETO,@GROOVEDPFCSURFACELD,@GLIDESLOPE,@IncrementGAHeight,@GROOVEDPFCSTOPWAY,@RUNWAYPAVEMENT,@MinKVs,@MaxKVs,@APPLICABILITY,@RUNWAYPAVEMENTCBR,@CRC,@THRUSTREDUCTIONHEIGHT,@ACCELERATIONHEIGHT,@CLIMBSPEEDLIMITSTATUS,@INITIALCLIMBSPEED,@SPEEDLIMITALT,@FINALCLIMBSPEED)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@IDENT", OleDbType.VarChar,10),
					new OleDbParameter("@TORA", OleDbType.Double),
					new OleDbParameter("@ASDA", OleDbType.Double),
					new OleDbParameter("@LDA", OleDbType.Double),
					new OleDbParameter("@TODA", OleDbType.Double),
					new OleDbParameter("@ENTRYANGLE", OleDbType.Integer,4),
					new OleDbParameter("@SLOPE", OleDbType.Double),
					new OleDbParameter("@THRESHOLDLATITUDE", OleDbType.Integer,4),
					new OleDbParameter("@THRESHOLDLONGITUDE", OleDbType.Integer,4),
					new OleDbParameter("@THRESHOLDELEVATION", OleDbType.Double),
					new OleDbParameter("@APPROACHSLOPE", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@TOCOMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@LDCOMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@TAKEOFFSHIFT", OleDbType.Double),
					new OleDbParameter("@GROOVEDPFCSURFACETO", OleDbType.Boolean,1),
					new OleDbParameter("@GROOVEDPFCSURFACELD", OleDbType.Boolean,1),
					new OleDbParameter("@GLIDESLOPE", OleDbType.Double),
					new OleDbParameter("@IncrementGAHeight", OleDbType.Double),
					new OleDbParameter("@GROOVEDPFCSTOPWAY", OleDbType.Boolean,1),
					new OleDbParameter("@RUNWAYPAVEMENT", OleDbType.Boolean,1),
					new OleDbParameter("@MinKVs", OleDbType.Double),
					new OleDbParameter("@MaxKVs", OleDbType.Double),
					new OleDbParameter("@APPLICABILITY", OleDbType.Integer,4),
					new OleDbParameter("@RUNWAYPAVEMENTCBR", OleDbType.Double),
					new OleDbParameter("@CRC", OleDbType.VarChar,255),
					new OleDbParameter("@THRUSTREDUCTIONHEIGHT", OleDbType.Double),
					new OleDbParameter("@ACCELERATIONHEIGHT", OleDbType.Double),
					new OleDbParameter("@CLIMBSPEEDLIMITSTATUS", OleDbType.Boolean,1),
					new OleDbParameter("@INITIALCLIMBSPEED", OleDbType.Double),
					new OleDbParameter("@SPEEDLIMITALT", OleDbType.VarChar,20),
					new OleDbParameter("@FINALCLIMBSPEED", OleDbType.Double)};
			parameters[0].Value = model.IDENT;
			parameters[1].Value = model.TORA;
			parameters[2].Value = model.ASDA;
			parameters[3].Value = model.LDA;
			parameters[4].Value = model.TODA;
			parameters[5].Value = model.ENTRYANGLE;
			parameters[6].Value = model.SLOPE;
			parameters[7].Value = model.THRESHOLDLATITUDE;
			parameters[8].Value = model.THRESHOLDLONGITUDE;
			parameters[9].Value = model.THRESHOLDELEVATION;
			parameters[10].Value = model.APPROACHSLOPE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.TOCOMMENTS;
			parameters[13].Value = model.LDCOMMENTS;
			parameters[14].Value = model.CREATIONDATE;
			parameters[15].Value = model.UPDATEDATE;
			parameters[16].Value = model.UPDATETIME;
			parameters[17].Value = model.LASTUPDATE;
			parameters[18].Value = model.TAKEOFFSHIFT;
			parameters[19].Value = model.GROOVEDPFCSURFACETO;
			parameters[20].Value = model.GROOVEDPFCSURFACELD;
			parameters[21].Value = model.GLIDESLOPE;
			parameters[22].Value = model.IncrementGAHeight;
			parameters[23].Value = model.GROOVEDPFCSTOPWAY;
			parameters[24].Value = model.RUNWAYPAVEMENT;
			parameters[25].Value = model.MinKVs;
			parameters[26].Value = model.MaxKVs;
			parameters[27].Value = model.APPLICABILITY;
			parameters[28].Value = model.RUNWAYPAVEMENTCBR;
			parameters[29].Value = model.CRC;
			parameters[30].Value = model.THRUSTREDUCTIONHEIGHT;
			parameters[31].Value = model.ACCELERATIONHEIGHT;
			parameters[32].Value = model.CLIMBSPEEDLIMITSTATUS;
			parameters[33].Value = model.INITIALCLIMBSPEED;
			parameters[34].Value = model.SPEEDLIMITALT;
			parameters[35].Value = model.FINALCLIMBSPEED;

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
		public bool Update(AOC.Perf.Model.QFU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update QFU set ");
			strSql.Append("IDENT=@IDENT,");
			strSql.Append("TORA=@TORA,");
			strSql.Append("ASDA=@ASDA,");
			strSql.Append("LDA=@LDA,");
			strSql.Append("TODA=@TODA,");
			strSql.Append("ENTRYANGLE=@ENTRYANGLE,");
			strSql.Append("SLOPE=@SLOPE,");
			strSql.Append("THRESHOLDLATITUDE=@THRESHOLDLATITUDE,");
			strSql.Append("THRESHOLDLONGITUDE=@THRESHOLDLONGITUDE,");
			strSql.Append("THRESHOLDELEVATION=@THRESHOLDELEVATION,");
			strSql.Append("APPROACHSLOPE=@APPROACHSLOPE,");
			strSql.Append("COMMENTS=@COMMENTS,");
			strSql.Append("TOCOMMENTS=@TOCOMMENTS,");
			strSql.Append("LDCOMMENTS=@LDCOMMENTS,");
			strSql.Append("CREATIONDATE=@CREATIONDATE,");
			strSql.Append("UPDATEDATE=@UPDATEDATE,");
			strSql.Append("UPDATETIME=@UPDATETIME,");
			strSql.Append("LASTUPDATE=@LASTUPDATE,");
			strSql.Append("TAKEOFFSHIFT=@TAKEOFFSHIFT,");
			strSql.Append("GROOVEDPFCSURFACETO=@GROOVEDPFCSURFACETO,");
			strSql.Append("GROOVEDPFCSURFACELD=@GROOVEDPFCSURFACELD,");
			strSql.Append("GLIDESLOPE=@GLIDESLOPE,");
			strSql.Append("IncrementGAHeight=@IncrementGAHeight,");
			strSql.Append("GROOVEDPFCSTOPWAY=@GROOVEDPFCSTOPWAY,");
			strSql.Append("RUNWAYPAVEMENT=@RUNWAYPAVEMENT,");
			strSql.Append("MinKVs=@MinKVs,");
			strSql.Append("MaxKVs=@MaxKVs,");
			strSql.Append("APPLICABILITY=@APPLICABILITY,");
			strSql.Append("RUNWAYPAVEMENTCBR=@RUNWAYPAVEMENTCBR,");
			strSql.Append("CRC=@CRC,");
			strSql.Append("THRUSTREDUCTIONHEIGHT=@THRUSTREDUCTIONHEIGHT,");
			strSql.Append("ACCELERATIONHEIGHT=@ACCELERATIONHEIGHT,");
			strSql.Append("CLIMBSPEEDLIMITSTATUS=@CLIMBSPEEDLIMITSTATUS,");
			strSql.Append("INITIALCLIMBSPEED=@INITIALCLIMBSPEED,");
			strSql.Append("SPEEDLIMITALT=@SPEEDLIMITALT,");
			strSql.Append("FINALCLIMBSPEED=@FINALCLIMBSPEED");
			strSql.Append(" where QFUCODE=@QFUCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@IDENT", OleDbType.VarChar,10),
					new OleDbParameter("@TORA", OleDbType.Double),
					new OleDbParameter("@ASDA", OleDbType.Double),
					new OleDbParameter("@LDA", OleDbType.Double),
					new OleDbParameter("@TODA", OleDbType.Double),
					new OleDbParameter("@ENTRYANGLE", OleDbType.Integer,4),
					new OleDbParameter("@SLOPE", OleDbType.Double),
					new OleDbParameter("@THRESHOLDLATITUDE", OleDbType.Integer,4),
					new OleDbParameter("@THRESHOLDLONGITUDE", OleDbType.Integer,4),
					new OleDbParameter("@THRESHOLDELEVATION", OleDbType.Double),
					new OleDbParameter("@APPROACHSLOPE", OleDbType.Double),
					new OleDbParameter("@COMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@TOCOMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@LDCOMMENTS", OleDbType.VarChar,0),
					new OleDbParameter("@CREATIONDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATEDATE", OleDbType.Integer,4),
					new OleDbParameter("@UPDATETIME", OleDbType.Integer,4),
					new OleDbParameter("@LASTUPDATE", OleDbType.Integer,4),
					new OleDbParameter("@TAKEOFFSHIFT", OleDbType.Double),
					new OleDbParameter("@GROOVEDPFCSURFACETO", OleDbType.Boolean,1),
					new OleDbParameter("@GROOVEDPFCSURFACELD", OleDbType.Boolean,1),
					new OleDbParameter("@GLIDESLOPE", OleDbType.Double),
					new OleDbParameter("@IncrementGAHeight", OleDbType.Double),
					new OleDbParameter("@GROOVEDPFCSTOPWAY", OleDbType.Boolean,1),
					new OleDbParameter("@RUNWAYPAVEMENT", OleDbType.Boolean,1),
					new OleDbParameter("@MinKVs", OleDbType.Double),
					new OleDbParameter("@MaxKVs", OleDbType.Double),
					new OleDbParameter("@APPLICABILITY", OleDbType.Integer,4),
					new OleDbParameter("@RUNWAYPAVEMENTCBR", OleDbType.Double),
					new OleDbParameter("@CRC", OleDbType.VarChar,255),
					new OleDbParameter("@THRUSTREDUCTIONHEIGHT", OleDbType.Double),
					new OleDbParameter("@ACCELERATIONHEIGHT", OleDbType.Double),
					new OleDbParameter("@CLIMBSPEEDLIMITSTATUS", OleDbType.Boolean,1),
					new OleDbParameter("@INITIALCLIMBSPEED", OleDbType.Double),
					new OleDbParameter("@SPEEDLIMITALT", OleDbType.VarChar,20),
					new OleDbParameter("@FINALCLIMBSPEED", OleDbType.Double),
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4)};
			parameters[0].Value = model.IDENT;
			parameters[1].Value = model.TORA;
			parameters[2].Value = model.ASDA;
			parameters[3].Value = model.LDA;
			parameters[4].Value = model.TODA;
			parameters[5].Value = model.ENTRYANGLE;
			parameters[6].Value = model.SLOPE;
			parameters[7].Value = model.THRESHOLDLATITUDE;
			parameters[8].Value = model.THRESHOLDLONGITUDE;
			parameters[9].Value = model.THRESHOLDELEVATION;
			parameters[10].Value = model.APPROACHSLOPE;
			parameters[11].Value = model.COMMENTS;
			parameters[12].Value = model.TOCOMMENTS;
			parameters[13].Value = model.LDCOMMENTS;
			parameters[14].Value = model.CREATIONDATE;
			parameters[15].Value = model.UPDATEDATE;
			parameters[16].Value = model.UPDATETIME;
			parameters[17].Value = model.LASTUPDATE;
			parameters[18].Value = model.TAKEOFFSHIFT;
			parameters[19].Value = model.GROOVEDPFCSURFACETO;
			parameters[20].Value = model.GROOVEDPFCSURFACELD;
			parameters[21].Value = model.GLIDESLOPE;
			parameters[22].Value = model.IncrementGAHeight;
			parameters[23].Value = model.GROOVEDPFCSTOPWAY;
			parameters[24].Value = model.RUNWAYPAVEMENT;
			parameters[25].Value = model.MinKVs;
			parameters[26].Value = model.MaxKVs;
			parameters[27].Value = model.APPLICABILITY;
			parameters[28].Value = model.RUNWAYPAVEMENTCBR;
			parameters[29].Value = model.CRC;
			parameters[30].Value = model.THRUSTREDUCTIONHEIGHT;
			parameters[31].Value = model.ACCELERATIONHEIGHT;
			parameters[32].Value = model.CLIMBSPEEDLIMITSTATUS;
			parameters[33].Value = model.INITIALCLIMBSPEED;
			parameters[34].Value = model.SPEEDLIMITALT;
			parameters[35].Value = model.FINALCLIMBSPEED;
			parameters[36].Value = model.QFUCODE;

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
		public bool Delete(int QFUCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFU ");
			strSql.Append(" where QFUCODE=@QFUCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUCODE;

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
		public bool DeleteList(string QFUCODElist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from QFU ");
			strSql.Append(" where QFUCODE in ("+QFUCODElist + ")  ");
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
		public AOC.Perf.Model.QFU GetModel(int QFUCODE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QFUCODE,IDENT,TORA,ASDA,LDA,TODA,ENTRYANGLE,SLOPE,THRESHOLDLATITUDE,THRESHOLDLONGITUDE,THRESHOLDELEVATION,APPROACHSLOPE,COMMENTS,TOCOMMENTS,LDCOMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,TAKEOFFSHIFT,GROOVEDPFCSURFACETO,GROOVEDPFCSURFACELD,GLIDESLOPE,IncrementGAHeight,GROOVEDPFCSTOPWAY,RUNWAYPAVEMENT,MinKVs,MaxKVs,APPLICABILITY,RUNWAYPAVEMENTCBR,CRC,THRUSTREDUCTIONHEIGHT,ACCELERATIONHEIGHT,CLIMBSPEEDLIMITSTATUS,INITIALCLIMBSPEED,SPEEDLIMITALT,FINALCLIMBSPEED from QFU ");
			strSql.Append(" where QFUCODE=@QFUCODE");
			OleDbParameter[] parameters = {
					new OleDbParameter("@QFUCODE", OleDbType.Integer,4)
			};
			parameters[0].Value = QFUCODE;

			AOC.Perf.Model.QFU model=new AOC.Perf.Model.QFU();
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
		public AOC.Perf.Model.QFU DataRowToModel(DataRow row)
		{
			AOC.Perf.Model.QFU model=new AOC.Perf.Model.QFU();
			if (row != null)
			{
				if(row["QFUCODE"]!=null && row["QFUCODE"].ToString()!="")
				{
					model.QFUCODE=int.Parse(row["QFUCODE"].ToString());
				}
				if(row["IDENT"]!=null)
				{
					model.IDENT=row["IDENT"].ToString();
				}
                if (row["TORA"] != null && row["TORA"].ToString() != "")
                {
                    model.TORA = double.Parse(row["TORA"].ToString());
                }
                if (row["ASDA"] != null && row["ASDA"].ToString() != "")
                {
                    model.ASDA = double.Parse(row["ASDA"].ToString());
                }
                if (row["LDA"] != null && row["LDA"].ToString() != "")
                {
                    model.LDA = double.Parse(row["LDA"].ToString());
                }
                if (row["TODA"] != null && row["TODA"].ToString() != "")
                {
                    model.TODA = double.Parse(row["TODA"].ToString());
                }
                if (row["ENTRYANGLE"]!=null && row["ENTRYANGLE"].ToString()!="")
				{
					model.ENTRYANGLE=int.Parse(row["ENTRYANGLE"].ToString());
				}
                if (row["SLOPE"] != null && row["SLOPE"].ToString() != "")
                {
                    model.SLOPE = double.Parse(row["SLOPE"].ToString());
                }
                if (row["THRESHOLDLATITUDE"]!=null && row["THRESHOLDLATITUDE"].ToString()!="")
				{
					model.THRESHOLDLATITUDE=int.Parse(row["THRESHOLDLATITUDE"].ToString());
				}
				if(row["THRESHOLDLONGITUDE"]!=null && row["THRESHOLDLONGITUDE"].ToString()!="")
				{
					model.THRESHOLDLONGITUDE=int.Parse(row["THRESHOLDLONGITUDE"].ToString());
				}
                if (row["THRESHOLDELEVATION"] != null && row["THRESHOLDELEVATION"].ToString() != "")
                {
                    model.THRESHOLDELEVATION = double.Parse(row["THRESHOLDELEVATION"].ToString());
                }
                if (row["APPROACHSLOPE"] != null && row["APPROACHSLOPE"].ToString() != "")
                {
                    model.APPROACHSLOPE = double.Parse(row["APPROACHSLOPE"].ToString());
                }
                if (row["COMMENTS"]!=null)
				{
					model.COMMENTS=row["COMMENTS"].ToString();
				}
				if(row["TOCOMMENTS"]!=null)
				{
					model.TOCOMMENTS=row["TOCOMMENTS"].ToString();
				}
				if(row["LDCOMMENTS"]!=null)
				{
					model.LDCOMMENTS=row["LDCOMMENTS"].ToString();
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
                if (row["TAKEOFFSHIFT"] != null && row["TAKEOFFSHIFT"].ToString() != "")
                {
                    model.TAKEOFFSHIFT = double.Parse(row["TAKEOFFSHIFT"].ToString());
                }

                if (row["GROOVEDPFCSURFACETO"]!=null && row["GROOVEDPFCSURFACETO"].ToString()!="")
				{
					if((row["GROOVEDPFCSURFACETO"].ToString()=="1")||(row["GROOVEDPFCSURFACETO"].ToString().ToLower()=="true"))
					{
						model.GROOVEDPFCSURFACETO=true;
					}
					else
					{
						model.GROOVEDPFCSURFACETO=false;
					}
				}
				if(row["GROOVEDPFCSURFACELD"]!=null && row["GROOVEDPFCSURFACELD"].ToString()!="")
				{
					if((row["GROOVEDPFCSURFACELD"].ToString()=="1")||(row["GROOVEDPFCSURFACELD"].ToString().ToLower()=="true"))
					{
						model.GROOVEDPFCSURFACELD=true;
					}
					else
					{
						model.GROOVEDPFCSURFACELD=false;
					}
				}
                if (row["GLIDESLOPE"] != null && row["GLIDESLOPE"].ToString() != "")
                {
                    model.GLIDESLOPE = double.Parse(row["GLIDESLOPE"].ToString());
                }
                if (row["IncrementGAHeight"] != null && row["IncrementGAHeight"].ToString() != "")
                {
                    model.IncrementGAHeight = double.Parse(row["IncrementGAHeight"].ToString());
                }

                //model.GLIDESLOPE=row["GLIDESLOPE"].ToString();
                //model.IncrementGAHeight=row["IncrementGAHeight"].ToString();
                if (row["GROOVEDPFCSTOPWAY"]!=null && row["GROOVEDPFCSTOPWAY"].ToString()!="")
				{
					if((row["GROOVEDPFCSTOPWAY"].ToString()=="1")||(row["GROOVEDPFCSTOPWAY"].ToString().ToLower()=="true"))
					{
						model.GROOVEDPFCSTOPWAY=true;
					}
					else
					{
						model.GROOVEDPFCSTOPWAY=false;
					}
				}
				if(row["RUNWAYPAVEMENT"]!=null && row["RUNWAYPAVEMENT"].ToString()!="")
				{
					if((row["RUNWAYPAVEMENT"].ToString()=="1")||(row["RUNWAYPAVEMENT"].ToString().ToLower()=="true"))
					{
						model.RUNWAYPAVEMENT=true;
					}
					else
					{
						model.RUNWAYPAVEMENT=false;
					}
				}
                if (row["MinKVs"] != null && row["MinKVs"].ToString() != "")
                {
                    model.MinKVs = double.Parse(row["MinKVs"].ToString());
                }
                if (row["MaxKVs"] != null && row["MaxKVs"].ToString() != "")
                {
                    model.MaxKVs = double.Parse(row["MaxKVs"].ToString());
                }

                //model.MinKVs=row["MinKVs"].ToString();
                //model.MaxKVs=row["MaxKVs"].ToString();
                if (row["APPLICABILITY"]!=null && row["APPLICABILITY"].ToString()!="")
				{
					model.APPLICABILITY=int.Parse(row["APPLICABILITY"].ToString());
				}
                if (row["RUNWAYPAVEMENTCBR"] != null && row["RUNWAYPAVEMENTCBR"].ToString() != "")
                {
                    model.RUNWAYPAVEMENTCBR = double.Parse(row["RUNWAYPAVEMENTCBR"].ToString());
                }
                //model.RUNWAYPAVEMENTCBR=row["RUNWAYPAVEMENTCBR"].ToString();
                if (row["CRC"]!=null)
				{
					model.CRC=row["CRC"].ToString();
				}

                if (row["THRUSTREDUCTIONHEIGHT"] != null && row["THRUSTREDUCTIONHEIGHT"].ToString() != "")
                {
                    model.THRUSTREDUCTIONHEIGHT = double.Parse(row["THRUSTREDUCTIONHEIGHT"].ToString());
                }
                if (row["ACCELERATIONHEIGHT"] != null && row["ACCELERATIONHEIGHT"].ToString() != "")
                {
                    model.ACCELERATIONHEIGHT = double.Parse(row["ACCELERATIONHEIGHT"].ToString());
                }
                //model.THRUSTREDUCTIONHEIGHT=row["THRUSTREDUCTIONHEIGHT"].ToString();
                //model.ACCELERATIONHEIGHT=row["ACCELERATIONHEIGHT"].ToString();
                if (row["CLIMBSPEEDLIMITSTATUS"]!=null && row["CLIMBSPEEDLIMITSTATUS"].ToString()!="")
				{
					if((row["CLIMBSPEEDLIMITSTATUS"].ToString()=="1")||(row["CLIMBSPEEDLIMITSTATUS"].ToString().ToLower()=="true"))
					{
						model.CLIMBSPEEDLIMITSTATUS=true;
					}
					else
					{
						model.CLIMBSPEEDLIMITSTATUS=false;
					}
				}
                if (row["INITIALCLIMBSPEED"] != null && row["INITIALCLIMBSPEED"].ToString() != "")
                {
                    model.INITIALCLIMBSPEED = double.Parse(row["INITIALCLIMBSPEED"].ToString());
                }
                //model.INITIALCLIMBSPEED=row["INITIALCLIMBSPEED"].ToString();
                if (row["SPEEDLIMITALT"]!=null)
				{
					model.SPEEDLIMITALT=row["SPEEDLIMITALT"].ToString();
				}
                if (row["FINALCLIMBSPEED"] != null && row["FINALCLIMBSPEED"].ToString() != "")
                {
                    model.FINALCLIMBSPEED = double.Parse(row["FINALCLIMBSPEED"].ToString());
                }
                //model.FINALCLIMBSPEED=row["FINALCLIMBSPEED"].ToString();
            }
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select QFUCODE,IDENT,TORA,ASDA,LDA,TODA,ENTRYANGLE,SLOPE,THRESHOLDLATITUDE,THRESHOLDLONGITUDE,THRESHOLDELEVATION,APPROACHSLOPE,COMMENTS,TOCOMMENTS,LDCOMMENTS,CREATIONDATE,UPDATEDATE,UPDATETIME,LASTUPDATE,TAKEOFFSHIFT,GROOVEDPFCSURFACETO,GROOVEDPFCSURFACELD,GLIDESLOPE,IncrementGAHeight,GROOVEDPFCSTOPWAY,RUNWAYPAVEMENT,MinKVs,MaxKVs,APPLICABILITY,RUNWAYPAVEMENTCBR,CRC,THRUSTREDUCTIONHEIGHT,ACCELERATIONHEIGHT,CLIMBSPEEDLIMITSTATUS,INITIALCLIMBSPEED,SPEEDLIMITALT,FINALCLIMBSPEED ");
			strSql.Append(" FROM QFU ");
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
			strSql.Append("select count(1) FROM QFU ");
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
				strSql.Append("order by T.QFUCODE desc");
			}
			strSql.Append(")AS Row, T.*  from QFU T ");
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
			parameters[0].Value = "QFU";
			parameters[1].Value = "QFUCODE";
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

