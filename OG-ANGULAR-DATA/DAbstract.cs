using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace OG_ANGULAR_DATA
{
    public abstract class DAbstract
    {
        private readonly string _connectionString;
        private protected SqlConnection _sqlConnection;
        public DAbstract()
        {
            _connectionString = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"))
                .Build()
                .GetConnectionString("SQLConnectionString");
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public DataTable ExecuteQuery(string storedProcedure, List<SqlParameter> parameters)
        {
            try
            {
                DataTable dt = new DataTable();
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
        public int ExecuteCommand(string storedProcedure, List<SqlParameter> parameters)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters.ToArray());
                int commandResult = command.ExecuteNonQuery();
                return commandResult;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
        public bool ExecuteScalar(string storedProcedure, List<SqlParameter> parameters)
        {
            try
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand(storedProcedure, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters.ToArray());
                bool commandResult = Convert.ToBoolean(command.ExecuteScalar());
                return commandResult;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
        public Object ExecuteCommandOutput(string storedProcedure, List<SqlParameter> parameters)
        {
            try
            {
                _sqlConnection.Open();
                string outputParameterName = parameters.FirstOrDefault(x => x.Direction == ParameterDirection.Output).ParameterName;
                SqlCommand command = new SqlCommand(storedProcedure, _sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters.ToArray());
                Object commandResult = command.Parameters[outputParameterName].Value;
                return commandResult;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
        }
    }
}
