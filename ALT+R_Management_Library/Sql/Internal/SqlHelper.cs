using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_WebApi.Sql.Internal
{
    public class SqlHelper
    {
        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public static IList<T> GetData<T,U>(string procedureName,string configName, U parameters)
        {
            var connectionStr=GetConnectionString(configName);
            using (IDbConnection db=new SqlConnection(connectionStr))
            {
                var output = db.Query<T>(procedureName, parameters,commandType:CommandType.StoredProcedure);

                return output.ToList();
            }
        }

        public static IList<T> GetData<T>(string procedureName, string configName)
        {
            var connectionStr = GetConnectionString(configName);
            using (IDbConnection db = new SqlConnection(connectionStr))
            {
                var output = db.Query<T>(procedureName, commandType: CommandType.StoredProcedure);

                return output.ToList();
            }
        }

        public static void SaveData<U>(string procedureName, string configName, U parameters)
        {
            var connectionStr = GetConnectionString(configName);
            using (IDbConnection db = new SqlConnection(connectionStr))
            {
                var output = db.Execute(procedureName, parameters, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
