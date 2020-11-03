using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using OG_ANGULAR_ENTITIES;


namespace OG_ANGULAR_DATA
{
    public class DPersona : DAbstract
    {
        public DataTable GetPersonas()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = ExecuteQuery("SP_Persona_CON", new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DPersona GetPersonas: " + ex.Message);
            }
            return dt;
        }
        public DataRow GetPersona(int Id)
        {
            DataRow r;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Id", SqlDbType = SqlDbType.Int, Value = Id });
                DataTable dt = ExecuteQuery("SP_Persona_Id", parameters);
                r = dt.Rows[0];
            }
            catch (Exception ex)
            {
                r = new DataTable().NewRow();
                throw new ApplicationException("DPersona GetPersona: " + ex.Message);
            }
            return r;
        }
        public int Ingresar(EPersona persona)
        {
            int commandResult = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Nombre", SqlDbType = SqlDbType.VarChar, Value = persona.Nombre });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@AP", SqlDbType = SqlDbType.VarChar, Value = persona.AP });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@AM", SqlDbType = SqlDbType.VarChar, Value = persona.AM });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Edad", SqlDbType = SqlDbType.Int, Value = persona.Edad });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Estatura", SqlDbType = SqlDbType.Decimal, Value = persona.Estatura });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Peso", SqlDbType = SqlDbType.Decimal, Value = persona.Peso });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@FechaN", SqlDbType = SqlDbType.DateTime, Value = persona.FechaN });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Activo", SqlDbType = SqlDbType.Bit, Value = persona.Activo });
                commandResult = ExecuteCommand("SP_Persona_INS",parameters);
            }
            catch (Exception ex)
            {
                commandResult = 0;
                throw new ApplicationException("DPersona Ingresar: " + ex.Message);
            }
            return commandResult;
        }
        public int Modificar(EPersona persona)
        {
            int commandResult = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Id", SqlDbType = SqlDbType.Int, Value = persona.Id });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Nombre", SqlDbType = SqlDbType.VarChar, Value = persona.Nombre });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@AP", SqlDbType = SqlDbType.VarChar, Value = persona.AP });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@AM", SqlDbType = SqlDbType.VarChar, Value = persona.AM });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Edad", SqlDbType = SqlDbType.Int, Value = persona.Edad });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Estatura", SqlDbType = SqlDbType.Decimal, Value = persona.Estatura });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Peso", SqlDbType = SqlDbType.Decimal, Value = persona.Peso });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@FechaN", SqlDbType = SqlDbType.DateTime, Value = persona.FechaN });
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Activo", SqlDbType = SqlDbType.Bit, Value = persona.Activo });
                commandResult = ExecuteCommand("SP_Persona_UPD", parameters);
            }
            catch (Exception ex)
            {
                commandResult = 0;
                throw new ApplicationException("DPersona Modificar: " + ex.Message);
            }
            return commandResult;
        }
        public int Eliminar(int id)
        {
            int commandResult = 0;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter() { Direction = ParameterDirection.Input, ParameterName = "@Id", SqlDbType = SqlDbType.Int, Value = id });
                commandResult = ExecuteCommand("SP_Persona_DEL", parameters);
            }
            catch (Exception ex)
            {
                commandResult = 0;
                throw new ApplicationException("DPersona Eliminar: " + ex.Message);
            }
            return commandResult;
        }
    }
}
