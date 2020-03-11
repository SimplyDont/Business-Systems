using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALT_R_Management_Library.Sql.Internal
{
    internal class SqlHelper
    {
        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public static async Task<IList<T>> GetData<T>(string procedureName,string configName,params object[] parameters)
        {
            var connectionStr=GetConnectionString(configName);
            using (IDbConnection db=new SqlConnection(connectionStr))
            {
                var output = await db.QueryAsync<T>(procedureName, parameters,commandType:CommandType.StoredProcedure);

                return output.ToList();
            }
        }

        public static async void SaveData(string procedureName, string configName, params object[] parameters)
        {
            var connectionStr = GetConnectionString(configName);
            using (IDbConnection db = new SqlConnection(connectionStr))
            {
                var output = await db.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            }
        }
    }
}
