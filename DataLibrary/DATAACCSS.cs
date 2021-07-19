using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameteres, string conectionString)
        {
            using (IDbConnection conection = new SqlConnection(conectionString))
            {
                var rows = await conection.QueryAsync<T>(sql, parameteres);

                return rows.ToList();
            }

        }

        public async Task<int> SaveData<T>(string sql, T parameteres, string conectionString)
        {
            
            using (IDbConnection connection = new SqlConnection(conectionString))
            {
                var answ= await connection.ExecuteAsync(sql, parameteres);

                return answ;

            }
        }


    }
}
