using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DQMA.Infrastructure.Database
{
    public interface IDatabaseService
    {
        Task<DataTable> GetDBLocalData(string query, IDictionary<string, object> parameters, CommandType command = CommandType.Text);
    }

    public class DatabaseService : IDatabaseService
    {
        private string _databaseConnectionString;

        public DatabaseService(IConfiguration configuration)
        {
            _databaseConnectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
        }

        public Task<DataTable> GetDBLocalData(string query, IDictionary<string, object> parameters, CommandType command = CommandType.Text)
        {
            return Task.Run(() =>
            {
                DataTable dt = new DataTable();

                using (SqlConnection con = new SqlConnection(_databaseConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = command;
                    cmd.CommandTimeout = 300;

                    foreach (var param in parameters)
                        cmd.Parameters.AddWithValue(param.Key, param.Value);

                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                return dt;
            });
        }
    }
}
