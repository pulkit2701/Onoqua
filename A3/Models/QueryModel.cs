using A3.Model;
using System.Collections.Generic;


namespace A3.Models
{
    public class QueryModel
    {
        public List<DBProvider> Queries { get; set; }
        public DBProvider Query { get; set; }
        public ConnectionString ConnectionString { get; set; }
    }
}