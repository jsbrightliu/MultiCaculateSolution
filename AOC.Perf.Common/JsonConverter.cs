using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;

namespace AOC.Perf.Common
{
    public class JsonConverter
    {
        /// <summary>
        /// 将对象序列号为JSON对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">对象实例</param>
        /// <returns>JSON字符串</returns>
        public static string JsonSerialize<T>(T t)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(t);
        }

        /// <summary>
        /// JSON字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="strJson">JSON字符串</param>
        /// <returns>对象</returns>
        public static T JsonDeserialize<T>(string strJson)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Deserialize<T>(strJson);

        }

        /// <summary>
        /// DataTable序列化为JSON字符串 
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <returns>JSON字符串</returns>
        public static string TableToJsonSerialize(DataTable dt)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();

            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(dc.ColumnName, dr[dc].ToString());
                }
                list.Add(result);
            }
            return serializer.Serialize(list);
        }

        /// <summary> 
        /// 对象序列化为JSON字符串
        /// </summary> 
        /// <param name="obj">源对象</param> 
        /// <param name="recursionDepth">深度</param> 
        /// <returns>JSON字符串</returns> 
        public static string ObjectToJson(object obj, int recursionDepth)
        {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            serialize.RecursionLimit = recursionDepth;
            return serialize.Serialize(obj);
        }
    }
}
