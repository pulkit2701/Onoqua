using System.Collections.Generic;
using System.Data;
using A3.Common;

namespace Onoqua.Entities
{
    public interface IDataHelper
    {
        string ConnectionString { get; set; }

        void ExecuteNonQuery(string storeProcName, List<FieldValue> parameters);
        DataSet GetDataSet(string storeProcName, List<FieldValue> parameters);
        DataTable GetDataTable(string command, bool isStoreProc, List<FieldValue> parameters);
    }
}