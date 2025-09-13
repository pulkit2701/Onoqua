using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onoqua.Models
{
    public class QueryModel
    {
        public List<DBProvider> Queries { get; set; }
        public DBProvider Query { get; set; }
        public ConnectionString ConnectionString { get; set; }
    }
}