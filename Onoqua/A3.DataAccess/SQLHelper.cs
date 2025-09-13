using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace A3.DataAccess
{
    public class SQLHelper : IDataAccess
    {
        SqlCommand cmd = new SqlCommand();

        public SQLHelper()
        { }

        public SQLHelper(string connectionString)
        {
            ConnectionString = connectionString;

        }

        public string ConnectionString { get; set; }

        public void ExecuteNonQuery(string storeProcName, List<FieldValue> parameters)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            GetData(storeProcName, parameters);

        }

        public DataSet GetDataSet(string storeProcName, List<FieldValue> parameters)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            return GetData(storeProcName, parameters);
        }


        public DataTable GetDataTable(string command, bool isStoreProc, List<FieldValue> parameters)
        {

            cmd.CommandType = isStoreProc ? CommandType.StoredProcedure : CommandType.Text;
            var dt = GetData(command, parameters, isStoreProc);
            if (dt.Tables.Count > 0)
                return dt.Tables[0];
            return null;
        }

        DataSet GetData(string command, List<FieldValue> parameters, bool isStoreProc = false)
        {
            var sqlDB = new SqlDatabase(ConnectionString);
            command = SetParameters(command, parameters);
            var c = isStoreProc ? sqlDB.GetStoredProcCommand(command) : sqlDB.GetSqlStringCommand(command);
            foreach (FieldValue item in parameters)
                c.Parameters.Add(new SqlParameter(item.Field, item.Value));
            return sqlDB.ExecuteDataSet(c);

        }

        private string SetParameters(string command, List<FieldValue> parameters)
        {
            int ctr = 0;
            while (ctr < parameters.Count)
            {
                command = command.Replace("{" + parameters[ctr].Field + "}", "@" + parameters[ctr].Field.Replace(" ", ""));
                parameters[ctr].Field = "@" + parameters[ctr].Field.Replace(" ", "");
                ctr++;
            }
            if (command.GetFields().Count > 0) throw new Exception("There are missing parameters in query :" + command);
            return command;
        }
    }
}
