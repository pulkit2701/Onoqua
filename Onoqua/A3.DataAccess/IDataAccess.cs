using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.DataAccess
{
    public interface IDataAccess
    {
        string ConnectionString { get; set; }
        void ExecuteNonQuery(string storeProcName, List<FieldValue> parameters);
        DataSet GetDataSet(string storeProcName, List<FieldValue> parameters);
        DataTable GetDataTable(string storeProcName, bool isStoreProc, List<FieldValue> parameters);
    }
}
